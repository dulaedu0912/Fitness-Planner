using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace FitnessPlanner
{
    public partial class FormWorkoutPlanning : Form
    {
        private int currentUserId;

        public FormWorkoutPlanning(int userId)
        {
            InitializeComponent();
            this.currentUserId = userId;
        }

        private void FormWorkoutPlanning_Load(object sender, EventArgs e)
        {
            LoadAllWorkouts();
            LoadUserWorkoutPlan(dtpPlanDate.Value.Date);
        }

        // --- Data Loading Methods ---

        private void LoadAllWorkouts()
        {
            // Removed 'description' from SELECT statement. ***
            string query = "SELECT workout_id, name FROM Workouts ORDER BY name";
            DataTable dtWorkouts = new DataTable();

            if (DBConnection.Instance().OpenConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, DBConnection.Instance().Connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dtWorkouts);

                    // Set DataSource first
                    dgvAllWorkouts.DataSource = dtWorkouts;

                    // Explicitly set column visibility and headers after binding
                    if (dgvAllWorkouts.Columns.Contains("workout_id"))
                    {
                        dgvAllWorkouts.Columns["workout_id"].Visible = false; // Hide ID
                    }

                    if (dgvAllWorkouts.Columns.Contains("name"))
                    {
                        dgvAllWorkouts.Columns["name"].HeaderText = "Exercise Name";
                        dgvAllWorkouts.Columns["name"].Visible = true;
                    }

                    // NOTE: Removed handling for "description" column.

                    dgvAllWorkouts.Refresh();
                }
                catch (Exception ex)
                {
                    // If the problem persists, this will now show the actual error if it's not the column name.
                    MessageBox.Show("Error loading available workouts: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    DBConnection.Instance().CloseConnection();
                }
            }
        }

        private void LoadUserWorkoutPlan(DateTime date)
        {
            string dateStr = date.ToString("yyyy-MM-dd");
            string query = @"
                SELECT up.plan_id, w.name, up.sets, up.reps
                FROM UserWorkoutPlans up
                JOIN Workouts w ON up.workout_id = w.workout_id
                WHERE up.user_id = @userId AND up.plan_date = @date
                ORDER BY w.name";

            DataTable dtPlan = new DataTable();

            if (DBConnection.Instance().OpenConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, DBConnection.Instance().Connection);
                    cmd.Parameters.AddWithValue("@userId", currentUserId);
                    cmd.Parameters.AddWithValue("@date", dateStr);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dtPlan);

                    dgvCurrentPlan.DataSource = dtPlan;

                    if (dgvCurrentPlan.Columns.Contains("plan_id")) dgvCurrentPlan.Columns["plan_id"].Visible = false; // Hide Plan ID for removal
                    if (dgvCurrentPlan.Columns.Contains("name")) dgvCurrentPlan.Columns["name"].HeaderText = "Exercise";
                    if (dgvCurrentPlan.Columns.Contains("sets")) dgvCurrentPlan.Columns["sets"].HeaderText = "Sets";
                    if (dgvCurrentPlan.Columns.Contains("reps")) dgvCurrentPlan.Columns["reps"].HeaderText = "Reps";

                    if (dtPlan.Rows.Count == 0)
                    {
                        lblCurrentPlanTitle.Text = $"Your Plan for: {date.ToShortDateString()} (Empty)";
                    }
                    else
                    {
                        lblCurrentPlanTitle.Text = $"Your Plan for: {date.ToShortDateString()}";
                    }

                    dgvCurrentPlan.Refresh(); // Force refresh for plan grid too
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading plan: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    DBConnection.Instance().CloseConnection();
                }
            }
        }

        // --- Event Handlers ---

        private void dtpPlanDate_ValueChanged(object sender, EventArgs e)
        {
            LoadUserWorkoutPlan(dtpPlanDate.Value.Date);
        }

        private void btnAddToPlan_Click(object sender, EventArgs e)
        {
            if (dgvAllWorkouts.SelectedRows.Count == 0)
            {
                textBox1.Text = "Please select an exercise from the list below.";
                return;
            }

            // Ensure the selected row is valid before accessing cells
            if (dgvAllWorkouts.SelectedRows[0].Cells["workout_id"].Value == null || dgvAllWorkouts.SelectedRows[0].Cells["workout_id"].Value == DBNull.Value)
            {
                textBox1.Text = "Selected row has no valid Workout. Please select a different exercise.";
                return;
            }

            int workoutId = Convert.ToInt32(dgvAllWorkouts.SelectedRows[0].Cells["workout_id"].Value);
            int sets = (int)nudSets.Value;
            int reps = (int)nudReps.Value;
            string dateStr = dtpPlanDate.Value.Date.ToString("yyyy-MM-dd");

            string query = "INSERT INTO UserWorkoutPlans (user_id, workout_id, plan_date, sets, reps) VALUES (@userId, @workoutId, @date, @sets, @reps)";

            if (DBConnection.Instance().OpenConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, DBConnection.Instance().Connection);
                    cmd.Parameters.AddWithValue("@userId", currentUserId);
                    cmd.Parameters.AddWithValue("@workoutId", workoutId);
                    cmd.Parameters.AddWithValue("@date", dateStr);
                    cmd.Parameters.AddWithValue("@sets", sets);
                    cmd.Parameters.AddWithValue("@reps", reps);

                    cmd.ExecuteNonQuery();
                   textBox1.Text = "Workout added to plan successfully!";
                    LoadUserWorkoutPlan(dtpPlanDate.Value.Date); // Reload the plan
                }
                catch (Exception ex)
                {
                    textBox1.Text = "Can't add same workout multiple times. please use sets feature ";
                }
                finally
                {
                    DBConnection.Instance().CloseConnection();
                }
            }
        }

        private void btnRemoveFromPlan_Click(object sender, EventArgs e)
        {
            if (dgvCurrentPlan.SelectedRows.Count == 0)
            {
                textBox2.Text = "Please select a workout from your current plan to remove.";
                return;
            }           

            int planId = Convert.ToInt32(dgvCurrentPlan.SelectedRows[0].Cells["plan_id"].Value);

            DialogResult result = DialogResult.Yes;

            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM UserWorkoutPlans WHERE plan_id = @planId";

                if (DBConnection.Instance().OpenConnection())
                {
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand(query, DBConnection.Instance().Connection);
                        cmd.Parameters.AddWithValue("@planId", planId);

                        cmd.ExecuteNonQuery();
                        textBox2.Text = "Workout removed successfully!";
                        LoadUserWorkoutPlan(dtpPlanDate.Value.Date); // Reload the plan
                    }
                    catch (Exception)
                    {
                        textBox2.Text = "Error removing workout: ";
                        return;
                    }
                    finally
                    {
                        DBConnection.Instance().CloseConnection();
                    }
                }
            }
        }

        private void btnMarkCompleted_Click(object sender, EventArgs e)
        {
            // 1. Check if the current plan date is today
            if (dtpPlanDate.Value.Date != DateTime.Today.Date)
            {
                textBox2.Text = "You can only mark the current day's workout as completed. Please switch the date to today.";
                return;
            }

            // 2. Log the completion to UserProgress
            string dateStr = DateTime.Today.ToString("yyyy-MM-dd");
            string metricType = "WorkoutCompleted";
            decimal value = 1; // 1 means completed

            string query = "INSERT INTO UserProgress (user_id, log_date, metric_type, metric_value) VALUES (@userId, @date, @metricType, @value)";
            string checkQuery = "SELECT COUNT(*) FROM UserProgress WHERE user_id = @userId AND log_date = @date AND metric_type = @metricType";

            if (DBConnection.Instance().OpenConnection())
            {
                MySqlTransaction transaction = null;
                try
                {
                    transaction = DBConnection.Instance().Connection.BeginTransaction();

                    // Check if already logged
                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, DBConnection.Instance().Connection, transaction);
                    checkCmd.Parameters.AddWithValue("@userId", currentUserId);
                    checkCmd.Parameters.AddWithValue("@date", dateStr);
                    checkCmd.Parameters.AddWithValue("@metricType", metricType);

                    long count = (long)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        textBox2.Text = "Already marked as completed or no workout added to Daily Plan.";
                        return;
                    }

                    // Proceed with insertion
                    MySqlCommand cmd = new MySqlCommand(query, DBConnection.Instance().Connection, transaction);
                    cmd.Parameters.AddWithValue("@userId", currentUserId);
                    cmd.Parameters.AddWithValue("@date", dateStr);
                    cmd.Parameters.AddWithValue("@metricType", metricType);
                    cmd.Parameters.AddWithValue("@value", value);

                    cmd.ExecuteNonQuery();
                    transaction.Commit();

                    textBox2.Text = "Today's workout successfully marked as completed!";

                    // Close the form to return to the dashboard
                    this.Close();
                }
                catch (Exception ex)
                {
                    transaction?.Rollback();
                    MessageBox.Show("Error logging workout: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    DBConnection.Instance().CloseConnection();
                }
            }
        }
    }
}