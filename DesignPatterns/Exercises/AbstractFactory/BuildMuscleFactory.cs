using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.AbstractFactory
{
    public class BuildMuscleFactory : IGoal
    {
        public IMealPlan CreateMealPlan()
        {
            return new BuildMuscleMealPlan();
        }

        public IWorkoutPlan CreateWorkoutPlan()
        {
            return new BuildMuscleWorkout();
        }
    }
}
