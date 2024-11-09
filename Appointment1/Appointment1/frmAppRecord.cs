using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Appointment1
{
    public partial class frmAppRecord : Form
    {
        private int appID;  
        PROCESSES process = new PROCESSES();
        SqlConnection conn;
        public frmAppRecord(int appID)
        {
            this.appID = appID;
         
            InitializeComponent();
            conn = process.getConnection();
            FetchAndDisplayAppointments();
            
        }

       
        private void FetchAndDisplayAppointments()
        {
            FetchAndAssignAppointmentDetails();
        }

        public void FetchAndAssignAppointmentDetails()
        {
           
            {
                string query = "SELECT oname, pname, breed, birthday, gender, contactNo, email, FORMAT(appdate, 'dddd, MMMM dd, yyyy') AS appDate ,CONVERT(VARCHAR, apptime, 100) AS appTime, status FROM appointments WHERE appID = @appID";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@appID", appID);

                try
                {
                    conn.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        
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

                       
                        int age = CalculateAge(birthday);

                    
                        txtOwnerName.Text = $"{ownerName}";
                        txtPetName.Text = $"{petName}";
                        txtPetBreed.Text = $"{breed}";
                        txtAge.Text = $"{age}";
                        txtGender.Text = $"{gender}";
                        txtContact.Text = $"{contactNo}";
                        txtEmail.Text = $"{email}";
                        txtAppointmentDate.Text = $"{appDate}";
                        txtAppointmentTime.Text = $"{appTime}";
                        txtStatus.Text = $"{status}";
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
                finally
                {
                    conn.Close();
                }
            }
        }

    
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
