using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge
{
    public class BasicControl
    {
        private Device _device;
        public BasicControl(Device device)
        {
            _device = device;
        }

        public void TurnOn()
        {
            _device.TurnOn();
        }
        public void TurnOff()
        {
            _device.TurnOff();
        }
    }
}
