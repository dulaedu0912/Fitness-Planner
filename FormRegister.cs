using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Text;
using System;
using System.Windows.Forms;
using System.Drawing; 
 

namespace FitnessPlanner
{
    public partial class FormRegister : Form
    {
        // Define initial hint 
        private const string FullNameHint = "Enter your full name";
        private const string UsernameHint = "Choose a unique username";
        private readonly Color HintColor = Color.Gray;
        private readonly Color InputColor = Color.Black;

        public FormRegister()
        {
            InitializeComponent();
        }

       
        
        
        private void HandleGotFocus(TextBox textBox, string hint)
        {
            if (textBox.Text == hint)
            {
                textBox.Text = "";
                textBox.ForeColor = InputColor;
            }
        }

        private void HandleLostFocus(TextBox textBox, string hint)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = hint;
                textBox.ForeColor = HintColor;
            }
        }

        private void txtFullName_GotFocus(object sender, EventArgs e) => HandleGotFocus(txtFullName, FullNameHint);
        private void txtFullName_LostFocus(object sender, EventArgs e) => HandleLostFocus(txtFullName, FullNameHint);
        
        private void txtUsername_GotFocus(object sender, EventArgs e) => HandleGotFocus(txtUsername, UsernameHint);
        private void txtUsername_LostFocus(object sender, EventArgs e) => HandleLostFocus(txtUsername, UsernameHint);

       
        
        
        private void CenterPanel()
        {
            
            int x = (this.ClientSize.Width - pnlRegister.Width) / 2;
            int y = (this.ClientSize.Height - pnlRegister.Height) / 2;
            pnlRegister.Location = new Point(x, y);
        }

        
        // HashPassword 
        
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

        


        private void btnRegister_Click(object sender, EventArgs e)
        {
           
            string username = txtUsername.Text.Trim() == UsernameHint ? "" : txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();
            string fullName = txtFullName.Text.Trim() == FullNameHint ? "" : txtFullName.Text.Trim();

            //Client-Side Validation 
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                textBox1.Text = "Username and Password are required fields.";
                return;
            }
            if (password != confirmPassword)
            {
                textBox1.Text ="Password and Confirm Password must match.";
                return;
            }

            // Hash the password 
            string hashedPassword = HashPassword(password);

            string query = "INSERT INTO Users (username, password_hash, full_name) VALUES (@user, @passHash, @name)";

            if (DBConnection.Instance().OpenConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, DBConnection.Instance().Connection);

                    // Use parameters to prevent SQL Injection
                    cmd.Parameters.AddWithValue("@user", username);
                    cmd.Parameters.AddWithValue("@passHash", hashedPassword);
                    cmd.Parameters.AddWithValue("@name", fullName);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Registration successful! You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close(); 
                    }
                    else
                    {
                        MessageBox.Show("Registration failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (MySqlException ex) when (ex.Number == 1062) 
                {
                    textBox1.Text = "Username already exists. Please choose another.";
                }
                catch (Exception ex)
                {
                    textBox1.Text = "An unexpected error occurred: " + ex.Message ;
                }
                finally
                {
                    DBConnection.Instance().CloseConnection();
                }
            }
        }

        private void lblLoginLink_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        
       
        
        private void FormRegister_Load(object sender, EventArgs e)
        {
            CenterPanel(); 
            txtFullName_LostFocus(txtFullName, EventArgs.Empty);
            txtUsername_LostFocus(txtUsername, EventArgs.Empty);
        }

        private void FormRegister_Resize(object sender, EventArgs e)
        {
            
            CenterPanel();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}