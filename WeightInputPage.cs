//Zachary Menlove
//CIS262
//Health Tracker Windows Form Application
//12-9-2024

using OfficeOpenXml;
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
    //initializes excelmanage helper to store entered data to excel file
    public partial class WeightInputPage : Form
    {
        private readonly ExcelManage excelManage;
        public WeightInputPage()
        {
            InitializeComponent();

            excelManage = new ExcelManage();
        }

        //button to return user to main page
        private void weightReturnToMenu_Click(object sender, EventArgs e)
        {
            HealthApp healthApp = new HealthApp();
            healthApp.Show();
            this.Hide();
        }

        //method that takes the date entered and the weight entered (ensuring that weight is a number above zero). If not advises user.
        private void button1_Click(object sender, EventArgs e)
        {
            double weightEntered;
            DateTime selectedDateTime = weightDateTime.Value;

            if (!double.TryParse(weightTextBox.Text, out weightEntered) || weightEntered <= 0)
            {
                MessageBox.Show("Please enter a valid weight in pounds", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //send data to excel
            string[] data =
            {
                selectedDateTime.ToString("yyyy-MM-dd"),
                weightEntered.ToString()
            };
            excelManage.AddToSheet("Weight", data);

            //display weight entered
            MessageBox.Show($"You weigh {weightEntered} pounds.",
                "Current Weight", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //return to main page
            HealthApp healthApp = new HealthApp();
            healthApp.Show();
            this.Close();
        }
    }
}
