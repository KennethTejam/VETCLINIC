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

namespace Appointment1
{
    public partial class frmAppointments : Form
    {
        private int appID;  
        PROCESSES process = new PROCESSES();
        SqlConnection conn;
        string ownerName;
        string petName;
        string breed;
        DateTime birthday;
        string gender;
        string contactNo;
        string email;
        string appDate;
        string appTime;
        string status;
        public frmAppointments(int appID)
        {

            InitializeComponent();
            this.appID = appID;
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
                      
                        ownerName = reader["oname"]?.ToString() ?? "N/A";
                        petName = reader["pname"]?.ToString() ?? "N/A";
                        breed = reader["breed"]?.ToString() ?? "N/A";
                        birthday = reader["birthday"] != DBNull.Value ? Convert.ToDateTime(reader["birthday"]) : DateTime.MinValue;
                        gender = reader["gender"]?.ToString() ?? "N/A";
                        contactNo = reader["contactNo"]?.ToString() ?? "N/A";
                        email = reader["email"]?.ToString() ?? "N/A";
                        appDate = reader["appDate"]?.ToString() ?? "N/A";
                        appTime = reader["apptime"]?.ToString() ?? "N/A";
                        status = reader["status"]?.ToString() ?? "N/A";

                      
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

        private void btnNext_Click(object sender, EventArgs e)
        {

            
            frmFollowUp patientInfoForm = new frmFollowUp(appID, ownerName, petName, breed, birthday, gender, contactNo, email, status);
            patientInfoForm.Show();
            this.Hide();
        }

    }
}


