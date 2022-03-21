using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.Composite
{
    public class Team : IComponent
    {
        private List<IComponent> _components = new List<IComponent>();

        public void AddComponent(IComponent component) => _components.Add(component);
        public void GoToEmergency()
        {
            foreach(var component in _components)
                component.GoToEmergency();
        }
    }
}
