using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.Proxy
{
    public class ProductProxy : Product
    {
        private DbContext _dbContext;
        public ProductProxy(int id, DbContext dbContext) : base(id)
        {
            _dbContext = dbContext;
        }

        public override void SetName(string name)
        {
            base.SetName(name);

            _dbContext.MarkAsChanged(this);
        }
    }
}
