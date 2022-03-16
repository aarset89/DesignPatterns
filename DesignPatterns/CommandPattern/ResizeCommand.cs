﻿using DesignPatterns.CommandPattern.Fx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandPattern
{
    public class ResizeCommand : Command
    {
        public void Execute()
        {
            Console.WriteLine("Resizing");
        }
    }
}
