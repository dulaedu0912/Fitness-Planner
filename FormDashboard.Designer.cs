namespace FitnessPlanner
{
    partial class FormDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnMealPlan = new System.Windows.Forms.Button();
            this.btnWorkoutPlan = new System.Windows.Forms.Button();
            this.btnProgress = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lblSidebarTitle = new System.Windows.Forms.Label();
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.dgvTodaysWorkouts = new System.Windows.Forms.DataGridView();
            this.lblTodaysPlanTitle = new System.Windows.Forms.Label();
            this.pnlQuickStats = new System.Windows.Forms.Panel();
            this.lblLastWeightValue = new System.Windows.Forms.Label();
            this.lblLastWeight = new System.Windows.Forms.Label();
            this.lblStatsTitle = new System.Windows.Forms.Label();
            this.lblDailyQuote = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            this.pnlMainContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodaysWorkouts)).BeginInit();
            this.pnlQuickStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblTitle.Location = new System.Drawing.Point(30, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(370, 54);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Fitness Dashboard";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(35, 90);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(758, 28);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome Back To Your PERSONALIZED MEAL AND WORKOUT PLANNING SYSTEM";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // btnMealPlan
            // 
            this.btnMealPlan.BackColor = System.Drawing.Color.Transparent;
            this.btnMealPlan.FlatAppearance.BorderSize = 0;
            this.btnMealPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMealPlan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMealPlan.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMealPlan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMealPlan.Location = new System.Drawing.Point(-5, 95);
            this.btnMealPlan.Name = "btnMealPlan";
            this.btnMealPlan.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnMealPlan.Size = new System.Drawing.Size(280, 60);
            this.btnMealPlan.TabIndex = 2;
            this.btnMealPlan.Text = "    🍽️ Meal Planning";
            this.btnMealPlan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMealPlan.UseVisualStyleBackColor = false;
            this.btnMealPlan.Click += new System.EventHandler(this.btnMealPlan_Click);
            // 
            // btnWorkoutPlan
            // 
            this.btnWorkoutPlan.BackColor = System.Drawing.Color.Transparent;
            this.btnWorkoutPlan.FlatAppearance.BorderSize = 0;
            this.btnWorkoutPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkoutPlan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWorkoutPlan.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnWorkoutPlan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWorkoutPlan.Location = new System.Drawing.Point(-5, 161);
            this.btnWorkoutPlan.Name = "btnWorkoutPlan";
            this.btnWorkoutPlan.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnWorkoutPlan.Size = new System.Drawing.Size(277, 60);
            this.btnWorkoutPlan.TabIndex = 3;
            this.btnWorkoutPlan.Text = "    🏋️ Workout Tracker";
            this.btnWorkoutPlan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWorkoutPlan.UseVisualStyleBackColor = false;
            this.btnWorkoutPlan.Click += new System.EventHandler(this.btnWorkoutPlan_Click);
            // 
            // btnProgress
            // 
            this.btnProgress.BackColor = System.Drawing.Color.Transparent;
            this.btnProgress.FlatAppearance.BorderSize = 0;
            this.btnProgress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProgress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProgress.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnProgress.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProgress.Location = new System.Drawing.Point(-3, 226);
            this.btnProgress.Name = "btnProgress";
            this.btnProgress.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnProgress.Size = new System.Drawing.Size(280, 60);
            this.btnProgress.TabIndex = 4;
            this.btnProgress.Text = "    📈 Progress";
            this.btnProgress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProgress.UseVisualStyleBackColor = false;
            this.btnProgress.Click += new System.EventHandler(this.btnProgress_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(28, 490);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(224, 40);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "🚪 LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.pnlSidebar.Controls.Add(this.lblSidebarTitle);
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Controls.Add(this.btnProgress);
            this.pnlSidebar.Controls.Add(this.btnWorkoutPlan);
            this.pnlSidebar.Controls.Add(this.btnMealPlan);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(280, 576);
            this.pnlSidebar.TabIndex = 6;
            // 
            // lblSidebarTitle
            // 
            this.lblSidebarTitle.AutoSize = true;
            this.lblSidebarTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSidebarTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lblSidebarTitle.Location = new System.Drawing.Point(2, 35);
            this.lblSidebarTitle.Name = "lblSidebarTitle";
            this.lblSidebarTitle.Size = new System.Drawing.Size(253, 31);
            this.lblSidebarTitle.TabIndex = 7;
            this.lblSidebarTitle.Text = "💪 FITNESS PLANNER";
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.AutoScroll = true;
            this.pnlMainContent.BackColor = System.Drawing.Color.White;
            this.pnlMainContent.Controls.Add(this.dgvTodaysWorkouts);
            this.pnlMainContent.Controls.Add(this.lblTodaysPlanTitle);
            this.pnlMainContent.Controls.Add(this.pnlQuickStats);
            this.pnlMainContent.Controls.Add(this.lblDailyQuote);
            this.pnlMainContent.Controls.Add(this.lblWelcome);
            this.pnlMainContent.Controls.Add(this.lblTitle);
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Location = new System.Drawing.Point(280, 0);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Size = new System.Drawing.Size(920, 576);
            this.pnlMainContent.TabIndex = 7;
            this.pnlMainContent.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMainContent_Paint);
            // 
            // dgvTodaysWorkouts
            // 
            this.dgvTodaysWorkouts.AllowUserToAddRows = false;
            this.dgvTodaysWorkouts.AllowUserToDeleteRows = false;
            this.dgvTodaysWorkouts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTodaysWorkouts.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvTodaysWorkouts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTodaysWorkouts.Location = new System.Drawing.Point(35, 370);
            this.dgvTodaysWorkouts.MultiSelect = false;
            this.dgvTodaysWorkouts.Name = "dgvTodaysWorkouts";
            this.dgvTodaysWorkouts.ReadOnly = true;
            this.dgvTodaysWorkouts.RowHeadersWidth = 51;
            this.dgvTodaysWorkouts.RowTemplate.Height = 24;
            this.dgvTodaysWorkouts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTodaysWorkouts.Size = new System.Drawing.Size(850, 160);
            this.dgvTodaysWorkouts.TabIndex = 10;
            // 
            // lblTodaysPlanTitle
            // 
            this.lblTodaysPlanTitle.AutoSize = true;
            this.lblTodaysPlanTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTodaysPlanTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblTodaysPlanTitle.Location = new System.Drawing.Point(30, 330);
            this.lblTodaysPlanTitle.Name = "lblTodaysPlanTitle";
            this.lblTodaysPlanTitle.Size = new System.Drawing.Size(197, 32);
            this.lblTodaysPlanTitle.TabIndex = 9;
            this.lblTodaysPlanTitle.Text = "🗓️ Today\'s Plan";
            // 
            // pnlQuickStats
            // 
            this.pnlQuickStats.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlQuickStats.Controls.Add(this.lblLastWeightValue);
            this.pnlQuickStats.Controls.Add(this.lblLastWeight);
            this.pnlQuickStats.Controls.Add(this.lblStatsTitle);
            this.pnlQuickStats.Location = new System.Drawing.Point(35, 210);
            this.pnlQuickStats.Name = "pnlQuickStats";
            this.pnlQuickStats.Size = new System.Drawing.Size(850, 100);
            this.pnlQuickStats.TabIndex = 8;
            // 
            // lblLastWeightValue
            // 
            this.lblLastWeightValue.AutoSize = true;
            this.lblLastWeightValue.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblLastWeightValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblLastWeightValue.Location = new System.Drawing.Point(230, 48);
            this.lblLastWeightValue.Name = "lblLastWeightValue";
            this.lblLastWeightValue.Size = new System.Drawing.Size(69, 37);
            this.lblLastWeightValue.TabIndex = 2;
            this.lblLastWeightValue.Text = "N/A";
            // 
            // lblLastWeight
            // 
            this.lblLastWeight.AutoSize = true;
            this.lblLastWeight.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblLastWeight.Location = new System.Drawing.Point(20, 56);
            this.lblLastWeight.Name = "lblLastWeight";
            this.lblLastWeight.Size = new System.Drawing.Size(180, 23);
            this.lblLastWeight.TabIndex = 1;
            this.lblLastWeight.Text = "Latest Logged Weight:";
            // 
            // lblStatsTitle
            // 
            this.lblStatsTitle.AutoSize = true;
            this.lblStatsTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblStatsTitle.Location = new System.Drawing.Point(15, 10);
            this.lblStatsTitle.Name = "lblStatsTitle";
            this.lblStatsTitle.Size = new System.Drawing.Size(153, 28);
            this.lblStatsTitle.TabIndex = 0;
            this.lblStatsTitle.Text = "🚀 Quick Stats";
            // 
            // lblDailyQuote
            // 
            this.lblDailyQuote.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.lblDailyQuote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.lblDailyQuote.Location = new System.Drawing.Point(35, 143);
            this.lblDailyQuote.Name = "lblDailyQuote";
            this.lblDailyQuote.Size = new System.Drawing.Size(550, 60);
            this.lblDailyQuote.TabIndex = 2;
            this.lblDailyQuote.Text = "“The only bad workout is the one that didn\'t happen.”";
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 576);
            this.Controls.Add(this.pnlMainContent);
            this.Controls.Add(this.pnlSidebar);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "FormDashboard";
            this.Text = "Fitness Planner Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDashboard_FormClosed);
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.Resize += new System.EventHandler(this.FormDashboard_Resize);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.pnlMainContent.ResumeLayout(false);
            this.pnlMainContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodaysWorkouts)).EndInit();
            this.pnlQuickStats.ResumeLayout(false);
            this.pnlQuickStats.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        // Existing Declarations
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWelcome;
        public System.Windows.Forms.Button btnMealPlan;
        public System.Windows.Forms.Button btnWorkoutPlan;
        public System.Windows.Forms.Button btnProgress;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.Label lblSidebarTitle;
        private System.Windows.Forms.Label lblDailyQuote;

        // NEW Dashboard Summary Declarations
        private System.Windows.Forms.Panel pnlQuickStats;
        private System.Windows.Forms.Label lblStatsTitle;
        private System.Windows.Forms.Label lblLastWeightValue;
        private System.Windows.Forms.Label lblLastWeight;
        private System.Windows.Forms.Label lblTodaysPlanTitle;
        private System.Windows.Forms.DataGridView dgvTodaysWorkouts;
    }
}