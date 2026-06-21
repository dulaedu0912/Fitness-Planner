// Part of the auto-generated code for FormRegister - WORLD-CLASS REDESIGN
namespace FitnessPlanner
{
    partial class FormRegister
    {
        private System.ComponentModel.IContainer components = null;

        // --- DECLARATIONS ---
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblLoginLink;
        private System.Windows.Forms.Panel pnlRegister; // Central container
        private System.Windows.Forms.Label lblConfirmPassword; // New field for UX/Security
        private System.Windows.Forms.TextBox txtConfirmPassword; // New field for UX/Security

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblLoginLink = new System.Windows.Forms.Label();
            this.pnlRegister = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnlRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lblTitle.Location = new System.Drawing.Point(236, 48);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(308, 54);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Join Fitness 💪";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUsername.Location = new System.Drawing.Point(235, 211);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(78, 20);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUsername.ForeColor = System.Drawing.Color.Gray;
            this.txtUsername.Location = new System.Drawing.Point(235, 236);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(300, 30);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.Text = "Choose a unique username";
            this.txtUsername.GotFocus += new System.EventHandler(this.txtUsername_GotFocus);
            this.txtUsername.LostFocus += new System.EventHandler(this.txtUsername_LostFocus);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPassword.Location = new System.Drawing.Point(236, 284);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 20);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassword.Location = new System.Drawing.Point(236, 309);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(300, 30);
            this.txtPassword.TabIndex = 4;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblConfirmPassword.Location = new System.Drawing.Point(236, 355);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(130, 20);
            this.lblConfirmPassword.TabIndex = 8;
            this.lblConfirmPassword.Text = "Confirm Password:";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtConfirmPassword.Location = new System.Drawing.Point(236, 380);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '•';
            this.txtConfirmPassword.Size = new System.Drawing.Size(300, 30);
            this.txtConfirmPassword.TabIndex = 5;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFullName.Location = new System.Drawing.Point(236, 141);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(79, 20);
            this.lblFullName.TabIndex = 5;
            this.lblFullName.Text = "Full Name:";
            // 
            // txtFullName
            // 
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFullName.ForeColor = System.Drawing.Color.Gray;
            this.txtFullName.Location = new System.Drawing.Point(236, 166);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(300, 30);
            this.txtFullName.TabIndex = 1;
            this.txtFullName.Text = "Enter your full name";
            this.txtFullName.GotFocus += new System.EventHandler(this.txtFullName_GotFocus);
            this.txtFullName.LostFocus += new System.EventHandler(this.txtFullName_LostFocus);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(236, 465);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(300, 45);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "CREATE ACCOUNT";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblLoginLink
            // 
            this.lblLoginLink.AutoSize = true;
            this.lblLoginLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLoginLink.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginLink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lblLoginLink.Location = new System.Drawing.Point(266, 521);
            this.lblLoginLink.Name = "lblLoginLink";
            this.lblLoginLink.Size = new System.Drawing.Size(229, 20);
            this.lblLoginLink.TabIndex = 7;
            this.lblLoginLink.Text = "Already have an account? Login";
            this.lblLoginLink.Click += new System.EventHandler(this.lblLoginLink_Click);
            // 
            // pnlRegister
            // 
            this.pnlRegister.BackColor = System.Drawing.Color.White;
            this.pnlRegister.Controls.Add(this.textBox1);
            this.pnlRegister.Controls.Add(this.lblLoginLink);
            this.pnlRegister.Controls.Add(this.btnRegister);
            this.pnlRegister.Controls.Add(this.txtFullName);
            this.pnlRegister.Controls.Add(this.lblFullName);
            this.pnlRegister.Controls.Add(this.txtConfirmPassword);
            this.pnlRegister.Controls.Add(this.lblConfirmPassword);
            this.pnlRegister.Controls.Add(this.txtPassword);
            this.pnlRegister.Controls.Add(this.lblPassword);
            this.pnlRegister.Controls.Add(this.txtUsername);
            this.pnlRegister.Controls.Add(this.lblUsername);
            this.pnlRegister.Controls.Add(this.lblTitle);
            this.pnlRegister.Location = new System.Drawing.Point(0, 0);
            this.pnlRegister.Name = "pnlRegister";
            this.pnlRegister.Size = new System.Drawing.Size(803, 631);
            this.pnlRegister.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(236, 416);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(300, 43);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FormRegister
            // 
            this.AcceptButton = this.btnRegister;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 626);
            this.Controls.Add(this.pnlRegister);
            this.Name = "FormRegister";
            this.Text = "Fitness Planner Registration";
            this.Load += new System.EventHandler(this.FormRegister_Load);
            this.pnlRegister.ResumeLayout(false);
            this.pnlRegister.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TextBox textBox1;
    }
}