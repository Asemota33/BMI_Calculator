namespace BMI_Calculator
{
    partial class BMICalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.ImperialRadioButton = new System.Windows.Forms.RadioButton();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.MetricRadioButton = new System.Windows.Forms.RadioButton();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.BMITextbox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.WeightMeasurementLabel = new System.Windows.Forms.Label();
            this.HeightMeasurementLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.20588F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.79412F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Controls.Add(this.WeightTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ImperialRadioButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.WeightLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.MetricRadioButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.HeightTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.HeightLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BMITextbox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.CalculateButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.WeightMeasurementLabel, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.HeightMeasurementLabel, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.9854F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.0146F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(302, 368);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Location = new System.Drawing.Point(144, 194);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(100, 38);
            this.WeightTextBox.TabIndex = 6;
            this.WeightTextBox.TextChanged += new System.EventHandler(this.WeightTextBox_TextChanged);
            // 
            // ImperialRadioButton
            // 
            this.ImperialRadioButton.AutoSize = true;
            this.ImperialRadioButton.Location = new System.Drawing.Point(3, 3);
            this.ImperialRadioButton.Name = "ImperialRadioButton";
            this.ImperialRadioButton.Size = new System.Drawing.Size(128, 35);
            this.ImperialRadioButton.TabIndex = 1;
            this.ImperialRadioButton.TabStop = true;
            this.ImperialRadioButton.Text = "Imperial";
            this.ImperialRadioButton.UseVisualStyleBackColor = true;
            this.ImperialRadioButton.CheckedChanged += new System.EventHandler(this.ImperialRadioButton_CheckedChanged);
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(3, 191);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(113, 62);
            this.WeightLabel.TabIndex = 5;
            this.WeightLabel.Text = "My Weight: ";
            // 
            // MetricRadioButton
            // 
            this.MetricRadioButton.AutoSize = true;
            this.MetricRadioButton.Location = new System.Drawing.Point(144, 3);
            this.MetricRadioButton.Name = "MetricRadioButton";
            this.MetricRadioButton.Size = new System.Drawing.Size(106, 35);
            this.MetricRadioButton.TabIndex = 2;
            this.MetricRadioButton.TabStop = true;
            this.MetricRadioButton.Text = "Metric";
            this.MetricRadioButton.UseVisualStyleBackColor = true;
            this.MetricRadioButton.CheckedChanged += new System.EventHandler(this.MetricRadioButton_CheckedChanged);
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(144, 91);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(100, 38);
            this.HeightTextBox.TabIndex = 3;
            this.HeightTextBox.TextChanged += new System.EventHandler(this.HeightTextBox_TextChanged);
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(3, 88);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(108, 62);
            this.HeightLabel.TabIndex = 4;
            this.HeightLabel.Text = "My Height: ";
            // 
            // BMITextbox
            // 
            this.BMITextbox.Location = new System.Drawing.Point(144, 271);
            this.BMITextbox.Name = "BMITextbox";
            this.BMITextbox.ReadOnly = true;
            this.BMITextbox.Size = new System.Drawing.Size(100, 38);
            this.BMITextbox.TabIndex = 7;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(3, 271);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(135, 72);
            this.CalculateButton.TabIndex = 8;
            this.CalculateButton.Text = "Calculate BMI";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // WeightMeasurementLabel
            // 
            this.WeightMeasurementLabel.AutoSize = true;
            this.WeightMeasurementLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightMeasurementLabel.Location = new System.Drawing.Point(274, 191);
            this.WeightMeasurementLabel.Name = "WeightMeasurementLabel";
            this.WeightMeasurementLabel.Size = new System.Drawing.Size(24, 68);
            this.WeightMeasurementLabel.TabIndex = 9;
            this.WeightMeasurementLabel.Text = "(Pounds)";
            // 
            // HeightMeasurementLabel
            // 
            this.HeightMeasurementLabel.AutoSize = true;
            this.HeightMeasurementLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightMeasurementLabel.Location = new System.Drawing.Point(274, 88);
            this.HeightMeasurementLabel.Name = "HeightMeasurementLabel";
            this.HeightMeasurementLabel.Size = new System.Drawing.Size(24, 68);
            this.HeightMeasurementLabel.TabIndex = 10;
            this.HeightMeasurementLabel.Text = "(Inches)";
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.BMICalc_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.RadioButton ImperialRadioButton;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.RadioButton MetricRadioButton;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.TextBox BMITextbox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label WeightMeasurementLabel;
        private System.Windows.Forms.Label HeightMeasurementLabel;
    }
}

