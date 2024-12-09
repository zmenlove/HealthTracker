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
    public partial class HealthApp : Form
    {
        private ExcelManage excelManage;
        public HealthApp()
        {
            InitializeComponent();
            excelManage = new ExcelManage();
        }

        private void caloriesGoTo_Click(object sender, EventArgs e)
        {
            CalorieInputPage calorieInputPage = new CalorieInputPage();
            calorieInputPage.Show();
            this.Hide();
        }

        private void exerciseGoTo_Click(object sender, EventArgs e)
        {
            ExerciseInputPage exerciseInputPage = new ExerciseInputPage();
            exerciseInputPage.Show();
            this.Hide();
        }

        private void weightGoTo_Click(object sender, EventArgs e)
        {
            WeightInputPage weightInputPage = new WeightInputPage();
            weightInputPage.Show();
            this.Hide();
        }

        private void resultsGoTo_Click(object sender, EventArgs e)
        {
            try { excelManage.OpenExcelFile(); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error: Couldn't open file", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        
    }
}
