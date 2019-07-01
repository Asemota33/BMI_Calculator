using System;
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
            WeightMeasurementLabel.Text = "(Killograms)";
            HeightMeasurementLabel.Text = "(Metres)";
        }
        /// <summary>
        /// Event listner for imperial radio button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImperialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            WeightMeasurementLabel.Text = "(Pounds)";
            HeightMeasurementLabel.Text = "(Inches)";
        }
        /// <summary>
        /// Event listner to check if the height text box has a float value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HeightTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
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
        /// Event listner to check if the weight text box has a float value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WeightTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float.Parse(WeightTextBox.Text);
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
