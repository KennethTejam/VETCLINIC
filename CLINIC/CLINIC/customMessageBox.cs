using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLINIC
{
    public partial class customMessageBox : Form
    {
        public bool IsVerified { get; private set; }
        int userid;
        PROCESSES process = new PROCESSES();
        public customMessageBox(string text,int userid)
        {
            this.userid = userid;
            InitializeComponent();
            btnOK.Focus();
            this.TopMost = true;
            this.ShowInTaskbar = false;
            

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void TransparentForm_MouseDown(object sender, MouseEventArgs e)
        {
            // Prevent interaction with other forms or windows
            this.BringToFront(); // Ensure it's on top
        }

        private void customMessageBox_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string password = textBox1.Text;
            bool validation = process.validatePassword(userid,password);
            if (validation == true)
            {
                IsVerified = true;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else {
                MessageBox.Show("WrongPassword!"); ;
                return;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string password = textBox1.Text;
        }
    }
}
