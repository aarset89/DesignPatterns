using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    public class Canvas
    {
        private Tool Tool;
        
        public void MouseDown()
        {
            Tool.MouseDown();
        }
        public void MouseUp()
        {
            Tool.MouseUp();
        }

        public Tool GetCurrentTool()
        {
            return Tool;
        }

        public void SetCurrentTool(Tool tool)
        {
            Tool = tool;
        }
    }
}
