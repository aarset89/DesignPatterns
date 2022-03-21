using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    public class Group : IComponent
    {
        private List<IComponent> _components = new List<IComponent>();

        public void AddComponent(IComponent component) => _components.Add(component);
        public void Render()
        {
            foreach(var component in _components)
                component.Render();
        }
    }
}
