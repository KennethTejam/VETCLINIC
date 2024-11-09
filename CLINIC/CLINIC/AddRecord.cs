using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CLINIC
{
    public partial class AddRecord : Form
    {
        public string username;
        public int userid;
        SqlConnection conn;
        PROCESSES process = new PROCESSES();
        ContextMenuStrip contextMenu = new ContextMenuStrip();

        public AddRecord(int userid)
        {
            InitializeComponent();
            this.userid = userid;

            Label_AddRecord.BackColor = Color.LightSkyBlue;
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
            AddRecord_ShowVets();
            showContextMenu();
        }
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////

        public void showContextMenu()
        {
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
                userid = -1;
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
        public void AddRecord_ShowVets()
        {
            string query = "SELECT * FROM userinfo WHERE position = 'Vet'";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                
                while (reader.Read())
                {
                    int userid = Convert.ToInt32($"{reader["userid"]}");
                    string fullname = $"DOC. {reader["fname"]} {reader["mname"]} {reader["lname"]}";
                    comboBox1.Items.Add(fullname);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading appointments: " + ex.Message);
            }
            finally {
                conn.Close();
            }
        }
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        ///
        public void GetUserInfo()
        {
            string petname, breed, petgender, owner, contactnum, email, mednote, status;
            if (RadioButton_Male.Checked) { petgender = "Male"; }
            else if (RadioButton_Female.Checked) { petgender = "Female"; }
            else { petgender = ""; }
            DateTime petbday = dateTimePicker1.Value;
            petname = TextBox_PetName.Text;
            breed = TextBox_Breed.Text;
            owner = TextBox_Owner.Text;
            contactnum = "639" + TextBox_ContactNumber.Text;
            email = TextBox_Email.Text;
            mednote = TextBox_Note.Text;
            status = "Pending";

            if (userid <= 0 || petname == "" || breed == "" || petgender == "" || petbday == DateTime.MinValue || owner == "" || contactnum == "" || email == "" || mednote == "" || status == "")
            {
                Button_AddToRecord.Enabled = false;
            }
            else
            {
                Button_AddToRecord.Enabled = true;
            }
        }
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        private void Button_AddToRecord_Click(object sender, EventArgs e)
        {
            string petname, breed, petgender, owner, contactnum, email, mednote, status;
            if (RadioButton_Male.Checked) { petgender = "Male"; }
            else if (RadioButton_Female.Checked) { petgender = "Female"; }
            else { petgender = ""; }
            DateTime petbday = dateTimePicker1.Value.Date;
            DateTime now = DateTime.Now.Date;
            if (petbday == now)
            {
                MessageBox.Show("Please Choose A Valid Birthdate!!");
                return;
            }
            petname = TextBox_PetName.Text;
            breed = TextBox_Breed.Text;
            owner = TextBox_Owner.Text;
            contactnum = TextBox_ContactNumber.Text;
            email = TextBox_Email.Text;
            mednote = TextBox_Note.Text;
            status = "Pending";
            int counter = process.AddRecord_CheckDatabase(petname, owner, email);
            if (counter != 0) { MessageBox.Show("The Patient has already been scheduled for the day!!!"); }
            else
            {
                process.AddRecord_AddToDatabase(petname, petbday, breed, petgender, owner, contactnum, email, mednote, status, userid);
            }
        }
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = comboBox1.Text;
            int spaceIndex = name.IndexOf(' ');
            name = name.Substring(spaceIndex + 1);
             userid = process.getUserID(name);
            GetUserInfo();
        }
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            GetUserInfo();
        }
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            GetUserInfo();
        }
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime selecteddate = dateTimePicker1.Value.Date;
            DateTime now = DateTime.Now.Date;
            
            if (selecteddate == now) {
                MessageBox.Show("Please Choose A Valid Birthdate!!");
                return;
            }
            GetUserInfo();
        }
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        private void Label_Homepage_Click(object sender, EventArgs e)
        {
            string Username = username;
            Homepage homepage = new Homepage(userid);
            homepage.Show();
            this.Hide();
        }
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        private void Label_Appointment_Click(object sender, EventArgs e)
        {
            string Username = username;
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
        private void TextBox_PetName_TextChanged(object sender, EventArgs e)
        {
            GetUserInfo();
        }
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        private void TextBox_Breed_TextChanged(object sender, EventArgs e)
        {
            GetUserInfo();
        }
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        private void TextBox_Owner_TextChanged(object sender, EventArgs e)
        {
            GetUserInfo();
        }
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        private void TextBox_ContactNumber_TextChanged(object sender, EventArgs e)
        {
            GetUserInfo();
        }
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        private void TextBox_Email_TextChanged(object sender, EventArgs e)
        {
            GetUserInfo();
        }
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        private void TextBox_Note_TextChanged(object sender, EventArgs e)
        {
            GetUserInfo();
        }
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
    }
}
