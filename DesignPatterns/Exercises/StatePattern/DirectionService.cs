using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.StatePattern
{
    public class DirectionService
    {
        private TravelMode _travelMode;

        public DirectionService(TravelMode travelMode)
        {
            _travelMode = travelMode;
        }

        public void GetEta()
        {
            _travelMode.GetEta();
        }

        public void GetDirection()
        {
            _travelMode.GetDirection();
            
        }

        public TravelMode GetTravelMode()
        {
            return _travelMode;
        }

        public void setTravelMode(TravelMode travelMode)
        {
            this._travelMode = travelMode;
        }
    }
}
