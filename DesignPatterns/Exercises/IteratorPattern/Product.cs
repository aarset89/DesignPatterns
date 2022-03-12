using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.IteratorPattern
{
    public class Product
    {
        public int Id;
        public string Name;

        public Product(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public string toString()
        {
            return "Document{" +
                    "Id='" + Id + '\'' +
                    ", Name='" + Name + '\'' +
                    '}';
        }
    }
}
