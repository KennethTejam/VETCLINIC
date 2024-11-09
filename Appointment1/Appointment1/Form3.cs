using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Appointment1
{
    public partial class Summary_Form : Form
    {
        private string selectedDate; // Store the date received from the previous form
        private string selectedTime;  // Store the time selected from the ComboBox
        private int userID; // Store user ID if needed
        private string userNote; // Variable to store the user's note

        PROCESSES process = new PROCESSES();
        SqlConnection conn;

        public Summary_Form(string selectedDate, string selectedTime, int userID, string userNote)
        {
            this.selectedDate = selectedDate;
            this.selectedTime = selectedTime;
            this.userID = userID;
            this.userNote = userNote;
            conn = process.getConnection();
            InitializeComponent();

            // Display the respective variables in the TextBoxes
            txtNote.Text = userNote;                 // Show the user's note
            txtDate.Text = selectedDate;             // Show the selected date
            txtTime.Text = selectedTime;             // Show the selected time
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            InsertAppointment();
        }

        private void InsertAppointment()
        {
            DateTime date;
            string formattedDate = string.Empty; // Initialize to avoid scope issues
            string formattedTime = string.Empty;  // Initialize to avoid scope issues

            // Try to parse the selected date
            if (DateTime.TryParse(selectedDate, out date))
            {
                formattedDate = date.ToString("MM-dd-yyyy"); // Format the date

                // Try to parse the selected time
                DateTime time;
                if (DateTime.TryParse(selectedTime, out time))
                {
                    formattedTime = time.ToString("HH:mm"); // Military time format

                    // Display the selected date and time in a message box
                   

                   
                    {
                        // SQL query to insert a new appointment
                        string query = "INSERT INTO appointment (userID, note, appdate, apptime) VALUES (@userID, @note, @appdate, @apptime)";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            // Set parameter values
                            cmd.Parameters.AddWithValue("@userID", userID);
                            cmd.Parameters.AddWithValue("@note", userNote);
                            cmd.Parameters.AddWithValue("@appdate", formattedDate); // Use formatted string
                            cmd.Parameters.AddWithValue("@apptime", formattedTime); // Use formatted string

                            try
                            {
                                conn.Open();
                                cmd.ExecuteNonQuery(); // Execute the insert command
                                MessageBox.Show("Appointment confirmed successfully!");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error saving appointment: " + ex.Message);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Error: Invalid time format.");
                }
            }
            else
            {
                MessageBox.Show("Error: Invalid date format.");
            }
        }
    }
}
