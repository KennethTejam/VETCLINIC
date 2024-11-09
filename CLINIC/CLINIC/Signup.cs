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
using Microsoft.VisualBasic.ApplicationServices;


namespace CLINIC
{
    public partial class Signup : Form
    {

        PROCESSES process = new PROCESSES();
        public Signup()
        {
            InitializeComponent();
        }
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        private void linkLabel_Signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int userid = -1;
            Login login = new Login(userid);
            login.Show();
            this.Hide();
        }
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        private void Signup_Load(object sender, EventArgs e)
        {

        }
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        private void Button_Signin_Click(object sender, EventArgs e)
        {
            string fname, mname, lname, email, position, pass, conpass, pin;
            bool processofsignup;
            position = "";
            if (RadioButton_Male.Checked) { position = "Vet"; }
            else if (RadioButton_Female.Checked) { position = "Staff"; }
            else { position = ""; }
            fname = TextBox_Fname.Text;
            mname = TextBox_Mname.Text;
            lname = TextBox_Lname.Text;
            email = TextBox_Email.Text;
            pin = TextBox_Pin.Text;
            pass = TextBox_Password.Text.ToLower(); ;
            conpass = TextBox_ConfirmPass.Text.ToLower();
            int checker = process.Signup_AccChecker(email);
            if (checker > 0)
            {
                MessageBox.Show("The Email already has an account!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (pass != conpass)
                {
                    Button_Signin.Enabled = false;
                    MessageBox.Show("Passwords Are Not The Same!");
                    return;
                }
                else { processofsignup = process.getNameSpace(fname, lname, mname, position, email, pass, pin); }
                if (processofsignup == true) {
                    this.Hide();
                }
            }
            
            
            
            
            
            this.Hide();

        }
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        public void getValues()
        {
            string fname, mname, lname, email, position, pass, conpass, pin;
            position = "";
            if (RadioButton_Male.Checked) { position = "Vet"; }
            else if (RadioButton_Female.Checked) { position = "Staff"; }
            else { position = ""; }
            fname = TextBox_Fname.Text;
            mname = TextBox_Mname.Text;
            lname = TextBox_Lname.Text;
            email = TextBox_Email.Text;

            int fnamespace = fname.IndexOf(' ');
            fname = fname.Substring(fnamespace + 1);


            if (fname != "" && fnamespace == -1)
            {
                fname = char.ToUpper(TextBox_Fname.Text[0]) + TextBox_Fname.Text.Substring(1).ToLower();
            }
            else if (fname != "")
            {
                fname = char.ToUpper(TextBox_Fname.Text[0]) + TextBox_Fname.Text.Substring(1, fnamespace).ToLower() + char.ToUpper(TextBox_Fname.Text[fnamespace + 1]) + TextBox_Fname.Text.Substring(fnamespace + 2).ToLower();
            }
            ///
            ///
            int mnamespace = mname.IndexOf(' ');
            mname = mname.Substring(mnamespace + 1);

            if (mname != "" && mnamespace == -1)
            {
                mname = char.ToUpper(TextBox_Mname.Text[0]) + TextBox_Mname.Text.Substring(1).ToLower();
            }
            else if (mname != "")
            {
                mname = char.ToUpper(TextBox_Mname.Text[0]) + TextBox_Mname.Text.Substring(1, mnamespace).ToLower() + char.ToUpper(TextBox_Mname.Text[mnamespace + 1]) + TextBox_Mname.Text.Substring(mnamespace + 2).ToLower();

            }
            ///
            ///
            int lnamespace = lname.IndexOf(' ');
            lname = lname.Substring(lnamespace + 1);

            if (lname != "" && lnamespace == -1)
            { lname = char.ToUpper(TextBox_Lname.Text[0]) + TextBox_Lname.Text.Substring(1).ToLower(); }
            else if (lname != "")
            {
                lname = char.ToUpper(TextBox_Lname.Text[0]) + TextBox_Lname.Text.Substring(1, lnamespace).ToLower() + char.ToUpper(TextBox_Lname.Text[lnamespace + 1]) + TextBox_Lname.Text.Substring(lnamespace + 2).ToLower();
            }
            ///
            ///
            if (email != "")
                email = char.ToUpper(TextBox_Email.Text[0]) + TextBox_Email.Text.Substring(1).ToLower();

            pin = TextBox_Pin.Text;
            pass = TextBox_Password.Text.ToLower(); ;
            conpass = TextBox_ConfirmPass.Text.ToLower(); ;
            Checker(fname, mname, lname, email, position, pass, conpass, pin);
        }
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
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
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        private void TextBox_Fname_TextChanged(object sender, EventArgs e)
        {
            getValues();
        }
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        private void TextBox_Mname_TextChanged(object sender, EventArgs e)
        {
            getValues();
        }
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        private void TextBox_Lname_TextChanged(object sender, EventArgs e)
        {
            getValues();
        }
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        private void TextBox_Email_TextChanged(object sender, EventArgs e)
        {
            getValues();
        }
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        private void TextBox_Password_TextChanged(object sender, EventArgs e)
        {
            getValues();
        }
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        private void TextBox_ConfirmPass_TextChanged(object sender, EventArgs e)
        {
            getValues();
        }
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        private void TextBox_Pin_TextChanged(object sender, EventArgs e)
        {
            int length = TextBox_Pin.Text.Length;
            string text = TextBox_Pin.Text;
            if (length > 6)
            {
                MessageBox.Show("Six (6) Digits only!!");
                TextBox_Pin.Text = text.Substring(0, 6);
                length = TextBox_Pin.Text.Length; 
            }
            if (int.TryParse(TextBox_Pin.Text, out int pin) && pin >= 0)
            {
            }
            else if (TextBox_Pin.Text == "") 
            {
            }
            else
            {
                MessageBox.Show("Only numeric values are allowed!");
                TextBox_Pin.Text = TextBox_Pin.Text.Substring(0, length - 1);
            }
            getValues();
        }
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
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
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
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
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
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
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        private void RadioButton_Male_CheckedChanged(object sender, EventArgs e)
        {
            getValues();
        }
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        /////////////
        private void RadioButton_Female_CheckedChanged(object sender, EventArgs e)
        {
            getValues();
        }
    }

}
