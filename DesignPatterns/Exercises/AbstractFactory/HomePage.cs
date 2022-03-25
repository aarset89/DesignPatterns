using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.AbstractFactory
{
    public class HomePage
    {
        private IWorkoutPlan workoutPlan;
        private IMealPlan mealPlan;

        //public void SetGoal(Goal goal)
        //{
        //    if(goal == Goal.BUILD_MUSCLE)
        //    {
        //        workoutPlan = new BuildMuscleWorkout();
        //        mealPlan = new BuildMuscleMealPlan();
        //    }

        //    Console.WriteLine(workoutPlan);
        //    Console.WriteLine(mealPlan);
        //}

        public void SetGoal(IGoal goal)
        {
            var meal = goal.CreateMealPlan();
            var workout = goal.CreateWorkoutPlan();

            Console.WriteLine(meal);
            Console.WriteLine(workout);
        }

    }
}
