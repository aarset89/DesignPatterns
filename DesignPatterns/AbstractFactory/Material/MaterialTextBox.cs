using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.Material
{
    public class MaterialTextBox : ITextBox
    {
        public void Render()
        {
            Console.WriteLine("Material TextBox");
        }
    }
}
