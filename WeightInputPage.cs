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
    public partial class WeightInputPage : Form
    {
        private readonly ExcelManage excelManage;
        public WeightInputPage()
        {
            InitializeComponent();

            excelManage = new ExcelManage();
        }

        private void weightDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void currentWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void weightReturnToMenu_Click(object sender, EventArgs e)
        {
            HealthApp healthApp = new HealthApp();
            healthApp.Show();
            this.Hide();
        }

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
