﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.AbstractFactory
{
    public class WeightLossWorkout : IWorkoutPlan
    {
        public void SetGoal()
        {
            Console.WriteLine("WeightLossWorkout");
        }
    }
}
