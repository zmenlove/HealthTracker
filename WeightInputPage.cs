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
        public WeightInputPage()
        {
            InitializeComponent();
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
    }
}
