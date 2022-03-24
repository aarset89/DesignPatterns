using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.Protorype
{
    public class ContextMenu
    {
        private Timeline _timeline;
        public ContextMenu(Timeline timeline)
        {
            _timeline = timeline;
        }

        public void Duplicate(IComponent component)
        {
            var newCompoent = component.Clone();
            _timeline.AddComponent(newCompoent);

            //if( component.GetType() == typeof(Text))
            //{
            //    Text source = (Text)component;
            //    Text target = new Text(source.Content);
            //    _timeline.AddComponent(target);
            //}
            //else if (component.GetType() == typeof(Audio))
            //{
            //    Audio source = (Audio)component;
            //    Audio target = new Audio();
            //    _timeline.AddComponent(target);
            //}
        }
    }
}
