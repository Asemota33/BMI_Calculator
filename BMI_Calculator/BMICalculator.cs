using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Author: Michael Asemota
 * Student ID: 301052117
 * Date: 7/1/2019
 * Program: Comp123
 * 
 */
namespace BMI_Calculator
{
    public partial class BMICalculator : Form
    {
        public float UserWeight { get; set; }
        public float UserHeight { get; set; } 
        public float BMI { get; set; }
        public BMICalculator()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the event handler for the calculate button, determines which button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            UserWeight = float.Parse(WeightTextBox.Text);
            UserHeight = float.Parse(HeightTextBox.Text);
            if (ImperialRadioButton.Checked == true)
            {
                BMI = (UserWeight * 703) / (UserHeight * UserHeight);
                BMITextbox.Text = BMI.ToString();
            }
            else
            {
                BMI = UserWeight / (UserHeight * UserHeight);
                BMITextbox.Text = BMI.ToString();
            }
            ClearForm();
        }
        /// <summary>
        /// Method for clearing the textboxes in the form
        /// </summary>
        private void ClearForm()
        {
            WeightTextBox.Clear();
            HeightTextBox.Clear();
            //BMITextbox.Clear();
            CalculateButton.Enabled = false;
        }
        /// <summary>
        /// On the load event clear the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BMICalc_Load(object sender, EventArgs e)
        {
            ClearForm();
        }
        /// <summary>
        /// Event listner for metric radio button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MetricRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            WeightMeasurementLabel.Text = "Kgs";
            HeightMeasurementLabel.Text = "M";
        }
        /// <summary>
        /// Event listner for imperial radio button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImperialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            WeightMeasurementLabel.Text = "Lbs";
            HeightMeasurementLabel.Text = "Inches";
        }
        /// <summary>
        /// Event listner to check if the weight or height text box has a float value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxChanged(object sender, EventArgs e)
        {
            try
            {
                float.Parse(WeightTextBox.Text);
                float.Parse(HeightTextBox.Text);
                CalculateButton.Enabled = true;
                BMITextbox.Clear();
            }
            catch
            {
                CalculateButton.Enabled = false;
            }
        }
    }
}
