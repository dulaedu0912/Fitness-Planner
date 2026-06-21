using System.Windows.Forms;
using System;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.Data;

namespace FitnessPlanner
{
    public partial class FormDashboard : Form
    {
        private int currentUserId;
        private const int DailyCalorieGoal = 2000;

        public FormDashboard(int userId)
        {
            InitializeComponent();
            this.currentUserId = userId;
        }

        
        // DB METHODS
        
        private void GetUserName()
        {
            string query = "SELECT username FROM Users WHERE user_id = @userId";

            if (DBConnection.Instance().OpenConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, DBConnection.Instance().Connection);
                    cmd.Parameters.AddWithValue("@userId", currentUserId);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        string userName = result.ToString();
                        lblWelcome.Text = $"Hello, {userName} \nWelcome Back To Your PERSONALIZED MEAL AND WORKOUT PLANNING SYSTEM!";
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error loading user name: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    DBConnection.Instance().CloseConnection();
                }
            }
        }

        private void LoadLastWeight()
        {
            // Select the latest weight entry
            string query = @"
                SELECT metric_value 
                FROM UserProgress 
                WHERE user_id = @userId AND metric_type = 'Weight' 
                ORDER BY log_date DESC, progress_id DESC 
                LIMIT 1";

            if (DBConnection.Instance().OpenConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, DBConnection.Instance().Connection);
                    cmd.Parameters.AddWithValue("@userId", currentUserId);

                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        lblLastWeightValue.Text = $"{Convert.ToDecimal(result):F1} kg";
                        lblLastWeightValue.ForeColor = Color.DarkOrange;
                    }
                    else
                    {
                        lblLastWeightValue.Text = "N/A";
                        lblLastWeightValue.ForeColor = Color.Gray;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error loading last weight: " + ex.Message);
                }
                finally
                {
                    DBConnection.Instance().CloseConnection();
                }
            }
        }

        private void LoadTodaysWorkouts()
        {
            string dateStr = DateTime.Today.ToString("yyyy-MM-dd");
            string query = @"
                SELECT w.name, up.sets, up.reps
                FROM UserWorkoutPlans up
                JOIN Workouts w ON up.workout_id = w.workout_id
                WHERE up.user_id = @userId AND up.plan_date = @date
                ORDER BY w.name";

            if (DBConnection.Instance().OpenConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, DBConnection.Instance().Connection);
                    cmd.Parameters.AddWithValue("@userId", currentUserId);
                    cmd.Parameters.AddWithValue("@date", dateStr);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dtPlan = new DataTable();
                    adapter.Fill(dtPlan);

                    dgvTodaysWorkouts.DataSource = dtPlan;
                    dgvTodaysWorkouts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    if (dtPlan.Rows.Count == 0)
                    {
                        
                        DataTable noData = new DataTable();
                        noData.Columns.Add("Message", typeof(string));
                        noData.Rows.Add("No workouts planned for today. Get planning!");
                        dgvTodaysWorkouts.DataSource = noData;
                        dgvTodaysWorkouts.Columns["Message"].HeaderText = "";
                        dgvTodaysWorkouts.Columns["Message"].Width = dgvTodaysWorkouts.Width;
                    }
                    else
                    {
                        // Rename columns for display
                        if (dgvTodaysWorkouts.Columns.Contains("name")) dgvTodaysWorkouts.Columns["name"].HeaderText = "Exercise";
                        if (dgvTodaysWorkouts.Columns.Contains("sets")) dgvTodaysWorkouts.Columns["sets"].HeaderText = "Sets";
                        if (dgvTodaysWorkouts.Columns.Contains("reps")) dgvTodaysWorkouts.Columns["reps"].HeaderText = "Reps";
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error loading today's plan: " + ex.Message);
                }
                finally
                {
                    DBConnection.Instance().CloseConnection();
                }
            }
        }

        

        
       
        
        private void HighlightActiveButton(Button activeBtn)
        {
            
            Color inactiveColor = Color.FromArgb(34, 49, 63); // Sidebar background
            Color activeColor = Color.FromArgb(44, 62, 80); // Slightly lighter for highlight

            
            btnMealPlan.BackColor = inactiveColor;
            btnWorkoutPlan.BackColor = inactiveColor;
            btnProgress.BackColor = inactiveColor;

            
            if (activeBtn != null)
            {
                activeBtn.BackColor = activeColor;
                activeBtn.ForeColor = Color.White;
            }
        }


        
        // NAVIGATION HANDLERS 
        
        private void btnMealPlan_Click(object sender, EventArgs e)
        {
            HighlightActiveButton(btnMealPlan);
            
            FormMealPlanning mealForm = new FormMealPlanning(currentUserId);
            mealForm.ShowDialog();
            
            HighlightActiveButton(null);
            LoadLastWeight();
        }

        private void btnWorkoutPlan_Click(object sender, EventArgs e)
        {
            HighlightActiveButton(btnWorkoutPlan);
            FormWorkoutPlanning workoutForm = new FormWorkoutPlanning(currentUserId);
            workoutForm.ShowDialog();
            HighlightActiveButton(null);
            LoadTodaysWorkouts(); // Reload workout list
        }

        private void btnProgress_Click(object sender, EventArgs e)
        {
            HighlightActiveButton(btnProgress);
            FormProgress progressForm = new FormProgress(currentUserId);
            progressForm.ShowDialog();
            HighlightActiveButton(null);
            LoadLastWeight();
        }

       
        // LOGOUT & CLOSE HANDLERS
        
        private void FormDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();         
            FormLogin loginForm = new FormLogin();
            loginForm.Show();
        }

        
        // Form Events
        
        private void FormDashboard_Load(object sender, EventArgs e)
        {
            
            GetUserName();
            LoadLastWeight();
            LoadTodaysWorkouts();

            
            HighlightActiveButton(null);
        }

        private void FormDashboard_Resize(object sender, EventArgs e)
        {
            
        }

        private void pnlMainContent_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void lblCaloriesIn_Click(object sender, EventArgs e)
        {

        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }
    }
}