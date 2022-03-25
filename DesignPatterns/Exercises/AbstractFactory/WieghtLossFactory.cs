using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.AbstractFactory
{
    public class WieghtLossFactory : IGoal
    {
        public IMealPlan CreateMealPlan()
        {
            return new WeighLossMealPlan();
        }

        public IWorkoutPlan CreateWorkoutPlan()
        {
            return new WeightLossWorkout();
        }
    }
}
