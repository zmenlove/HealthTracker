//Zachary Menlove
//CIS262
//Health Tracker Windows Form Project

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthTracker
{
    
    public partial class CalorieInputPage : Form
    {
        private readonly ExcelManage excelManage;
        public CalorieInputPage()
        {
            InitializeComponent();

            excelManage = new ExcelManage();
        }


        private void calorieReturnToMenu_Click(object sender, EventArgs e)
        {
            HealthApp healthApp = new HealthApp();
            healthApp.Show();
            this.Hide();
        }

        private void calorieSaveBtn_Click(object sender, EventArgs e)
        {
            double caloriesEntered;
            DateTime selectedDateTime = calorieDateTime.Value;

            if (!double.TryParse(caloriesTextBox.Text, out caloriesEntered) || caloriesEntered <= 0)
            {
                MessageBox.Show("Please enter a valid amount of calories", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //send data to excel
            string[] data =
            {
                selectedDateTime.ToString("yyyy-MM-dd"),
                caloriesEntered.ToString()
            };
            excelManage.AddToSheet("Calories", data);

            //display calories burned and return to main page
            MessageBox.Show($"You consumed {caloriesEntered} calories.",
                "Calories Consumed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //return to main page
            HealthApp healthApp = new HealthApp();
            healthApp.Show();
            this.Close();
        }
    }
}
