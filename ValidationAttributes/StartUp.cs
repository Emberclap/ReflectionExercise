﻿using System;
using System.ComponentModel.DataAnnotations;
using ValidationAttributes.Models;
using ValidationAttributes.Utils;

namespace ValidationAttributes
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var person = new Person("asd", 15);

            bool isValidEntity = Utils.Validator.IsValid(person);

            Console.WriteLine(isValidEntity);
        }
    }
}
