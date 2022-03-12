using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.MethodTemplate
{
    public abstract class TaskBase
    {
        private AuditTrail _auditTrail;

        public TaskBase()
        {
            _auditTrail = new AuditTrail();
        }

        public TaskBase(AuditTrail auditTrail)
        {
            _auditTrail = auditTrail;
        }

        public void Execute()
        {
            _auditTrail.Record();

            DoExecute();
        }

        protected virtual void DoExecute()
        {
            Console.WriteLine("DoExecute from TaskBase Class");
        }
    }
}
