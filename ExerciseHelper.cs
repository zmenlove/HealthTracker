using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthTracker
{
    internal class ExerciseHelper
    {
        private readonly Dictionary<string, double> metValues = new Dictionary<string, double>
        {
            {"Running", 9.8 },
            { "Walking", 3.8 },
            { "Cycling", 8.0 },
            { "Swimming", 7.0 },
            { "Jumping Rope", 11.0 },
            { "Strength Training", 5.0 },
            { "Yoga", 3.2 },
            { "Hiking", 7.4 }
        };

        public double CalculateCaloriesBurned(string exercise, double weightLbs, double minutes)
        {
            //convert pounds to kgs for standardization
            double weightKg = weightLbs / 2.20462;
    
            double met = metValues[exercise];

            double timeHours = minutes / 60.0;

            return met * weightKg * timeHours;
        }
        public List<string> GetSupportedExercises()
        {
            return new List<string>(metValues.Keys);
        }
    }
}
