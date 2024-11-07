using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.CodeDom;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CLINIC
{
    public partial class ForgotPassword : Form
    {
        public string username;
 
        PROCESSES process = new PROCESSES();
        public ForgotPassword()
        {
            InitializeComponent();
        }

        

        private void LinkLabel_Signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup signup = new Signup();
            signup.Show();
            this.Hide();
        }

        private void LinkLabel_GotoLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string Username = username;
            Login login = new Login(Username);
            login.Show();
            this.Hide();
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {
            
        }

        private void Button_ProceedWithAccount_Click(object sender, EventArgs e)
        {
            string newpass, confirmpass, email, pin;
            email = TextBox_Email.Text;
            pin = TextBox_PinNoAccount.Text;
            newpass = TextBox_Password.Text;
            confirmpass = TextBox_ConfirmPass.Text;
            if (email == "" || pin == "") {
                MessageBox.Show("Input Required Credentials first!!");
                return;
            }

            bool checkaccount = process.ForgotPassword_CheckAccount(email,pin);
            if (checkaccount == true) {
                TextBox_Email.Enabled = false;
                TextBox_PinNoAccount.Enabled = false;
                TextBox_Password.Enabled = true;
                TextBox_ConfirmPass.Enabled = true;
                Button_ConfirmWithAccount.Visible = true;
                Button_ProceedWithAccount.Visible = false;
                MessageBox.Show("Enter New Password!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Button_ConfirmWithAccount_Click(object sender, EventArgs e)
        {
            string pass, conpass, email;
            int pin;
            email = TextBox_Email.Text;
            pin = Convert.ToInt32(TextBox_PinNoAccount.Text);
            pass = TextBox_Password.Text;
            conpass = TextBox_ConfirmPass.Text;
            if (pass != conpass)
            {
                MessageBox.Show("Passwords are not same!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (pass == "" || conpass == "")
            {
                MessageBox.Show("Please Input new Password!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                bool setpasschecker = process.ForgotPassword_SetPassword(email, pin,pass);
                if (setpasschecker == true) {
                    string Username = username;
                    Login login = new Login(Username);
                    login.Show();
                    this.Hide();
                }
            }
        }
    }
}
