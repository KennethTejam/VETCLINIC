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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;


namespace CLINIC
{
    public partial class Signup : Form
    {

        PROCESSES process = new PROCESSES();
        public Signup()
        {
            InitializeComponent();
        }

        private void linkLabel_Signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string Username = null;
            Login login = new Login(Username);
            login.Show();
            this.Hide();
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void Button_Signin_Click(object sender, EventArgs e)
        {
            string fname, mname, lname, email, position, pass, conpass, pin;
            if (RadioButton_Male.Checked) { position = "Clinic Veterinarian"; }
            else { position = "Clinic Staff"; }
            fname = TextBox_Fname.Text;
            mname = TextBox_Mname.Text;
            lname = TextBox_Lname.Text;
            email = TextBox_Email.Text;
            pass = TextBox_Password.Text;
            conpass = TextBox_ConfirmPass.Text;
            pin = TextBox_Pin.Text;
            if (pass != conpass)
            {
                Button_Signin.Enabled = false;
                MessageBox.Show("Passwords Are Not The Same!");
                return;
            }
            ///
            ///
            ///
            int checker = process.Signup_AccChecker(email);
            if (checker > 0) {
                MessageBox.Show("The Email already has an account!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ///
            ///
            ///
            process.Signup_AddToDatabase(fname, lname, mname,position, email, pass, conpass, pin);
            this.Hide();
        }


        public void getValues()
        {
            string fname, mname, lname, email, position, pass, conpass, pin;
            position = "";
            if (RadioButton_Male.Checked) { position = "Vet"; }
            else if (RadioButton_Female.Checked) { position = "Staff"; }
            else { position = ""; }

            fname = TextBox_Fname.Text.ToLower();
            mname = TextBox_Mname.Text.ToLower();
            lname = TextBox_Lname.Text.ToLower();
            email = TextBox_Email.Text.ToLower();
            pin = TextBox_Pin.Text.ToLower();
            pass = TextBox_Password.Text;
            conpass = TextBox_ConfirmPass.Text;
            Checker(fname, mname, lname, email, position, pass, conpass, pin);
        }


        public void Checker(string fname, string mname, string lname, string email, string position, string pass, string conpass, string pin)
        {

            if (pass == "" || conpass == "" || fname == "" || mname == "" || lname == "" || email == "" || position == "" || pin == "")
            {
                Button_Signin.Enabled = false;
            }
            else
            {
                Button_Signin.Enabled = true;
            }
        }

        private void TextBox_Fname_TextChanged(object sender, EventArgs e)
        {
            getValues();
        }

        private void TextBox_Mname_TextChanged(object sender, EventArgs e)
        {
            getValues();
        }

        private void TextBox_Lname_TextChanged(object sender, EventArgs e)
        {
            getValues();
        }

        private void TextBox_Email_TextChanged(object sender, EventArgs e)
        {
            getValues();
        }

        private void TextBox_Password_TextChanged(object sender, EventArgs e)
        {
            getValues();
        }

        private void TextBox_ConfirmPass_TextChanged(object sender, EventArgs e)
        {
            getValues();
        }

        private void TextBox_Pin_TextChanged(object sender, EventArgs e)
        {
            getValues();
            int length = TextBox_Pin.Text.Length;
            string text = TextBox_Pin.Text;
            if (length > 6)
            {
                MessageBox.Show("Six (6) Digits only!!");
                TextBox_Pin.Text = text.Substring(0, 6);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureBox2.ImageLocation == @"C:\Users\John\Downloads\hide.png")
            {
                pictureBox2.ImageLocation = @"C:\Users\John\Downloads\view.png";
                TextBox_Password.UseSystemPasswordChar = true;
            }
            else
            {
                pictureBox2.ImageLocation = @"C:\Users\John\Downloads\hide.png";
                TextBox_Password.UseSystemPasswordChar = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.ImageLocation == @"C:\Users\John\Downloads\hide.png")
            {
                pictureBox1.ImageLocation = @"C:\Users\John\Downloads\view.png";
                TextBox_ConfirmPass.UseSystemPasswordChar = true;
            }
            else
            {
                pictureBox1.ImageLocation = @"C:\Users\John\Downloads\hide.png";
                TextBox_ConfirmPass.UseSystemPasswordChar = false;
            }
        }

        private void PictureBox_PasswordViewer_Click(object sender, EventArgs e)
        {
            if (PictureBox_PasswordViewer.ImageLocation == @"C:\Users\John\Downloads\hide.png")
            {
                PictureBox_PasswordViewer.ImageLocation = @"C:\Users\John\Downloads\view.png";
                TextBox_Pin.UseSystemPasswordChar = true;
            }
            else
            {
                PictureBox_PasswordViewer.ImageLocation = @"C:\Users\John\Downloads\hide.png";
                TextBox_Pin.UseSystemPasswordChar = false;
            }
        }

        private void RadioButton_Male_CheckedChanged(object sender, EventArgs e)
        {
            getValues();
        }

        private void RadioButton_Female_CheckedChanged(object sender, EventArgs e)
        {
            getValues();
        }
    }

}
