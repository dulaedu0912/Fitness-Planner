namespace FitnessPlanner
{
    partial class FormWorkoutPlanning
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCurrentPlanTitle = new System.Windows.Forms.Label();
            this.dgvCurrentPlan = new System.Windows.Forms.DataGridView();
            this.lblAddWorkoutTitle = new System.Windows.Forms.Label();
            this.dgvAllWorkouts = new System.Windows.Forms.DataGridView();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.btnAddToPlan = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpPlanDate = new System.Windows.Forms.DateTimePicker();
            this.btnRemoveFromPlan = new System.Windows.Forms.Button();
            this.lblSets = new System.Windows.Forms.Label();
            this.nudSets = new System.Windows.Forms.NumericUpDown();
            this.lblReps = new System.Windows.Forms.Label();
            this.nudReps = new System.Windows.Forms.NumericUpDown();
            this.btnMarkCompleted = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentPlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllWorkouts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReps)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(18, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(280, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🏋️ Workout Planner";
            // 
            // lblCurrentPlanTitle
            // 
            this.lblCurrentPlanTitle.AutoSize = true;
            this.lblCurrentPlanTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCurrentPlanTitle.Location = new System.Drawing.Point(18, 64);
            this.lblCurrentPlanTitle.Name = "lblCurrentPlanTitle";
            this.lblCurrentPlanTitle.Size = new System.Drawing.Size(141, 28);
            this.lblCurrentPlanTitle.TabIndex = 1;
            this.lblCurrentPlanTitle.Text = "Your Plan for:";
            // 
            // dgvCurrentPlan
            // 
            this.dgvCurrentPlan.AllowUserToAddRows = false;
            this.dgvCurrentPlan.AllowUserToDeleteRows = false;
            this.dgvCurrentPlan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCurrentPlan.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvCurrentPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrentPlan.Location = new System.Drawing.Point(22, 96);
            this.dgvCurrentPlan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCurrentPlan.MultiSelect = false;
            this.dgvCurrentPlan.Name = "dgvCurrentPlan";
            this.dgvCurrentPlan.ReadOnly = true;
            this.dgvCurrentPlan.RowHeadersWidth = 51;
            this.dgvCurrentPlan.RowTemplate.Height = 24;
            this.dgvCurrentPlan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCurrentPlan.Size = new System.Drawing.Size(564, 160);
            this.dgvCurrentPlan.TabIndex = 2;
            // 
            // lblAddWorkoutTitle
            // 
            this.lblAddWorkoutTitle.AutoSize = true;
            this.lblAddWorkoutTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblAddWorkoutTitle.Location = new System.Drawing.Point(18, 341);
            this.lblAddWorkoutTitle.Name = "lblAddWorkoutTitle";
            this.lblAddWorkoutTitle.Size = new System.Drawing.Size(269, 28);
            this.lblAddWorkoutTitle.TabIndex = 3;
            this.lblAddWorkoutTitle.Text = "Available Exercises (Select)";
            // 
            // dgvAllWorkouts
            // 
            this.dgvAllWorkouts.AllowUserToAddRows = false;
            this.dgvAllWorkouts.AllowUserToDeleteRows = false;
            this.dgvAllWorkouts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllWorkouts.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvAllWorkouts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllWorkouts.Location = new System.Drawing.Point(22, 373);
            this.dgvAllWorkouts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAllWorkouts.MultiSelect = false;
            this.dgvAllWorkouts.Name = "dgvAllWorkouts";
            this.dgvAllWorkouts.ReadOnly = true;
            this.dgvAllWorkouts.RowHeadersWidth = 51;
            this.dgvAllWorkouts.RowTemplate.Height = 24;
            this.dgvAllWorkouts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllWorkouts.Size = new System.Drawing.Size(564, 160);
            this.dgvAllWorkouts.TabIndex = 4;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(19, 325);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(354, 16);
            this.lblInstructions.TabIndex = 5;
            this.lblInstructions.Text = "Instructions: Select an exercise below, set details, and add.";
            // 
            // btnAddToPlan
            // 
            this.btnAddToPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAddToPlan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddToPlan.ForeColor = System.Drawing.Color.White;
            this.btnAddToPlan.Location = new System.Drawing.Point(592, 373);
            this.btnAddToPlan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddToPlan.Name = "btnAddToPlan";
            this.btnAddToPlan.Size = new System.Drawing.Size(156, 66);
            this.btnAddToPlan.TabIndex = 6;
            this.btnAddToPlan.Text = "➕ Add to Plan";
            this.btnAddToPlan.UseVisualStyleBackColor = false;
            this.btnAddToPlan.Click += new System.EventHandler(this.btnAddToPlan_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblDate.Location = new System.Drawing.Point(421, 69);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(53, 22);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "Date:";
            // 
            // dtpPlanDate
            // 
            this.dtpPlanDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.dtpPlanDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPlanDate.Location = new System.Drawing.Point(480, 69);
            this.dtpPlanDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpPlanDate.Name = "dtpPlanDate";
            this.dtpPlanDate.Size = new System.Drawing.Size(106, 22);
            this.dtpPlanDate.TabIndex = 8;
            this.dtpPlanDate.ValueChanged += new System.EventHandler(this.dtpPlanDate_ValueChanged);
            // 
            // btnRemoveFromPlan
            // 
            this.btnRemoveFromPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnRemoveFromPlan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRemoveFromPlan.ForeColor = System.Drawing.Color.White;
            this.btnRemoveFromPlan.Location = new System.Drawing.Point(592, 96);
            this.btnRemoveFromPlan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveFromPlan.Name = "btnRemoveFromPlan";
            this.btnRemoveFromPlan.Size = new System.Drawing.Size(156, 72);
            this.btnRemoveFromPlan.TabIndex = 9;
            this.btnRemoveFromPlan.Text = "🗑️ Remove Selected";
            this.btnRemoveFromPlan.UseVisualStyleBackColor = false;
            this.btnRemoveFromPlan.Click += new System.EventHandler(this.btnRemoveFromPlan_Click);
            // 
            // lblSets
            // 
            this.lblSets.AutoSize = true;
            this.lblSets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.lblSets.Location = new System.Drawing.Point(612, 501);
            this.lblSets.Name = "lblSets";
            this.lblSets.Size = new System.Drawing.Size(48, 20);
            this.lblSets.TabIndex = 10;
            this.lblSets.Text = "Sets:";
            // 
            // nudSets
            // 
            this.nudSets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.nudSets.Location = new System.Drawing.Point(666, 499);
            this.nudSets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudSets.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSets.Name = "nudSets";
            this.nudSets.Size = new System.Drawing.Size(53, 26);
            this.nudSets.TabIndex = 11;
            this.nudSets.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // lblReps
            // 
            this.lblReps.AutoSize = true;
            this.lblReps.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.lblReps.Location = new System.Drawing.Point(608, 462);
            this.lblReps.Name = "lblReps";
            this.lblReps.Size = new System.Drawing.Size(53, 20);
            this.lblReps.TabIndex = 12;
            this.lblReps.Text = "Reps:";
            // 
            // nudReps
            // 
            this.nudReps.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.nudReps.Location = new System.Drawing.Point(667, 460);
            this.nudReps.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudReps.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudReps.Name = "nudReps";
            this.nudReps.Size = new System.Drawing.Size(53, 26);
            this.nudReps.TabIndex = 13;
            this.nudReps.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnMarkCompleted
            // 
            this.btnMarkCompleted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnMarkCompleted.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnMarkCompleted.ForeColor = System.Drawing.Color.White;
            this.btnMarkCompleted.Location = new System.Drawing.Point(592, 185);
            this.btnMarkCompleted.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMarkCompleted.Name = "btnMarkCompleted";
            this.btnMarkCompleted.Size = new System.Drawing.Size(156, 71);
            this.btnMarkCompleted.TabIndex = 14;
            this.btnMarkCompleted.Text = "✅ Mark As Completed";
            this.btnMarkCompleted.UseVisualStyleBackColor = false;
            this.btnMarkCompleted.Click += new System.EventHandler(this.btnMarkCompleted_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Maroon;
            this.textBox1.Location = new System.Drawing.Point(22, 538);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(564, 47);
            this.textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Maroon;
            this.textBox2.Location = new System.Drawing.Point(22, 261);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(564, 47);
            this.textBox2.TabIndex = 15;
            // 
            // FormWorkoutPlanning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 597);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnMarkCompleted);
            this.Controls.Add(this.nudReps);
            this.Controls.Add(this.lblReps);
            this.Controls.Add(this.nudSets);
            this.Controls.Add(this.lblSets);
            this.Controls.Add(this.btnRemoveFromPlan);
            this.Controls.Add(this.dtpPlanDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnAddToPlan);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.dgvAllWorkouts);
            this.Controls.Add(this.lblAddWorkoutTitle);
            this.Controls.Add(this.dgvCurrentPlan);
            this.Controls.Add(this.lblCurrentPlanTitle);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormWorkoutPlanning";
            this.Text = "Workout Planner";
            this.Load += new System.EventHandler(this.FormWorkoutPlanning_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentPlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllWorkouts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCurrentPlanTitle;
        private System.Windows.Forms.DataGridView dgvCurrentPlan;
        private System.Windows.Forms.Label lblAddWorkoutTitle;
        private System.Windows.Forms.DataGridView dgvAllWorkouts;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Button btnAddToPlan;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpPlanDate;
        private System.Windows.Forms.Button btnRemoveFromPlan;
        private System.Windows.Forms.Label lblSets;
        private System.Windows.Forms.NumericUpDown nudSets;
        private System.Windows.Forms.Label lblReps;
        private System.Windows.Forms.NumericUpDown nudReps;
        private System.Windows.Forms.Button btnMarkCompleted; // NEW
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}