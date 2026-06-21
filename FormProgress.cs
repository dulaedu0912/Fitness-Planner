using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;

namespace FitnessPlanner
{
    public partial class FormProgress : Form
    {
        private int currentUserId;

        public FormProgress(int userId)
        {
            InitializeComponent();
            this.currentUserId = userId;

            // Set initial values 
            nudWeight.Value = 75;
            nudCaloriesOut.Value = 500;
        }

        private void FormProgress_Load(object sender, EventArgs e)
        {
            
            LoadAllProgressCharts();
        }

        // LOGGING SECTION

        private void btnLogWeight_Click(object sender, EventArgs e)
        {
            decimal weight = nudWeight.Value;
            LogProgress("Weight", weight);
            LoadProgressData(chartWeight, "Weight"); 
        }

        private void btnLogCaloriesOut_Click(object sender, EventArgs e)
        {
            decimal caloriesOut = nudCaloriesOut.Value;
            LogProgress("CaloriesOut", caloriesOut);
            LoadProgressData(chartCaloriesOut, "CaloriesOut"); 
        }

        private void LogProgress(string metricType, decimal value)
        {
            
           
            string query = "INSERT INTO UserProgress (user_id, log_date, metric_type, metric_value) VALUES (@userId, @date, @metricType, @value)";

            if (DBConnection.Instance().OpenConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, DBConnection.Instance().Connection);
                    cmd.Parameters.AddWithValue("@userId", currentUserId);
                    cmd.Parameters.AddWithValue("@date", DateTime.Today.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@metricType", metricType);
                    cmd.Parameters.AddWithValue("@value", value);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show($"{metricType} logged successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error logging progress: " + ex.Message);
                }
                finally
                {
                    DBConnection.Instance().CloseConnection();
                }
            }
        }

        //visualization section

        private void LoadAllProgressCharts()
        {
            
            LoadProgressData(chartWeight, "Weight");
            LoadProgressData(chartCaloriesOut, "CaloriesOut");
        }

        private void LoadProgressData(Chart chartControl, string metricType)
        {
            string query = "SELECT log_date, metric_value FROM UserProgress WHERE user_id = @userId AND metric_type = @metricType ORDER BY log_date ASC";
            DataTable dtProgress = new DataTable();

            if (DBConnection.Instance().OpenConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, DBConnection.Instance().Connection);
                    cmd.Parameters.AddWithValue("@userId", currentUserId);
                    cmd.Parameters.AddWithValue("@metricType", metricType);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dtProgress);
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show($"Error loading {metricType} progress data: " + ex.Message);
                }
                finally
                {
                    DBConnection.Instance().CloseConnection();
                }
            }

            DisplayChart(chartControl, dtProgress, metricType);
        }

        private void DisplayChart(Chart chartControl, DataTable data, string metricName)
        {
            // 1. Clear previous data
            chartControl.Series.Clear();
            chartControl.Titles.Clear();

            // 2. Set Chart Title
            chartControl.Titles.Add($"{metricName} Progress");

            // 3. Create a new Series (the line on the graph)
            Color chartColor = metricName == "Weight" ? Color.DodgerBlue : Color.OrangeRed;

            Series series = new Series
            {
                Name = metricName,
                IsVisibleInLegend = true, // Keep legend for clarity
                ChartType = SeriesChartType.Line,
                Color = chartColor,
                BorderWidth = 3,
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 6,
                MarkerColor = chartColor
            };

            // 4. Add data points
            foreach (DataRow row in data.Rows)
            {
                if (row["log_date"] != DBNull.Value && row["metric_value"] != DBNull.Value)
                {
                    DateTime date = Convert.ToDateTime(row["log_date"]);
                    double value = Convert.ToDouble(row["metric_value"]);
                    series.Points.AddXY(date, value);
                }
            }

            // If no data, display a placeholder
            if (series.Points.Count == 0)
            {
                series.Points.AddXY(DateTime.Today.AddDays(-7), 0);
                series.Points.AddXY(DateTime.Today, 0);
                series.Color = Color.LightGray;
                series.BorderDashStyle = ChartDashStyle.Dash;
            }

            // Add the series to the chart
            chartControl.Series.Add(series);

            //  Configure Axist
            chartControl.ChartAreas[0].AxisX.Title = "Date";
            chartControl.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            chartControl.ChartAreas[0].AxisX.LabelStyle.Format = "MM-dd";
            chartControl.ChartAreas[0].AxisX.LabelStyle.Angle = -45;

            chartControl.ChartAreas[0].AxisY.Title = $"{metricName} ({(metricName == "Weight" ? "kg" : "kcal")})";
            chartControl.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            chartControl.ChartAreas[0].AxisY.IsLabelAutoFit = true;
        }

        // BMI CALCULATOR SECTION 

        private void btnCalculateBmi_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtWeightBMI.Text, out double weightKg) && double.TryParse(txtHeight.Text, out double heightM))
            {
                if (heightM > 0)
                {                  
                    double bmi = weightKg / (heightM * heightM) +5 ;
                    string status = GetBmiStatus(bmi) ;

                    lblBmiValue.Text = $"{bmi:0.00}";
                    lblBmiStatusValue.Text = status;
                    SetBmiStatusColor(status);
                }
                else
                {
                    textBox1.Text = "Height must be greater than zero.";
                }
            }
            else
            {
                textBox1.Text = "Please enter valid numerical values for Weight (kg) and Height (m).";
            }
        }

        private string GetBmiStatus(double bmi)
        {
            if (bmi < 18.5) return "Underweight";
            if (bmi < 25.0) return "Healthy Weight"; 
            if (bmi < 30.0) return "Overweight";
            return "Obese"; 
        }

        private void SetBmiStatusColor(string status)
        {
            switch (status)
            {
                case "Healthy Weight":
                    lblBmiStatusValue.ForeColor = Color.ForestGreen;
                    break;
                case "Underweight":
                    lblBmiStatusValue.ForeColor = Color.DarkOrange;
                    break;
                case "Overweight":
                    lblBmiStatusValue.ForeColor = Color.OrangeRed;
                    break;
                case "Obese":
                    lblBmiStatusValue.ForeColor = Color.Red;
                    break;
                default:
                    lblBmiStatusValue.ForeColor = Color.Gray;
                    break;
            }
        }
    }
}