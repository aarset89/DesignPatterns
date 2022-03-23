using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge
{
    public class SonyDevice : Device
    {
        public void SetChannlel(int channel)
        {
            Console.WriteLine("Sony: Setting Channel " + channel);
        }

        public void TurnOff()
        {
            Console.WriteLine("Sony: Turn Off");
        }

        public void TurnOn()
        {
            Console.WriteLine("Sony: Turn On");
        }
    }
}
