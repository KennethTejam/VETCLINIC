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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Appointment1
{
    public partial class frmVetHP : Form
    {  

        PROCESSES process = new PROCESSES();
        SqlConnection conn;
        int userid = 1;
        public frmVetHP()
        {
            InitializeComponent();
            conn = process.getConnection();
            LoadPendingAppointments();
            
        }

        private void LoadPendingAppointments()
        {

            string query = @"
                SELECT appID, pname AS PetName, oname AS OwnerName, 
                       CONVERT(VARCHAR, apptime, 100) AS AppointmentTime
                FROM Appointments  
                WHERE status = 'Pending' AND userid = @userid AND CAST(appdate AS DATE) = CAST(GETDATE() AS DATE)";

          
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@userid", userid);
                    SqlDataReader reader = cmd.ExecuteReader();

                    int i = 0;
                    while (reader.Read())
                    {
                   
                        Label lblAppointment = new Label();

                    
                        lblAppointment.Text = $"Pet: {reader["PetName"]}\nOwner: {reader["OwnerName"]}\nTime: {reader["AppointmentTime"]}";

                        lblAppointment.AutoSize = true; 
                        lblAppointment.Location = new Point(10, 10 + (i * 90)); 

                        
                        int appID = Convert.ToInt32(reader["appID"]);  
                        lblAppointment.Click += (sender, e) => OpenPatientInfoForm(appID);

                        
                        pAppointment.Controls.Add(lblAppointment);

                        i++;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading appointments: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void OpenPatientInfoForm(int appID)
        {
         

           
            frmAppointments patientInfoForm = new frmAppointments(appID);
            patientInfoForm.Show(); 
        }

    }
}
