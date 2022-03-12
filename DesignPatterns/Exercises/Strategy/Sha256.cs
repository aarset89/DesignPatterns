using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.Strategy
{
    public class Sha256 : IEncryptionAlgorithm
    {
        public string Encript(string message)
        {
            Console.WriteLine($"Encript {message} message by using SHA256 algorithm");
            return $"{message} encripted";
        }
    }
}
