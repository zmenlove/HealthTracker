//Zachary Menlove
//CIS262
//Health Tracker Windows Form Application
//12-9-2024

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthTracker
{
    //initializes excelManage helper to open excel file if requested.
    public partial class HealthApp : Form
    {
        private ExcelManage excelManage;
        public HealthApp()
        {
            InitializeComponent();
            excelManage = new ExcelManage();
        }

        //opens calorie page and closes main page
        private void caloriesGoTo_Click(object sender, EventArgs e)
        {
            CalorieInputPage calorieInputPage = new CalorieInputPage();
            calorieInputPage.Show();
            this.Hide();
        }

        //opens exercise page and closes main page
        private void exerciseGoTo_Click(object sender, EventArgs e)
        {
            ExerciseInputPage exerciseInputPage = new ExerciseInputPage();
            exerciseInputPage.Show();
            this.Hide();
        }

        //opens weight page and closes main page
        private void weightGoTo_Click(object sender, EventArgs e)
        {
            WeightInputPage weightInputPage = new WeightInputPage();
            weightInputPage.Show();
            this.Hide();
        }
        
        //opens excel file and closes application
        private void resultsGoTo_Click(object sender, EventArgs e)
        {
            try { excelManage.OpenExcelFile(); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error: Couldn't open file", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            Application.Exit(); //application closed to prevent errors with entering data while excel file is open
        }
        
    }
}
