using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.Matcha
{
    public class MatchaViewEngine : IViewEngine
    {
        public string Render(string viewName, Dictionary<string, object> data)
        {
            return "Rendered by Matcha";
        }
    }
}
