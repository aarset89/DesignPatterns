using DesignPatterns.AbstractFactory.Ant;
using DesignPatterns.AbstractFactory.Material;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.App
{
    public class ContactForm
    {
        public void Render(IWidget widget)
        {
            widget.Render();
            //if(designEnum == Theme.MATERIAL)
            //{
            //    new MaterialButton().Render();
            //    new MaterialTextBox().Render();
            //}
            //else if(designEnum == Theme.ANT)
            //{
            //    new AntButton().Render();
            //    new AntTextBox().Render();
            //}
        }
    }
}
