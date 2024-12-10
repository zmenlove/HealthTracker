//Zachary Menlove
//CIS262
//Health Tracker Windows Form Application
//12-9-2024
//This class is a helper that manages all the options in the in the exercise form combo list and then calculates calories burned

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthTracker
{
    internal class ExerciseHelper
    {
        //dictionary list that has the data for the exercise combo list and the corresponding MET calculation number
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

        //calculates the amount of calories burned by taking the exercise type, entered weight of the user, and the minutes exercised
        //converts pounds to Kg and then time to hours to return the calories burned (kilograms * MET * hours)
        public double CalculateCaloriesBurned(string exercise, double weightLbs, double minutes)
        {
            //convert pounds to kgs for standardization
            double weightKg = weightLbs / 2.20462;
    
            double met = metValues[exercise];

            double timeHours = minutes / 60.0;

            return met * weightKg * timeHours;
        }
        
        //attaches list to combo list
        public List<string> GetSupportedExercises()
        {
            return new List<string>(metValues.Keys);
        }
    }
}
