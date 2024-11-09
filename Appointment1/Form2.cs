using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Appointment1
{
    public partial class Info_Form : Form
    {
        private string selectedDate; // Store the date received from the previous form
        private string selectedTime;  // Store the time selected from the ComboBox
        private int userID; // Store user ID if needed
        private string userNote; // Variable to store the user's note

        SqlConnection conn;

        PROCESSES process = new PROCESSES();  

        // Constructor that accepts a date, time, and userID parameter
        public Info_Form(string selectedDate, string selectedTime, int userID)
        {
            InitializeComponent();
            this.selectedDate = selectedDate; // Set the received date
            this.selectedTime = selectedTime; // Set the initially selected time
            this.userID = userID; // Assign userID from parameter
            conn = process.getConnection();
            LoadUserInfo(); // Load user information when the form is initialized
        }

        private void LoadUserInfo()
        {
        
            {
                string query = "SELECT lname, fname, mname, email, contact, gender, birthday FROM userinfo WHERE userID = @userID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userID", userID);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        // Populate text boxes with the retrieved data
                        txtLname.Text = reader["lname"].ToString();
                        txtFname.Text = reader["fname"].ToString();
                        txtMname.Text = reader["mname"].ToString();
                        txtEmail.Text = reader["email"].ToString();
                        txtContact.Text = reader["contact"].ToString();
                        txtGender.Text = reader["gender"].ToString();
                        txtBirthday.Text = Convert.ToDateTime(reader["birthday"]).ToString("yyyy-MM-dd"); // Format as needed
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving user information: " + ex.Message);
                }
            }
        }

        // Method to save the note to a variable
        private void SaveUserNote()
        {
            userNote = txtNote.Text; // Get the text from txtNote
            MessageBox.Show("Note saved to variable.");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            userNote = txtNote.Text;

            Summary_Form sumForm = new Summary_Form(selectedDate, selectedTime, userID, userNote);
            sumForm.Show();
            this.Hide();
        }
    }
}
