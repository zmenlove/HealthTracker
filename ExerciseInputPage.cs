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
    public partial class ExerciseInputPage : Form
    {
        public ExerciseInputPage()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void exerciseDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void exerciseType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void exerciseMins_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExerciseInputPage_Load(object sender, EventArgs e)
        {

        }

        private void calorieReturnToMenu_Click(object sender, EventArgs e)
        {
            HealthApp healthApp = new HealthApp();
            healthApp.Show();
            this.Hide();
        }
    }
}
