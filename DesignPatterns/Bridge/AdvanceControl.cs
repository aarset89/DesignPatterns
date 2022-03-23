using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge
{
    public class AdvanceControl: BasicControl
    {
        private Device _device;

        public AdvanceControl(Device device):base(device)
        {
            _device = device;
        }

        public void SetChannel(int channel)
        {
            _device.SetChannlel(channel);
        }
    }
}
