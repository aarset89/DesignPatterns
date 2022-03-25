using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.Matcha
{
    public class Controller
    {
        public void Render(string viewName, Dictionary<string, object> data)
        {
            var viewEngine = CreateViewEngine();
            var html = viewEngine.Render(viewName, data);

            Console.WriteLine(html);

        }

        protected virtual IViewEngine CreateViewEngine()
        {
            return new MatchaViewEngine();
        }
    }
}
