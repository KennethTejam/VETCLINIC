using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLINIC
{
    public partial class PatientInfoForm : Form
    {
        public PatientInfoForm(int appID)
        {
            this.appID = appID;
            InitializeComponent();
            FetchAndDisplayAppointments();
        }
        private int appID;  // Store appID to fetch the pet's record from the database
        private string connString = "Data Source=DESKTOP-MSA24LI\\SQLEXPRESS;Initial Catalog=CLINIC_DB;Integrated Security=True;";

        // Constructor accepts appID to load the pet's record

        // Fetch and display appointments
        private void FetchAndDisplayAppointments()
        {
            FetchAndAssignAppointmentDetails();
        }

        public void FetchAndAssignAppointmentDetails()
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                string query = "SELECT oname, pname, breed, birthday, gender, contactNo, email, FORMAT(appointmentDate, 'dddd, MMMM dd, yyyy') AS appDate ,CONVERT(VARCHAR, appointmentTime, 100) AS appTime, status FROM appointments WHERE appID = @appID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@appID", appID);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Fetch individual columns from the database
                        string ownerName = reader["oname"]?.ToString() ?? "N/A";
                        string petName = reader["pname"]?.ToString() ?? "N/A";
                        string breed = reader["breed"]?.ToString() ?? "N/A";
                        DateTime birthday = reader["birthday"] != DBNull.Value ? Convert.ToDateTime(reader["birthday"]) : DateTime.MinValue;
                        string gender = reader["gender"]?.ToString() ?? "N/A";
                        string contactNo = reader["contactNo"]?.ToString() ?? "N/A";
                        string email = reader["email"]?.ToString() ?? "N/A";
                        string appDate = reader["appDate"]?.ToString() ?? "N/A";
                        string appTime = reader["apptime"]?.ToString() ?? "N/A";
                        string status = reader["status"]?.ToString() ?? "N/A";

                        // Calculate age from birthday
                        int age = CalculateAge(birthday);

                        // Assign values to labels
                        TextBox_OwnerName.Text = $"Owner: {ownerName}";
                        TextBox_PetName.Text = $"Pet: {petName}";
                        TextBox_PetBreed.Text = $"Breed: {breed}";
                        TextBox_Age.Text = $"Age: {age}";
                        TextBox_Gender.Text = $"Gender: {gender}";
                        TextBox_Contact.Text = $"Contact: {contactNo}";
                        TextBox_Email.Text = $"Email: {email}";
                        TextBox_AppointmentDate.Text = $"Appointment Date: {appDate}";
                        TextBox_AppointmentTime.Text = $"Appointment Time: {appTime}";
                        TextBox_Status.Text = $"Appointment Time: {status}";
                    }
                    else
                    {
                        MessageBox.Show("No records found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching appointment details: " + ex.Message);
                }
            }
        }

        // Method to calculate age from the birthday
        private int CalculateAge(DateTime birthday)
        {
            int age = DateTime.Now.Year - birthday.Year;
            if (DateTime.Now.DayOfYear < birthday.DayOfYear)
            {
                age--;
            }
            return age;
        }
    }
}
