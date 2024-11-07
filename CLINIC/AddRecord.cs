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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CLINIC
{
    public partial class AddRecord : Form
    {
        public string username, conta;
        SqlConnection conn;
        public AddRecord(string Username)
        {
            InitializeComponent();
            username = Username;
            Username = username;

            Label_AddRecord.BackColor = Color.LightSkyBlue;


            if (username == "")
            {
                this.Hide();
                Login login = new Login(Username);
                login.Show();
            }
            else
            {
                Label_Username.Text = username;

            }
            PROCESSES processes = new PROCESSES();
            conn = processes.getConnection();
            ContextMenuStrip contextMenu = new ContextMenuStrip();


            ToolStripMenuItem changepass = new ToolStripMenuItem("Manage Account");
            ToolStripMenuItem logoutItem = new ToolStripMenuItem("Logout");

            contextMenu.Font = new Font("Arial", 15, FontStyle.Bold);


            contextMenu.Items.Add(changepass);
            contextMenu.Items.Add(logoutItem);

            changepass.Click += (sender, e) =>
            {
                ManageAccount changepass = new ManageAccount(Username);
                changepass.Show();
                this.Hide();
            };

            logoutItem.Click += (sender, e) =>
            {
                username = "";
                Username = username;
                Homepage homepage = new Homepage(Username);
                this.Hide();
            };
            Label_ManageAccount.ContextMenuStrip = contextMenu;


            Label_ManageAccount.MouseEnter += (sender, e) =>
            {
                contextMenu.Show(Label_ManageAccount, Label_ManageAccount.PointToClient(Cursor.Position));
            };
        }

        private void Label_Homepage_Click(object sender, EventArgs e)
        {
            string Username = username;
            Homepage homepage = new Homepage(Username);
            homepage.Show();
            this.Hide();
        }

        private void Label_Appointment_Click(object sender, EventArgs e)
        {
            string Username = username;
            RecordHistory history = new RecordHistory(Username);
            history.Show();
            this.Hide();
        }

        private void TextBox_PetName_TextChanged(object sender, EventArgs e)
        {
            GetUserInfo();
        }

        private void TextBox_Breed_TextChanged(object sender, EventArgs e)
        {
            GetUserInfo();
        }

        private void TextBox_Gender_TextChanged(object sender, EventArgs e)
        {
            GetUserInfo();
        }

        private void TextBox_Birthday_TextChanged(object sender, EventArgs e)
        {
            GetUserInfo();
        }

        private void TextBox_Owner_TextChanged(object sender, EventArgs e)
        {
            GetUserInfo();
        }

        private void TextBox_ContactNumber_TextChanged(object sender, EventArgs e)
        {
            GetUserInfo();
        }

        private void TextBox_Email_TextChanged(object sender, EventArgs e)
        {
            GetUserInfo();
        }

        private void TextBox_Note_TextChanged(object sender, EventArgs e)
        {
            GetUserInfo();
        }
        public void GetUserInfo()
        {
            string petname, breed, petgender, petbday, owner, contactnum, email, mednote;
            petname = TextBox_PetName.Text;
            petbday = TextBox_Breed.Text;
            owner = TextBox_Owner.Text;
            contactnum = "639" + TextBox_ContactNumber.Text;
            conta = "639" + TextBox_ContactNumber.Text;
            email = TextBox_Email.Text;
            mednote = TextBox_Note.Text;

            if (petname == "" || petbday == ""  || owner == "" || contactnum == "" || email == "" || mednote == "")
            {
                Button_AddToRecord.Enabled = false;
            }
            else
            {
                Button_AddToRecord.Enabled = true;
            }
        }

        private void Button_AddToRecord_Click(object sender, EventArgs e)
        {
            MessageBox.Show(conta+ "");
        }
    }
}
