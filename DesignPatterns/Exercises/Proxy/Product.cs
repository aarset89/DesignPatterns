using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.Proxy
{
    public class Product
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public Product(int id)
        {
            Id = id;
        }

        public virtual void SetName(string name)
        {
            Name = name;
        }
    }
}
