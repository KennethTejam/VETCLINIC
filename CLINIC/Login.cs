using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.Design;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Security.Policy;
using System.Diagnostics.Eventing.Reader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace CLINIC
{
    
    public partial class Login : Form
    {
        public string Username;
        public string username;
        SqlConnection conn;
        PROCESSES process = new PROCESSES();
        
        public Login(string Username)
        {
            InitializeComponent();
            username = Username;
            if (username != null && username != "") {
                Homepage homepage = new Homepage(Username);
                homepage.Show();
                this.Hide();
            }
            PROCESSES processes = new PROCESSES();
            conn = processes.getConnection();
        }
        

        private void LinkLabel_Signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup signup = new Signup();
            signup.Show();
            this.Hide();
        }

        private void Button_Login_Click(object sender, EventArgs e)
        {
            
            string username, user_password;
            
                username = TextBox_Email.Text;
                user_password = TextBox_Password.Text;
            
            bool checkacc = process.login_CheckAccount( username, user_password);

            if (checkacc == true) {
                Username = username;
                MessageBox.Show("Success!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Homepage homepage = new Homepage(Username);
                homepage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid login details!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextBox_Email.Clear();
                TextBox_Password.Clear();
                TextBox_Email.Focus();
            }

        }


        public void GetUserInfo()
        {
            string username = TextBox_Email.Text;
            string password = TextBox_Password.Text;
            if (username == "" || password == "")
            {
                Button_Login.Enabled = false;
            }
            else { Button_Login.Enabled = true; }
        }

        private void TextBox_Email_TextChanged(object sender, EventArgs e)
        {
            GetUserInfo();
        }

        private void TextBox_Password_TextChanged(object sender, EventArgs e)
        {
            GetUserInfo();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void LinkLabel_ChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword forgotpassword = new ForgotPassword();
            forgotpassword.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (PictureBox_PasswordViewer.ImageLocation == @"C:\Users\John\Downloads\hide.png")
            {
                PictureBox_PasswordViewer.ImageLocation = @"C:\Users\John\Downloads\view.png";
                TextBox_Password.UseSystemPasswordChar = true;
            }
            else
            {
                PictureBox_PasswordViewer.ImageLocation = @"C:\Users\John\Downloads\hide.png";
                TextBox_Password.UseSystemPasswordChar = false;
            }
        }
    }
}       
