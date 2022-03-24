using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.Protorype
{
    public class Timeline
    {
        private List<IComponent> components = new List<IComponent>();
        public void AddComponent(IComponent component)
        {
            components.Add(component);
        }

        public void Show()
        {
            foreach (IComponent component in components)
                component.Show();
        }
    }
}
