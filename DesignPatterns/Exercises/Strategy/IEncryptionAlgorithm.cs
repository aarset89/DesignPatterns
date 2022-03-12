﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.Strategy
{
    public interface IEncryptionAlgorithm
    {
        string Encript(string message);
    }
}
