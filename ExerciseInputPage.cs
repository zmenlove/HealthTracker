﻿//Zachary Menlove
//CIS262
//Health Tracker Windows Form Application
//12-9-2024

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace HealthTracker
{
    public partial class ExerciseInputPage : Form
    {
        //intitializes the exercise and excel helpers to provide the calculations for the exercise and file management for excel
        private readonly ExerciseHelper exerciseHelper;
        private readonly ExcelManage excelManage;
        public ExerciseInputPage()
        {
            InitializeComponent();

            exerciseHelper = new ExerciseHelper();
            excelManage = new ExcelManage();

            exerciseType.DataSource = exerciseHelper.GetSupportedExercises();
        }
        
        //returns user to menu
        private void calorieReturnToMenu_Click(object sender, EventArgs e)
        {
            HealthApp healthApp = new HealthApp();
            healthApp.Show();
            this.Hide();
        }

        //save button method that takes inputted information and saves it to the excel file
        private void exerciseSaveBtn_Click(object sender, EventArgs e)
        {
            string selectedExercise = exerciseType.SelectedItem.ToString();
            double durationMinutes;
            double weightLbs;
            DateTime selectedDateTime = exerciseDateTime.Value;
            
            //if a number more than 0 convert to durationMinutes, otherwise provide message to user stating to re-enter with correct input
            if (!double.TryParse(exerciseMins.Text, out durationMinutes) || durationMinutes <= 0)
            {
                MessageBox.Show("Please enter a valid duration in minutes.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //if a number more than 0 convert to weightLbs, otherwise provide message to user stating to re-enter with correct input
            if (!double.TryParse(exerciseWeight.Text, out weightLbs) || weightLbs <= 0)
            {
                MessageBox.Show("Please enter a valid weight in pounds.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //calculate calories burned based on user input
            double caloriesBurned = exerciseHelper.CalculateCaloriesBurned(selectedExercise, weightLbs, durationMinutes);

            //send data to excel
            string[] data = 
            { 
                selectedDateTime.ToString("yyyy-MM-dd"),
                selectedExercise,
                durationMinutes.ToString(),
                caloriesBurned.ToString("F2") 
            };
            excelManage.AddToSheet("Exercise", data);

            //display calories burned and return to main page
            MessageBox.Show($"You burned {caloriesBurned:F2} calories doing {selectedExercise} for {durationMinutes} minutes.",
                "Calories Burned", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //return to main page
            HealthApp healthApp = new HealthApp();
            healthApp.Show();
            this.Close();
        }
    }
}
