using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.ChainOfResposibility
{
    public class NumbersFormat : Handler
    {
        public NumbersFormat(Handler next) : base(next)
        {
        }

        public override bool DoHandle(File file)
        {
            Console.WriteLine("Numbers Format.");
            return false;
        }

        public override string GetExtension()
        {
            return ".numbers";
        }
    }
}
