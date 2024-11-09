using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Appointment1
{
    public partial class frmFollowUp : Form
    {
        PROCESSES process = new PROCESSES();
        SqlConnection conn;
        private int appID;
        private string ownerName, petName, breed, gender, contactNo, email, status;
        private DateTime birthday;
        private string medNote;



        public frmFollowUp(int appID, string ownerName, string petName, string breed, DateTime birthday, string gender, string contactNo, string email, string status)
        {
            InitializeComponent();
            this.appID = appID;
            this.ownerName = ownerName;
            this.petName = petName;
            this.breed = breed;
            this.birthday = birthday;
            this.gender = gender;
            this.contactNo = contactNo;
            this.email = email;
            this.status = status;
            conn = process.getConnection();
            txtMedNote.Visible = false;

          
            this.rbNoF.CheckedChanged += new System.EventHandler(this.rbNoF_CheckedChanged);
            this.rb1m.CheckedChanged += new System.EventHandler(this.rb1m_CheckedChanged);
            this.rb3m.CheckedChanged += new System.EventHandler(this.rb3m_CheckedChanged);
            this.rb6m.CheckedChanged += new System.EventHandler(this.rb6m_CheckedChanged);

        
            this.txtDate.TextChanged += new System.EventHandler(this.txtDate_TextChanged);
        }

     
        private void txtDate_TextChanged(object sender, EventArgs e)
        {
            string dateInput = txtDate.Text.Trim();

          
            string[] dateFormats = { "MM/dd/yyyy", "M/d/yyyy" };

            DateTime selectedDate;
            bool isValidDate = DateTime.TryParseExact(dateInput, dateFormats, null, System.Globalization.DateTimeStyles.None, out selectedDate);

          
            if (isValidDate && selectedDate >= DateTime.Now.Date)
            {
                txtMedNote.Visible = true;  
            }
            else
            {
                txtMedNote.Visible = false; 
            }

        
            cbTime.Items.Clear();
            cbTime.Text = "";  
        }


       


      
        private void rbNoF_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNoF.Checked)
            {
                txtDate.Text = ""; 
                cbTime.Items.Clear(); 
                cbTime.Text = ""; 
            }
        }

        
        private void rb1m_CheckedChanged(object sender, EventArgs e)
        {
            if (rb1m.Checked)
            {
                DateTime currentDate = DateTime.Now.AddMonths(1);
                if (currentDate.DayOfWeek == DayOfWeek.Sunday)
                {
                    currentDate = currentDate.AddDays(1); 
                }
                txtDate.Text = currentDate.ToString("MM/dd/yyyy"); 

                cbTime.Items.Clear();
                cbTime.Text = "";
            }
        }

        
        private void rb3m_CheckedChanged(object sender, EventArgs e)
        {
            if (rb3m.Checked)
            {
                DateTime currentDate = DateTime.Now.AddMonths(3);
                if (currentDate.DayOfWeek == DayOfWeek.Sunday)
                {
                    currentDate = currentDate.AddDays(1); 
                }
                txtDate.Text = currentDate.ToString("MM/dd/yyyy"); 

              
                cbTime.Items.Clear();
                cbTime.Text = "";
            }
        }

        private void rb6m_CheckedChanged(object sender, EventArgs e)
        {
            if (rb6m.Checked)
            {
                DateTime currentDate = DateTime.Now.AddMonths(6);
                if (currentDate.DayOfWeek == DayOfWeek.Sunday)
                {
                    currentDate = currentDate.AddDays(1); 
                }
                txtDate.Text = currentDate.ToString("MM/dd/yyyy");

              
                cbTime.Items.Clear();
                cbTime.Text = "";
            }
        }

        private void btnGetTimes_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Date in txtDate: " + txtDate.Text);

         
            string dateInput = txtDate.Text.Trim();

            
            if (string.IsNullOrEmpty(dateInput))
            {
                MessageBox.Show("Please enter a date.", "Date Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            string[] dateFormats = { "MM/dd/yyyy", "M/d/yyyy" };

            DateTime selectedDate;
            bool isValidDate = DateTime.TryParseExact(dateInput, dateFormats, null, System.Globalization.DateTimeStyles.None, out selectedDate);

      
            if (isValidDate && selectedDate >= DateTime.Now.Date)
            {
                
                cbTime.Items.Clear();

                cbTime.Items.Add("7:30AM");
                cbTime.Items.Add("9:00AM");
                cbTime.Items.Add("10:30AM");
                cbTime.Items.Add("12:00PM");
                cbTime.Items.Add("1:30PM");
                cbTime.Items.Add("3:00PM");

                
                RemoveOccupiedTimes(selectedDate);

            
                cbTime.SelectedIndex = 0;
            }
            else
            {
                
                cbTime.Items.Clear();
                MessageBox.Show("Please enter a valid date that is not in the past.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RemoveOccupiedTimes(DateTime selectedDate)
        {
         
            string query = "SELECT CONVERT(VARCHAR, apptime, 100) AS apptime FROM appointments WHERE appdate = @date";

        
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@date", selectedDate.Date);  

            try
            {
                
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string existingTime = reader["apptime"].ToString();

                    for (int i = cbTime.Items.Count - 1; i >= 0; i--)
                    {
                        if (cbTime.Items[i].ToString() == existingTime)
                        {
                            cbTime.Items.RemoveAt(i);
                        }
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching appointment times: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtMedNote.Visible)
            {
                medNote = txtMedNote.Text.Trim(); 
            }
            else
            {
                medNote = string.Empty; 
            }
            
            string dateInput = txtDate.Text.Trim();
            if (!string.IsNullOrEmpty(dateInput))
            {
               
                if (string.IsNullOrEmpty(cbTime.Text))
                {
                    MessageBox.Show("Please select a time.", "Time Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }

                
                UpdateAppointmentStatus("Done");

                InsertMedNote();
            }
            else
            {
      
                UpdateAppointmentStatus("Done");

                InsertMedNote();
            }
        }

        private void UpdateAppointmentStatus(string status)
        {
            string updateQuery = "UPDATE appointments SET status = @status WHERE appID = @appID";
            SqlCommand cmd = new SqlCommand(updateQuery, conn);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@appID", appID);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();  
                MessageBox.Show("Appointment status updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating appointment status: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        
        private void InsertMedNote()
        {
            DateTime? appDate = null; 

           
            if (!string.IsNullOrEmpty(txtDate.Text.Trim()))
            {
                try
                {
                    
                    appDate = DateTime.ParseExact(txtDate.Text.Trim(), "MM/dd/yyyy", null);
                }
                catch (FormatException ex)
                {
                    
                    MessageBox.Show("Invalid date format. Please enter the date in MM/dd/yyyy format.", "Date Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
                }
            }

            string appTime = cbTime.Text.Trim(); 

            string insertQuery = "INSERT INTO appointments (oname, pName, breed, gender, contactNo, email, appDate, appTime, birthday, status, medNote) " +
                                 "VALUES (@ownerName, @petName, @breed, @gender, @contactNo, @email, @appDate, @appTime, @birthday, @status, @medNote)";

            SqlCommand cmd = new SqlCommand(insertQuery, conn);

            cmd.Parameters.AddWithValue("@ownerName", ownerName);
            cmd.Parameters.AddWithValue("@petName", petName);
            cmd.Parameters.AddWithValue("@breed", breed);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@contactNo", contactNo);
            cmd.Parameters.AddWithValue("@email", email);

            
            cmd.Parameters.AddWithValue("@appDate", (object)appDate ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@appTime", appTime); 
            cmd.Parameters.AddWithValue("@birthday", birthday);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@medNote", medNote); 

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();  
                MessageBox.Show("MedNote record inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting mednote record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }




    }
}
