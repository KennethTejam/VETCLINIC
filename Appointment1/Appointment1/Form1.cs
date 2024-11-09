using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Appointment1
{
    public partial class Date_Form : Form
    {
        private int userID = 1; // Sample userID for testing
        private string selectedDate;
        private string selectedTime;



        PROCESSES process = new PROCESSES();

        SqlConnection conn;


        public Date_Form()
        {
            InitializeComponent();
            this.Load += new EventHandler(Date_Load);

            // Attach event handlers
            cbdate.SelectedIndexChanged += cbdate_SelectedIndexChanged;
            cbTime.SelectedIndexChanged += cbTime_SelectedIndexChanged;
            conn = process.getConnection();

        }

        private void Date_Load(object sender, EventArgs e)
        {
                LoadChoicesFromDatabase(); // Load date choices when the form loads  

        }

        private void LoadChoicesFromDatabase()
        {
             

            {
                try
                {
                    conn.Open();
                    string query = @"
                    SELECT DISTINCT 
                        FORMAT(date, 'dddd, MMMM dd, yyyy') AS DateFormatted 
                    FROM Schedule;";

                    using (SqlCommand command = new SqlCommand(query, conn))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        cbdate.Items.Clear(); // Clear existing items

                        while (reader.Read())
                        {
                            cbdate.Items.Add(reader["DateFormatted"].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading dates: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void LoadTimesForDate(string date)
        {
            using (SqlConnection conn = process.getConnection())
            {
                try
                {
                    conn.Open();
                    // Parse the selected date to a DateTime object
                    DateTime parsedDate = DateTime.ParseExact(date, "dddd, MMMM dd, yyyy", null);

                    // Update the query to retrieve time in AM/PM format
                    string query = @"
                    SELECT CONVERT(VARCHAR, time, 100) AS FormattedTime
                    FROM Schedule 
                    WHERE CAST(date AS DATE) = @date";

                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@date", parsedDate.Date);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            cbTime.Items.Clear(); // Clear existing items

                            while (reader.Read())
                            {
                                cbTime.Items.Add(reader["FormattedTime"].ToString()); // Add formatted time
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading times: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void cbdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Store the selected date and load corresponding times
            selectedDate = cbdate.SelectedItem?.ToString();
            if (selectedDate != null)
            {
                LoadTimesForDate(selectedDate);
            }
        }

        

        private void cbTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTime = cbTime.SelectedItem?.ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cbdate.SelectedItem == null)
            {
                MessageBox.Show("Please select a date before submitting.");
                return;
            }
            if (cbTime.SelectedItem == null)
            {
                MessageBox.Show("Please select a time before submitting.");
                return;
            }

            Info_Form infoForm = new Info_Form(selectedDate, selectedTime, userID);
            infoForm.Show();
            this.Hide();
        }
    }
}
