namespace FitnessPlanner
{
    partial class FormMealPlanning
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
            this.lblAvailableMeals = new System.Windows.Forms.Label();
            this.dgvAvailableMeals = new System.Windows.Forms.DataGridView();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblMealType = new System.Windows.Forms.Label();
            this.cmbMealType = new System.Windows.Forms.ComboBox();
            this.btnAddToPlan = new System.Windows.Forms.Button();
            this.lblUserPlan = new System.Windows.Forms.Label();
            this.dgvUserPlan = new System.Windows.Forms.DataGridView();
            this.lblTotalCalories = new System.Windows.Forms.Label();
            this.btnRemoveFromPlan = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableMeals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserPlan)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lblTitle.Location = new System.Drawing.Point(15, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(288, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🍽️ Meal Planner";
            // 
            // lblAvailableMeals
            // 
            this.lblAvailableMeals.AutoSize = true;
            this.lblAvailableMeals.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblAvailableMeals.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblAvailableMeals.Location = new System.Drawing.Point(18, 60);
            this.lblAvailableMeals.Name = "lblAvailableMeals";
            this.lblAvailableMeals.Size = new System.Drawing.Size(153, 28);
            this.lblAvailableMeals.TabIndex = 1;
            this.lblAvailableMeals.Text = "Meal Database";
            // 
            // dgvAvailableMeals
            // 
            this.dgvAvailableMeals.AllowUserToAddRows = false;
            this.dgvAvailableMeals.AllowUserToDeleteRows = false;
            this.dgvAvailableMeals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAvailableMeals.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvAvailableMeals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailableMeals.Location = new System.Drawing.Point(23, 90);
            this.dgvAvailableMeals.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAvailableMeals.MultiSelect = false;
            this.dgvAvailableMeals.Name = "dgvAvailableMeals";
            this.dgvAvailableMeals.ReadOnly = true;
            this.dgvAvailableMeals.RowHeadersWidth = 51;
            this.dgvAvailableMeals.RowTemplate.Height = 24;
            this.dgvAvailableMeals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAvailableMeals.Size = new System.Drawing.Size(774, 200);
            this.dgvAvailableMeals.TabIndex = 2;
            this.dgvAvailableMeals.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAvailableMeals_CellFormatting);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDate.Location = new System.Drawing.Point(468, 333);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(53, 23);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date:";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(527, 327);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(162, 30);
            this.dtpDate.TabIndex = 4;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // lblMealType
            // 
            this.lblMealType.AutoSize = true;
            this.lblMealType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMealType.Location = new System.Drawing.Point(815, 237);
            this.lblMealType.Name = "lblMealType";
            this.lblMealType.Size = new System.Drawing.Size(80, 20);
            this.lblMealType.TabIndex = 5;
            this.lblMealType.Text = "Meal Type:";
            // 
            // cmbMealType
            // 
            this.cmbMealType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMealType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMealType.FormattingEnabled = true;
            this.cmbMealType.Items.AddRange(new object[] {
            "Breakfast",
            "Lunch",
            "Dinner",
            "Snack"});
            this.cmbMealType.Location = new System.Drawing.Point(819, 259);
            this.cmbMealType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMealType.Name = "cmbMealType";
            this.cmbMealType.Size = new System.Drawing.Size(185, 31);
            this.cmbMealType.TabIndex = 6;
            // 
            // btnAddToPlan
            // 
            this.btnAddToPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAddToPlan.FlatAppearance.BorderSize = 0;
            this.btnAddToPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToPlan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddToPlan.ForeColor = System.Drawing.Color.White;
            this.btnAddToPlan.Location = new System.Drawing.Point(819, 90);
            this.btnAddToPlan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddToPlan.Name = "btnAddToPlan";
            this.btnAddToPlan.Size = new System.Drawing.Size(251, 55);
            this.btnAddToPlan.TabIndex = 9;
            this.btnAddToPlan.Text = "+ ADD MEAL";
            this.btnAddToPlan.UseVisualStyleBackColor = false;
            this.btnAddToPlan.Click += new System.EventHandler(this.btnAddToPlan_Click);
            // 
            // lblUserPlan
            // 
            this.lblUserPlan.AutoSize = true;
            this.lblUserPlan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblUserPlan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblUserPlan.Location = new System.Drawing.Point(18, 331);
            this.lblUserPlan.Name = "lblUserPlan";
            this.lblUserPlan.Size = new System.Drawing.Size(117, 28);
            this.lblUserPlan.TabIndex = 10;
            this.lblUserPlan.Text = "Daily Track";
            this.lblUserPlan.Click += new System.EventHandler(this.lblUserPlan_Click);
            // 
            // dgvUserPlan
            // 
            this.dgvUserPlan.AllowUserToAddRows = false;
            this.dgvUserPlan.AllowUserToDeleteRows = false;
            this.dgvUserPlan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUserPlan.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvUserPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserPlan.Location = new System.Drawing.Point(23, 361);
            this.dgvUserPlan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvUserPlan.MultiSelect = false;
            this.dgvUserPlan.Name = "dgvUserPlan";
            this.dgvUserPlan.ReadOnly = true;
            this.dgvUserPlan.RowHeadersWidth = 51;
            this.dgvUserPlan.RowTemplate.Height = 24;
            this.dgvUserPlan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserPlan.Size = new System.Drawing.Size(774, 200);
            this.dgvUserPlan.TabIndex = 11;
            // 
            // lblTotalCalories
            // 
            this.lblTotalCalories.AutoSize = true;
            this.lblTotalCalories.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalCalories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.lblTotalCalories.Location = new System.Drawing.Point(18, 579);
            this.lblTotalCalories.Name = "lblTotalCalories";
            this.lblTotalCalories.Size = new System.Drawing.Size(157, 28);
            this.lblTotalCalories.TabIndex = 12;
            this.lblTotalCalories.Text = "Total Macros: 0";
            // 
            // btnRemoveFromPlan
            // 
            this.btnRemoveFromPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnRemoveFromPlan.FlatAppearance.BorderSize = 0;
            this.btnRemoveFromPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveFromPlan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRemoveFromPlan.ForeColor = System.Drawing.Color.White;
            this.btnRemoveFromPlan.Location = new System.Drawing.Point(819, 361);
            this.btnRemoveFromPlan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveFromPlan.Name = "btnRemoveFromPlan";
            this.btnRemoveFromPlan.Size = new System.Drawing.Size(251, 59);
            this.btnRemoveFromPlan.TabIndex = 13;
            this.btnRemoveFromPlan.Text = "🗑️ REMOVE SELECTED";
            this.btnRemoveFromPlan.UseVisualStyleBackColor = false;
            this.btnRemoveFromPlan.Click += new System.EventHandler(this.btnRemoveFromPlan_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(819, 160);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(251, 61);
            this.textBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Red;
            this.textBox2.Location = new System.Drawing.Point(819, 437);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(251, 84);
            this.textBox2.TabIndex = 14;
            // 
            // FormMealPlanning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1225, 643);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnRemoveFromPlan);
            this.Controls.Add(this.lblTotalCalories);
            this.Controls.Add(this.dgvUserPlan);
            this.Controls.Add(this.lblUserPlan);
            this.Controls.Add(this.btnAddToPlan);
            this.Controls.Add(this.cmbMealType);
            this.Controls.Add(this.lblMealType);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dgvAvailableMeals);
            this.Controls.Add(this.lblAvailableMeals);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMealPlanning";
            this.Text = "Meal Planning";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableMeals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserPlan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAvailableMeals;
        private System.Windows.Forms.DataGridView dgvAvailableMeals;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblMealType;
        private System.Windows.Forms.ComboBox cmbMealType;
        private System.Windows.Forms.Button btnAddToPlan;
        private System.Windows.Forms.Label lblUserPlan;
        private System.Windows.Forms.DataGridView dgvUserPlan;
        private System.Windows.Forms.Label lblTotalCalories;
        private System.Windows.Forms.Button btnRemoveFromPlan;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}