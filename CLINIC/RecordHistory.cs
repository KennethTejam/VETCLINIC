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
        public string username;
        public string Username;
        SqlConnection conn;
        public RecordHistory(string Username)
        {
            InitializeComponent();
            
            username = Username;
            Label_HistoryRecords.BackColor = Color.LightSkyBlue;

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
            PROCESSES process = new PROCESSES();
            conn = process.getConnection();
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

        private void Label_AddRecord_Click(object sender, EventArgs e)
        {
            Username = username;
            AddRecord addrecord = new AddRecord(Username);
            addrecord.Show();
            this.Hide();
        }

        private void Label_Homepage_Click(object sender, EventArgs e)
        {
            Username = username;
            Homepage homepage = new Homepage(Username);
            homepage.Show();
            this.Hide();
        }
    }
}
