using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class RecordHistory : Form
    {
        public int userid;
        SqlConnection conn;
        ContextMenuStrip contextMenu = new ContextMenuStrip();
        PROCESSES process = new PROCESSES();
        public RecordHistory(int userid)
        {
            InitializeComponent();
            
            this.userid = userid;
            Label_HistoryRecords.BackColor = Color.LightSkyBlue;
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
        private void Label_AddRecord_Click(object sender, EventArgs e)
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
        private void Label_Homepage_Click(object sender, EventArgs e)
        {
            Homepage homepage = new Homepage(userid);
            homepage.Show();
            this.Hide();
        }
    }
}
