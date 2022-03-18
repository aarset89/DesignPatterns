using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.ChainOfResposibility
{
    public class ExcelFormat : Handler
    {
        public ExcelFormat(Handler next) : base(next)
        {
        }

        public override bool DoHandle(File file)
        {

            Console.WriteLine("Is Excel Format");

            return false;
        }

        public override string GetExtension()
        {
            return ".xls";
        }
    }
}
