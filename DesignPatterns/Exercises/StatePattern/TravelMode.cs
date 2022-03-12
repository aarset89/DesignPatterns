using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.StatePattern
{
    public interface TravelMode
    {
        void GetEta();
        void GetDirection();
    }
}
