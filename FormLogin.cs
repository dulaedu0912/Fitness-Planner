using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Text;
using System;
using System.Windows.Forms;
using System.Drawing; 

namespace FitnessPlanner
{
    public partial class FormLogin : Form
    {
        // hint 
        private const string UsernameHint = "Enter your username";
        private readonly Color HintColor = Color.Gray;
        private readonly Color InputColor = Color.Black;

        public FormLogin()
        {
            InitializeComponent();
        }

        // textbox gets focus
        private void txtUsername_GotFocus(object sender, EventArgs e)
        {
            if (txtUsername.Text == UsernameHint)
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = InputColor;
            }
        }

        // hint if textbox empty
        private void txtUsername_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                txtUsername.Text = UsernameHint;
                txtUsername.ForeColor = HintColor;
            }
        }

        private void CenterPanel()
        {
            // Center the pnlLogin
            int x = (this.ClientSize.Width - pnlLogin.Width) / 2;
            int y = (this.ClientSize.Height - pnlLogin.Height) / 2;
            pnlLogin.Location = new Point(x, y);
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            string username = txtUsername.Text.Trim();
            if (username == UsernameHint)
            {
                username = ""; 
            }

            string password = txtPassword.Text.Trim();

            string hashedPassword = HashPassword(password);

            //  Database Query
            string query = "SELECT user_id FROM Users WHERE username = @user AND password_hash = @passHash";

            if (DBConnection.Instance().OpenConnection())
            {
                
                    MySqlCommand cmd = new MySqlCommand(query, DBConnection.Instance().Connection);
                    cmd.Parameters.AddWithValue("@user", username);
                    cmd.Parameters.AddWithValue("@passHash", hashedPassword);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        // Login successful
                        int userId = Convert.ToInt32(result);
                        textBox1.Text =$"Login successful! Welcome, {username}.";

                        //Open Dashboard Form
                        FormDashboard dashboard = new FormDashboard(userId);
                        dashboard.Show();
                        this.Hide();
                    }
                    if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                    {
                        textBox1.Text = "Please enter both username and password.";
                    }
                    else
                    {
                        // Login failed
                        textBox1.Text = "Invalid Username or Password.";                        
                        txtPassword.Clear();
                    }
                
                    DBConnection.Instance().CloseConnection();                
            }
        }

        private void lblRegisterLink_Click(object sender, EventArgs e)
        {
            // Open the reg form
            FormRegister register = new FormRegister();
            register.Show();
        }
        
        private void FormLogin_Load(object sender, EventArgs e)
        {  
            txtUsername_LostFocus(txtUsername, EventArgs.Empty);
        }


        private void FormLogin_Resize(object sender, EventArgs e)
        { }
        private void textBox1_TextChanged(object sender, EventArgs e)
        { }
        private void lblPassword_Click(object sender, EventArgs e)
        {        }
    }
}