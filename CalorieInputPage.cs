﻿using System;
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
        public CalorieInputPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CalorieInputPage_Load(object sender, EventArgs e)
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
