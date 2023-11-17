using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ValidationAttributes.Attributes;

namespace ValidationAttributes.Utils
{
    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            Type objType = obj.GetType();
            PropertyInfo[] types = objType
                .GetProperties()
                .Where(p=>p.CustomAttributes
                .Any(t=> typeof(MyValidationAttribute)
                .IsAssignableFrom(t.AttributeType)))
                .ToArray();
            foreach (PropertyInfo propertyInfo in types)
            {
                var attr = propertyInfo
                    .GetCustomAttributes()
                    .Where(ca=> typeof(MyValidationAttribute)
                    .IsAssignableFrom(ca.GetType()));

                foreach (MyValidationAttribute attribute in attr)
                {
                    if (!attribute.IsValid(propertyInfo.GetValue(obj)))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
