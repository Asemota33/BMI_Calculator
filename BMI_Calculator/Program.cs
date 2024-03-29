﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Author: Michael Asemota
 * Student ID: 301052117
 * Date: 7/21/2019
 * Program: Comp123
 * 
 */
namespace BMI_Calculator
{
    static class Program
    {
        public static Dictionary<FormName, Form> Forms;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Forms = new Dictionary<FormName, Form>();
            Forms.Add(FormName.SPLASH_FORM, new Splash());
            Forms.Add(FormName.BMI_FORM, new BMICalculator());
            Application.Run(Forms[FormName.SPLASH_FORM]);
        }
    }
}
