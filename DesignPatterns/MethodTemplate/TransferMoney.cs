using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.MethodTemplate
{
    public class TransferMoney : TaskBase
    {
        protected override void DoExecute()
        {
            Console.WriteLine("Do Execute in TransferMoney class");
        }
    }
}
