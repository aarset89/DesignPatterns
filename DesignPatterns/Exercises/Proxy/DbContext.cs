using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.Proxy
{
    public class DbContext// : IDbContext
    {
        private Dictionary<int, Product> _updatedObjects = new Dictionary<int, Product>();

        public Product GetProduct(int id)
        {
            // Automatically generate SQL statements
            // to read the product with the given ID.
            Console.WriteLine( string.Format(@"SELECT * FROM products WHERE product_id = {0} \n", id));

            // Simulate reading a product object from a database.
            var product = new ProductProxy(id,this);
            product.SetName("Product 1");

            return product;
        }

        public void SaveChanges()
        {
            // Automatically generate SQL statements
            // to update the database.
            foreach (var updatedObject in _updatedObjects.Values)
                Console.WriteLine(string.Format(@"UPDATE products SET name = '{0}' WHERE product_id = {1} \n", updatedObject.Name, updatedObject.Id));

            _updatedObjects.Clear();
        }

        public void MarkAsChanged(Product product)
        {
            if(!_updatedObjects.ContainsKey(product.Id))
                _updatedObjects.Add(product.Id, product);
        }
    }
}
