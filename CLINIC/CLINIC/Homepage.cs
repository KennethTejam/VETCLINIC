using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace CLINIC
{
    public partial class Homepage : Form
    {
        public int userid;
        ContextMenuStrip contextMenu = new ContextMenuStrip();
        SqlConnection conn;
        PROCESSES process = new PROCESSES();
        public Homepage(int userid)
        {
            InitializeComponent();
            this.userid = userid;
            Label_Homepage.BackColor = Color.LightSkyBlue;
            string useremail = process.getUserEmail(userid);
            if (userid < 0)
            {
                this.Hide();
                Login login = new Login(userid);
                login.Show();
            }
            else
            {
                Label_Username.Text = useremail;

            }
            
            conn = process.getConnection();
            showContextMenu();
        }
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        public void showContextMenu() {
            ToolStripMenuItem changepass = new ToolStripMenuItem("Manage Account");
            ToolStripMenuItem logoutItem = new ToolStripMenuItem("Logout");
            contextMenu.Font = new Font("Arial", 15, FontStyle.Bold);
            contextMenu.Items.Add(changepass);
            contextMenu.Items.Add(logoutItem);
            changepass.Click += (sender, e) =>
            {
                ManageAccount changepass = new ManageAccount(userid);
                changepass.Show();
                this.Hide();
            };
            logoutItem.Click += (sender, e) =>
            {
                Homepage homepage = new Homepage(userid);
                this.Hide();
            };
            Label_ManageAccount.ContextMenuStrip = contextMenu;
            Label_ManageAccount.MouseEnter += (sender, e) =>
            {
                contextMenu.Show(Label_ManageAccount, Label_ManageAccount.PointToClient(Cursor.Position));
            };
        }
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        private void label1_Click(object sender, EventArgs e)
        {
            AddRecord addrecord = new AddRecord(userid);
            addrecord.Show();
            this.Hide();

        }
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        private void LoadPendingAppointments(string query)
        {
            DateTime dateandtime = monthCalendar1.SelectionRange.Start;
            try
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@dateandtime", dateandtime);

                    SqlDataReader reader = cmd.ExecuteReader();

                    int i = 0;
                    while (reader.Read())
                    {
                        Label lblAppointment = new Label();
                        lblAppointment.Text = $"Pet: {reader["PetName"]}\nOwner: {reader["OwnerName"]}\nTime: {reader["AppointmentTime"]}";

                        lblAppointment.AutoSize = true;
                        lblAppointment.Location = new Point(10, 10 + (i * 90));
                        lblAppointment.Font = new Font("Segoe UI", 15.75f, FontStyle.Bold);
                        int appID = Convert.ToInt32(reader["appID"]);
                        lblAppointment.Click += (sender, e) => OpenPatientInfoForm(appID);
                        
                        panel1.Controls.Add(lblAppointment);
                        i++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading appointments: " + ex.Message);
            }
            finally { conn.Close(); }
        }
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        private void OpenPatientInfoForm(int appID)
        {
            PatientInfoForm patientInfoForm = new PatientInfoForm(appID);
            patientInfoForm.Show();
        }
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        private void Label_History_Click(object sender, EventArgs e)
        {
            int userid = this.userid;
            RecordHistory history = new RecordHistory(userid);
            history.Show();
            this.Hide();
        }
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            panel1.Controls.Clear();
            string query = @"
                SELECT appID, pname AS PetName, oname AS OwnerName, 
                       CONVERT(VARCHAR, appointmentTime, 100) AS AppointmentTime
                FROM Appointments  
                WHERE appointmentDate = @dateandtime AND status = 'Pending'";
            LoadPendingAppointments(query);
            
        }
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
    }
}   

