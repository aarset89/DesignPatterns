using System.Collections.Generic;

namespace DesignPatterns.Factory.Matcha
{
    public interface IViewEngine
    {
        string Render(string viewName, Dictionary<string, object> data);
    }
}