using DesignPatterns.Factory.Matcha;
using DesignPatterns.Factory.Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public class ProductsController: Controller
    {
        public void GetProductsList()
        {
            //Get products from DB
            
            Dictionary<string, object> products = new Dictionary<string, object>();
            //Logic for data

            Render("ProductsView", products);
        }
    }
}
