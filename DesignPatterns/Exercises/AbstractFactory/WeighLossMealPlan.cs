using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.AbstractFactory
{
    public class WeighLossMealPlan : IMealPlan
    {
        public IMealPlan CreateMealPlan()
        {
            throw new NotImplementedException();
        }

        public IWorkoutPlan CreateWorkoutPlan()
        {
            throw new NotImplementedException();
        }
    }
}
