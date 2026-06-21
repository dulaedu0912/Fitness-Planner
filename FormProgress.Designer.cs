namespace FitnessPlanner
{
    partial class FormProgress
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblTitle = new System.Windows.Forms.Label();
            this.chartWeight = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartCaloriesOut = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlBmiCalculator = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblBmiStatusValue = new System.Windows.Forms.Label();
            this.lblBmiValue = new System.Windows.Forms.Label();
            this.lblBmiStatus = new System.Windows.Forms.Label();
            this.lblBmiResult = new System.Windows.Forms.Label();
            this.btnCalculateBmi = new System.Windows.Forms.Button();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWeightBMI = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWeightBMI = new System.Windows.Forms.Label();
            this.lblBmiTitle = new System.Windows.Forms.Label();
            this.pnlLogging = new System.Windows.Forms.Panel();
            this.lblLogTitle = new System.Windows.Forms.Label();
            this.btnLogCaloriesOut = new System.Windows.Forms.Button();
            this.nudCaloriesOut = new System.Windows.Forms.NumericUpDown();
            this.lblCaloriesOut = new System.Windows.Forms.Label();
            this.btnLogWeight = new System.Windows.Forms.Button();
            this.nudWeight = new System.Windows.Forms.NumericUpDown();
            this.lblWeight = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCaloriesOut)).BeginInit();
            this.pnlBmiCalculator.SuspendLayout();
            this.pnlLogging.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCaloriesOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(56, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(275, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Progress Tracker 📊";
            // 
            // chartWeight
            // 
            chartArea1.Name = "ChartArea1";
            this.chartWeight.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartWeight.Legends.Add(legend1);
            this.chartWeight.Location = new System.Drawing.Point(42, 85);
            this.chartWeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartWeight.Name = "chartWeight";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Weight";
            this.chartWeight.Series.Add(series1);
            this.chartWeight.Size = new System.Drawing.Size(409, 360);
            this.chartWeight.TabIndex = 1;
            this.chartWeight.Text = "Weight Chart";
            // 
            // chartCaloriesOut
            // 
            chartArea2.Name = "ChartArea1";
            this.chartCaloriesOut.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartCaloriesOut.Legends.Add(legend2);
            this.chartCaloriesOut.Location = new System.Drawing.Point(530, 85);
            this.chartCaloriesOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartCaloriesOut.Name = "chartCaloriesOut";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "CaloriesOut";
            this.chartCaloriesOut.Series.Add(series2);
            this.chartCaloriesOut.Size = new System.Drawing.Size(409, 360);
            this.chartCaloriesOut.TabIndex = 2;
            this.chartCaloriesOut.Text = "Calories Out Chart";
            // 
            // pnlBmiCalculator
            // 
            this.pnlBmiCalculator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBmiCalculator.Controls.Add(this.textBox1);
            this.pnlBmiCalculator.Controls.Add(this.lblBmiStatusValue);
            this.pnlBmiCalculator.Controls.Add(this.lblBmiValue);
            this.pnlBmiCalculator.Controls.Add(this.lblBmiStatus);
            this.pnlBmiCalculator.Controls.Add(this.lblBmiResult);
            this.pnlBmiCalculator.Controls.Add(this.btnCalculateBmi);
            this.pnlBmiCalculator.Controls.Add(this.txtHeight);
            this.pnlBmiCalculator.Controls.Add(this.txtWeightBMI);
            this.pnlBmiCalculator.Controls.Add(this.lblHeight);
            this.pnlBmiCalculator.Controls.Add(this.lblWeightBMI);
            this.pnlBmiCalculator.Controls.Add(this.lblBmiTitle);
            this.pnlBmiCalculator.Location = new System.Drawing.Point(530, 485);
            this.pnlBmiCalculator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlBmiCalculator.Name = "pnlBmiCalculator";
            this.pnlBmiCalculator.Size = new System.Drawing.Size(409, 184);
            this.pnlBmiCalculator.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(14, 99);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(377, 46);
            this.textBox1.TabIndex = 5;
            // 
            // lblBmiStatusValue
            // 
            this.lblBmiStatusValue.AutoSize = true;
            this.lblBmiStatusValue.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBmiStatusValue.Location = new System.Drawing.Point(241, 148);
            this.lblBmiStatusValue.Name = "lblBmiStatusValue";
            this.lblBmiStatusValue.Size = new System.Drawing.Size(43, 23);
            this.lblBmiStatusValue.TabIndex = 9;
            this.lblBmiStatusValue.Text = "N/A";
            // 
            // lblBmiValue
            // 
            this.lblBmiValue.AutoSize = true;
            this.lblBmiValue.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBmiValue.Location = new System.Drawing.Point(106, 148);
            this.lblBmiValue.Name = "lblBmiValue";
            this.lblBmiValue.Size = new System.Drawing.Size(45, 23);
            this.lblBmiValue.TabIndex = 8;
            this.lblBmiValue.Text = "0.00";
            // 
            // lblBmiStatus
            // 
            this.lblBmiStatus.AutoSize = true;
            this.lblBmiStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBmiStatus.Location = new System.Drawing.Point(181, 148);
            this.lblBmiStatus.Name = "lblBmiStatus";
            this.lblBmiStatus.Size = new System.Drawing.Size(52, 20);
            this.lblBmiStatus.TabIndex = 7;
            this.lblBmiStatus.Text = "Status:";
            // 
            // lblBmiResult
            // 
            this.lblBmiResult.AutoSize = true;
            this.lblBmiResult.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBmiResult.Location = new System.Drawing.Point(12, 148);
            this.lblBmiResult.Name = "lblBmiResult";
            this.lblBmiResult.Size = new System.Drawing.Size(78, 20);
            this.lblBmiResult.TabIndex = 6;
            this.lblBmiResult.Text = "BMI Value:";
            // 
            // btnCalculateBmi
            // 
            this.btnCalculateBmi.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCalculateBmi.ForeColor = System.Drawing.Color.White;
            this.btnCalculateBmi.Location = new System.Drawing.Point(258, 45);
            this.btnCalculateBmi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalculateBmi.Name = "btnCalculateBmi";
            this.btnCalculateBmi.Size = new System.Drawing.Size(133, 48);
            this.btnCalculateBmi.TabIndex = 5;
            this.btnCalculateBmi.Text = "Calculate BMI";
            this.btnCalculateBmi.UseVisualStyleBackColor = false;
            this.btnCalculateBmi.Click += new System.EventHandler(this.btnCalculateBmi_Click);
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(133, 69);
            this.txtHeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(107, 22);
            this.txtHeight.TabIndex = 4;
            this.txtHeight.Text = "1.75";
            // 
            // txtWeightBMI
            // 
            this.txtWeightBMI.Location = new System.Drawing.Point(133, 45);
            this.txtWeightBMI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWeightBMI.Name = "txtWeightBMI";
            this.txtWeightBMI.Size = new System.Drawing.Size(107, 22);
            this.txtWeightBMI.TabIndex = 3;
            this.txtWeightBMI.Text = "75.0";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(13, 73);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(71, 16);
            this.lblHeight.TabIndex = 2;
            this.lblHeight.Text = "Height (m):";
            // 
            // lblWeightBMI
            // 
            this.lblWeightBMI.AutoSize = true;
            this.lblWeightBMI.Location = new System.Drawing.Point(13, 49);
            this.lblWeightBMI.Name = "lblWeightBMI";
            this.lblWeightBMI.Size = new System.Drawing.Size(78, 16);
            this.lblWeightBMI.TabIndex = 1;
            this.lblWeightBMI.Text = "Weight (kg):";
            // 
            // lblBmiTitle
            // 
            this.lblBmiTitle.AutoSize = true;
            this.lblBmiTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBmiTitle.Location = new System.Drawing.Point(9, 8);
            this.lblBmiTitle.Name = "lblBmiTitle";
            this.lblBmiTitle.Size = new System.Drawing.Size(186, 28);
            this.lblBmiTitle.TabIndex = 0;
            this.lblBmiTitle.Text = "BMI Calculator 📏";
            // 
            // pnlLogging
            // 
            this.pnlLogging.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLogging.Controls.Add(this.lblLogTitle);
            this.pnlLogging.Controls.Add(this.btnLogCaloriesOut);
            this.pnlLogging.Controls.Add(this.nudCaloriesOut);
            this.pnlLogging.Controls.Add(this.lblCaloriesOut);
            this.pnlLogging.Controls.Add(this.btnLogWeight);
            this.pnlLogging.Controls.Add(this.nudWeight);
            this.pnlLogging.Controls.Add(this.lblWeight);
            this.pnlLogging.Location = new System.Drawing.Point(42, 485);
            this.pnlLogging.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlLogging.Name = "pnlLogging";
            this.pnlLogging.Size = new System.Drawing.Size(409, 184);
            this.pnlLogging.TabIndex = 4;
            // 
            // lblLogTitle
            // 
            this.lblLogTitle.AutoSize = true;
            this.lblLogTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogTitle.Location = new System.Drawing.Point(9, 8);
            this.lblLogTitle.Name = "lblLogTitle";
            this.lblLogTitle.Size = new System.Drawing.Size(180, 28);
            this.lblLogTitle.TabIndex = 6;
            this.lblLogTitle.Text = "Log New Data ✍️";
            // 
            // btnLogCaloriesOut
            // 
            this.btnLogCaloriesOut.Location = new System.Drawing.Point(267, 112);
            this.btnLogCaloriesOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogCaloriesOut.Name = "btnLogCaloriesOut";
            this.btnLogCaloriesOut.Size = new System.Drawing.Size(116, 24);
            this.btnLogCaloriesOut.TabIndex = 5;
            this.btnLogCaloriesOut.Text = "Log Burned";
            this.btnLogCaloriesOut.UseVisualStyleBackColor = true;
            this.btnLogCaloriesOut.Click += new System.EventHandler(this.btnLogCaloriesOut_Click);
            // 
            // nudCaloriesOut
            // 
            this.nudCaloriesOut.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudCaloriesOut.Location = new System.Drawing.Point(142, 114);
            this.nudCaloriesOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudCaloriesOut.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudCaloriesOut.Name = "nudCaloriesOut";
            this.nudCaloriesOut.Size = new System.Drawing.Size(107, 22);
            this.nudCaloriesOut.TabIndex = 4;
            this.nudCaloriesOut.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // lblCaloriesOut
            // 
            this.lblCaloriesOut.AutoSize = true;
            this.lblCaloriesOut.Location = new System.Drawing.Point(13, 116);
            this.lblCaloriesOut.Name = "lblCaloriesOut";
            this.lblCaloriesOut.Size = new System.Drawing.Size(119, 16);
            this.lblCaloriesOut.TabIndex = 3;
            this.lblCaloriesOut.Text = "Calories Out (kcal):";
            // 
            // btnLogWeight
            // 
            this.btnLogWeight.Location = new System.Drawing.Point(267, 56);
            this.btnLogWeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogWeight.Name = "btnLogWeight";
            this.btnLogWeight.Size = new System.Drawing.Size(116, 24);
            this.btnLogWeight.TabIndex = 2;
            this.btnLogWeight.Text = "Log Weight";
            this.btnLogWeight.UseVisualStyleBackColor = true;
            this.btnLogWeight.Click += new System.EventHandler(this.btnLogWeight_Click);
            // 
            // nudWeight
            // 
            this.nudWeight.DecimalPlaces = 1;
            this.nudWeight.Location = new System.Drawing.Point(142, 58);
            this.nudWeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudWeight.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudWeight.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudWeight.Name = "nudWeight";
            this.nudWeight.Size = new System.Drawing.Size(107, 22);
            this.nudWeight.TabIndex = 1;
            this.nudWeight.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(13, 60);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(78, 16);
            this.lblWeight.TabIndex = 0;
            this.lblWeight.Text = "Weight (kg):";
            // 
            // FormProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 729);
            this.Controls.Add(this.pnlLogging);
            this.Controls.Add(this.pnlBmiCalculator);
            this.Controls.Add(this.chartCaloriesOut);
            this.Controls.Add(this.chartWeight);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormProgress";
            this.Text = "User Progress and Charts";
            this.Load += new System.EventHandler(this.FormProgress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCaloriesOut)).EndInit();
            this.pnlBmiCalculator.ResumeLayout(false);
            this.pnlBmiCalculator.PerformLayout();
            this.pnlLogging.ResumeLayout(false);
            this.pnlLogging.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCaloriesOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // Chart Controls
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartWeight;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCaloriesOut;

        // BMI Calculator Controls
        private System.Windows.Forms.Panel pnlBmiCalculator;
        private System.Windows.Forms.Label lblBmiTitle;
        private System.Windows.Forms.Button btnCalculateBmi;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWeightBMI;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWeightBMI;
        private System.Windows.Forms.Label lblBmiStatusValue;
        private System.Windows.Forms.Label lblBmiValue;
        private System.Windows.Forms.Label lblBmiStatus;
        private System.Windows.Forms.Label lblBmiResult;

        // Logging Controls (Simplified)
        private System.Windows.Forms.Panel pnlLogging;
        private System.Windows.Forms.Label lblLogTitle;
        private System.Windows.Forms.Button btnLogCaloriesOut;
        private System.Windows.Forms.NumericUpDown nudCaloriesOut;
        private System.Windows.Forms.Label lblCaloriesOut;
        private System.Windows.Forms.Button btnLogWeight;
        private System.Windows.Forms.NumericUpDown nudWeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox textBox1;
    }
}