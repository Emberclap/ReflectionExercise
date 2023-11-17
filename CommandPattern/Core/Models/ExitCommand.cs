﻿using CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CommandPattern.Core.Models
{
    internal class ExitCommand : ICommand
    {
        
        public string Execute(string[] args)
        {
            Environment.Exit(0);
            return default;
        }
    }
}
