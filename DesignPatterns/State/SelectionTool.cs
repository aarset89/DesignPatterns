using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    public class SelectionTool : Tool
    {
        public void MouseDown()
        {
            Console.WriteLine("Selection Tool");
        }

        public void MouseUp()
        {
            Console.WriteLine("Draw a dashed rectangle");
        }
    }
}
