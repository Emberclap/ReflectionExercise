using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationAttributes.Attributes
{
    
    public class MyRangeAttribute : MyValidationAttribute
    {
        private int minvalue;
        private int maxvalue;
        public MyRangeAttribute(int minValue, int maxValue)
        {
            this.minvalue = minValue;
            this.maxvalue = maxValue;
        }
        public override bool IsValid(object obj) 
            => (int)obj >= minvalue && (int)obj < maxvalue;
        
    }
}
