using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge
{
    public class SamsungDevice : Device
    {
        public void SetChannlel(int channel)
        {
            Console.WriteLine("Samsung: Setting Channel " + channel);
        }

        public void TurnOff()
        {
            Console.WriteLine("Samsung: Turn Off");
        }

        public void TurnOn()
        {
            Console.WriteLine("Samsung: Turn On");
        }
    }
}
