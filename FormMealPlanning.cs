using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace FitnessPlanner
{
    public partial class FormMealPlanning : Form
    {
        private int currentUserId;
        private DataTable dtMeals;

        public FormMealPlanning(int userId)
        {
            InitializeComponent();
            this.currentUserId = userId;

            // Set initial selected meal type
            cmbMealType.SelectedIndex = 0;

            // Load  data
            LoadMealsData();
            LoadUserPlan(dtpDate.Value.Date);
        }

        
        // DATA LOADING
        private void LoadMealsData()
        {
            string query = "SELECT meal_id, name, calories, protein_g, carbs_g, fat_g FROM Meals ORDER BY name";

            if (DBConnection.Instance().OpenConnection())
            {
                try
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, DBConnection.Instance().Connection);
                    dtMeals = new DataTable();
                    adapter.Fill(dtMeals);

                    dgvAvailableMeals.DataSource = dtMeals;

                    
                    if (dgvAvailableMeals.Columns.Contains("meal_id"))
                        dgvAvailableMeals.Columns["meal_id"].Visible = false;

                    if (dgvAvailableMeals.Columns.Contains("name"))
                    {
                       
                        dgvAvailableMeals.Columns["name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dgvAvailableMeals.Columns["name"].HeaderText = "Meal Name";
                    }

                    dgvAvailableMeals.Columns["calories"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dgvAvailableMeals.Columns["protein_g"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dgvAvailableMeals.Columns["carbs_g"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dgvAvailableMeals.Columns["fat_g"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


                    dgvAvailableMeals.Columns["calories"].HeaderText = "Kcal";
                    dgvAvailableMeals.Columns["protein_g"].HeaderText = "Protein (g)";
                    dgvAvailableMeals.Columns["carbs_g"].HeaderText = "Carbs (g)";
                    dgvAvailableMeals.Columns["fat_g"].HeaderText = "Fat (g)";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading meal database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    DBConnection.Instance().CloseConnection();
                }
            }
        }

        // planned meals for a specific date
        private void LoadUserPlan(DateTime date)
        {
            string dateStr = date.ToString("yyyy-MM-dd");
            string query = @"
                SELECT up.plan_id, up.meal_type, m.name,  
                       (m.calories) AS TotalCalories,
                       (m.protein_g) AS TotalProtein,
                       (m.carbs_g) AS TotalCarbs,
                       (m.fat_g) AS TotalFat                     
                FROM UserMealPlans up
                JOIN Meals m ON up.meal_id = m.meal_id
                WHERE up.user_id = @userId AND up.plan_date = @date
                ORDER BY up.plan_id"; 

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

                    dgvUserPlan.DataSource = dtPlan;

                    if (dgvUserPlan.Columns.Contains("plan_id"))
                        dgvUserPlan.Columns["plan_id"].Visible = false;

                    if (dgvUserPlan.Columns.Contains("meal_type"))
                        dgvUserPlan.Columns["meal_type"].HeaderText = "Type";
                    if (dgvUserPlan.Columns.Contains("name"))
                        dgvUserPlan.Columns["name"].HeaderText = "Meal";
                    if (dgvUserPlan.Columns.Contains("TotalCalories"))
                        dgvUserPlan.Columns["TotalCalories"].HeaderText = "Kcal";
                    if (dgvUserPlan.Columns.Contains("TotalProtein"))
                        dgvUserPlan.Columns["TotalProtein"].HeaderText = "Protein (g)";
                    if (dgvUserPlan.Columns.Contains("TotalCarbs"))
                        dgvUserPlan.Columns["TotalCarbs"].HeaderText = "Carbs (g)";
                    if (dgvUserPlan.Columns.Contains("TotalFat"))
                        dgvUserPlan.Columns["TotalFat"].HeaderText = "Fat (g)";

                    // Calculate and display total calories and macronutrients
                    int totalCal = 0;
                    int totalProtein = 0;
                    int totalCarbs = 0;
                    int totalFat = 0;

                    foreach (DataRow row in dtPlan.Rows)
                    {
                        if (row["TotalCalories"] != DBNull.Value) totalCal += Convert.ToInt32(row["TotalCalories"]);
                        if (row["TotalProtein"] != DBNull.Value) totalProtein += Convert.ToInt32(row["TotalProtein"]);
                        if (row["TotalCarbs"] != DBNull.Value) totalCarbs += Convert.ToInt32(row["TotalCarbs"]);
                        if (row["TotalFat"] != DBNull.Value) totalFat += Convert.ToInt32(row["TotalFat"]);
                    }

                    // Update the summary label
                    lblTotalCalories.Text = $"Total Macros: {totalCal} Kcal | P: {totalProtein}g | C: {totalCarbs}g | F: {totalFat}g";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading user plan: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    DBConnection.Instance().CloseConnection();
                }
            }
        }

        
        

        // Adds the selected meal to the user's plan for the selected date
        private void btnAddToPlan_Click(object sender, EventArgs e)
        {
            if (dgvAvailableMeals.CurrentRow == null)
            {
                MessageBox.Show("Please select a meal from the database to add.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            if (!dgvAvailableMeals.Columns.Contains("meal_id"))
            {
                MessageBox.Show("Internal Error: The 'meal_id' column was not loaded.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get selected meal details
            int mealIdColumnIndex = dgvAvailableMeals.Columns["meal_id"].Index;
            int mealId = Convert.ToInt32(dgvAvailableMeals.CurrentRow.Cells[mealIdColumnIndex].Value);

            string mealType = cmbMealType.SelectedItem?.ToString();
            DateTime date = dtpDate.Value.Date;

            if (string.IsNullOrEmpty(mealType))
            {
                textBox1.Text = "Please select a Meal Type (Breakfast, Lunch, etc.)";
                return;
            }

            string query = "INSERT INTO UserMealPlans (user_id, plan_date, meal_id, meal_type) VALUES (@userId, @date, @mealId, @mealType)";

            if (DBConnection.Instance().OpenConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, DBConnection.Instance().Connection);
                    cmd.Parameters.AddWithValue("@userId", currentUserId);
                    cmd.Parameters.AddWithValue("@date", date.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@mealId", mealId);
                    cmd.Parameters.AddWithValue("@mealType", mealType);

                    cmd.ExecuteNonQuery();

                    LoadUserPlan(date);
                }
                catch (Exception ex)
                {
                    textBox1.Text = "Can't add same meal multiple times:"  ;
                }
                finally
                {
                    DBConnection.Instance().CloseConnection();
                }
            }
        }

        // Removes the selected meal entry from the user's plan
        private void btnRemoveFromPlan_Click(object sender, EventArgs e)
        {
            if (dgvUserPlan.CurrentRow == null || !dgvUserPlan.Columns.Contains("plan_id") || dgvUserPlan.CurrentRow.Cells["plan_id"].Value == DBNull.Value)
            {
                textBox2.Text = "Please select a meal from your daily plan to remove.";
                return;
            }

            int planId = Convert.ToInt32(dgvUserPlan.CurrentRow.Cells["plan_id"].Value);
            DateTime date = dtpDate.Value.Date;

            

            string query = "DELETE FROM UserMealPlans WHERE plan_id = @planId";

            if (DBConnection.Instance().OpenConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, DBConnection.Instance().Connection);
                    cmd.Parameters.AddWithValue("@planId", planId);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        LoadUserPlan(date);
                    }
                    else
                    {
                        textBox2.Text = "Removal failed. Meal not found.";
                    }
                }
                catch (Exception ex)
                {
                    textBox2.Text = "Error removing meal: " + ex.Message;
                }
                finally
                {
                    DBConnection.Instance().CloseConnection();
                }
            }
        }

        
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            
            LoadUserPlan(dtpDate.Value.Date);
        }

       
        private void dgvAvailableMeals_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvAvailableMeals.CurrentRow != null && e.RowIndex == dgvAvailableMeals.CurrentRow.Index)
            {
                e.CellStyle.BackColor = Color.FromArgb(230, 240, 255); 
            }
        }

        private void lblUserPlan_Click(object sender, EventArgs e)
        {

        }
    }
}