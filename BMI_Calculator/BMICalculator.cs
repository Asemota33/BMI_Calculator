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
 * Date: 7/17/2019
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
            HighlightBMIScale();
            ClearForm();
        }
        /// <summary>
        /// Highlights the textbox and shows there bmi information
        /// </summary>
        private void HighlightBMIScale()
        {
            var bmiValue = BMITextbox.Text;
            var bmiOutput = double.Parse(BMITextbox.Text);
            if (bmiOutput <= 18.5)
            {
                BMIScaleMultiLineTextBox.BackColor = Color.LightBlue;
                BMIScaleMultiLineTextBox.Text = "Your Are Currently Under Weight";

            }
            else if (bmiOutput > 18.5 && bmiOutput <= 24.9)
            {
                BMIScaleMultiLineTextBox.BackColor = Color.GreenYellow;
                BMIScaleMultiLineTextBox.Text = "Your Are Of Normal Weight";

            }
            else if (bmiOutput > 24.9 && bmiOutput <= 29.9)
            {
                BMIScaleMultiLineTextBox.BackColor = Color.Pink;
                BMIScaleMultiLineTextBox.Text = "Your Are Currently OverWeight";

            }
            else if (bmiOutput >= 30)
            {
                BMIScaleMultiLineTextBox.BackColor = Color.Red;
                BMIScaleMultiLineTextBox.Text = "Your Are Currently Obese";
            }
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
            HeightMeasurementLabel.Text = "Inch";
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
        /// <summary>
        /// This method sets the background color to white and clears all textboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearButton_Click(object sender, EventArgs e)
        {
            HeightTextBox.Clear();
            WeightTextBox.Clear();
            BMITextbox.Clear();
            BMIScaleMultiLineTextBox.Clear();
            BMIScaleMultiLineTextBox.BackColor = Color.White;
        }
    }
}
