using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.IteratorPattern
{
    public class ProductCollection
    {
        private List<Product> Products = new List<Product>();

        public void Push(Product product)
        {
            Products.Add(product);
        }


        public List<Product> GetProducts()
        {
            return Products;
        }

        public Iterator CreateIterator()
        {
            return new ListIterator(this);
        }

        public class ListIterator : Iterator
        {
            private readonly ProductCollection _productCollection;
            private int index;

            public ListIterator(ProductCollection productCollection)
            {
                _productCollection = productCollection;
            }
            public Product Current()
            {
                return _productCollection.GetProducts().ElementAt(index);
            }

            public bool HasNext()
            {
                return (index < _productCollection.GetProducts().Count);
            }

            public void Next()
            {
                index++;
            }
        }
    }
}
