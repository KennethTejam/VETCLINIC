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
    public partial class frmDone : Form
    {
        PROCESSES process = new PROCESSES();
        SqlConnection conn;
        public frmDone()
        {
            InitializeComponent();
            conn = process.getConnection();

    
            cbSort.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSort.Items.Add("Date ↑");
            cbSort.Items.Add("Date ↓");
            cbSort.SelectedIndex = 0;
            txtSearch.PlaceholderText = "Enter name";

            
            LoadDoneAppointments();

            
            cbSort.SelectedIndexChanged += (sender, e) => LoadDoneAppointments();
            txtSearch.TextChanged += (sender, e) => LoadDoneAppointments();
        }

        private void LoadDoneAppointments()
            {
                
                string query = @"
                SELECT appID, pname AS PetName, oname AS OwnerName, 
                       CONVERT(VARCHAR, apptime, 100) AS AppointmentTime
                FROM Appointments  
                WHERE status = 'Done'";


            
            string searchText = txtSearch.Text.Trim();

           
            if (!string.IsNullOrEmpty(searchText))
            {
                query += " AND (pname LIKE @searchText OR oname LIKE @searchText)";
            }

          
            if (cbSort.SelectedItem.ToString() == "Date ↓")
            {
                query += " ORDER BY apptime DESC";
            }
            else 
            {
                query += " ORDER BY apptime ASC";
            }

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);

               
                if (!string.IsNullOrEmpty(searchText))
                {
                    cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                }

                SqlDataReader reader = cmd.ExecuteReader();
                pAppointment.Controls.Clear(); // Clear previous appointments

                int i = 0;
                while (reader.Read())
                {
                    Label lblAppointment = new Label
                    {
                        Text = $"Pet: {reader["PetName"]}\nOwner: {reader["OwnerName"]}\nTime: {reader["AppointmentTime"]}",
                        AutoSize = true,
                        Location = new Point(10, 10 + (i * 90))
                    };

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

        private void OpenPatientInfoForm(int appID)
            {
            


                frmAppRecord patientInfoForm = new frmAppRecord(appID);
                patientInfoForm.Show(); 
            }
            private void lblPending_Click(object sender, EventArgs e)
        {
            frmPending pending = new frmPending();
            pending.Show();
            this.Hide();
        }
    }
}
