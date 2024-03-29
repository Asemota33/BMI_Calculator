﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            SplashTimer.Enabled = false;
            Program.Forms[FormName.BMI_FORM].Show();
            this.Hide();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            SplashTimer.Enabled = true;
        }
    }
}
