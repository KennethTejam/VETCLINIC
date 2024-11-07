using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

namespace CLINIC
{
    public partial class ManageAccount : Form
    {

        public string username, db_datejoined, db_email, db_pin, db_password, db_position, db_fullname;
        private Label label1;
        private Label label4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label Label_Fullname;
        private Label Label_Role;
        private PictureBox pictureBox4;
        private OpenFileDialog openFileDialog1;
        private OpenFileDialog openFileDialog2;
        private OpenFileDialog openFileDialog3;
        private Button Button_EmailConfirm;
        private Button Button_PinConfirm;
        private Button Button_PassConfirm;
        SqlConnection conn;
        
        public ManageAccount(string Username)
        {
            InitializeComponent();
            username = Username;
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

            AssignValues();
        }




        public void AssignValues()
        {
            string Username = username;
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            try
            {
                string query = "SELECT * FROM userinfo WHERE email = @Username;";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@Username", Username);

                    SqlDataAdapter sdae = new SqlDataAdapter(command);
                    DataTable dtable = new DataTable();
                    sdae.Fill(dtable);

                    if (dtable.Rows.Count > 0)
                    {
                        db_email = dtable.Rows[0]["email"].ToString();
                        db_pin = dtable.Rows[0]["pin"].ToString();
                        db_password = dtable.Rows[0]["pass"].ToString();
                        db_datejoined = Convert.ToDateTime(dtable.Rows[0]["datecreated"]).ToString("MM/dd/yyyy");
                        db_fullname = $"{dtable.Rows[0]["fname"]} {dtable.Rows[0]["mname"]} {dtable.Rows[0]["lname"]}".Trim();
                        db_position = dtable.Rows[0]["position"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No user found with that email.");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            Label_Role.Text = "Role: " + db_position;
            Label_Fullname.Text = "Full Name: " + db_fullname;
            Label_MemberSince.Text = "Member Since: " + db_datejoined;
            TextBox_ChangePin.Text = db_pin;
            TextBox_ChangeEmail.Text = db_email;
            TextBox_ChangePassword.Text = db_password;
        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(ManageAccount));
            Label_MemberSince = new Label();
            TextBox_ChangeEmail = new TextBox();
            TextBox_ChangePassword = new TextBox();
            label2 = new Label();
            TextBox_ChangePin = new TextBox();
            Label_Homepage = new Label();
            Label_ManageAccount = new Label();
            Label_AddRecord = new Label();
            Label_Appointment = new Label();
            Label_Username = new Label();
            label3 = new Label();
            Clinic_MainLogo = new PictureBox();
            label1 = new Label();
            label4 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            Label_Fullname = new Label();
            Label_Role = new Label();
            pictureBox4 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            openFileDialog2 = new OpenFileDialog();
            openFileDialog3 = new OpenFileDialog();
            Button_EmailConfirm = new Button();
            Button_PinConfirm = new Button();
            Button_PassConfirm = new Button();
            ((ISupportInitialize)Clinic_MainLogo).BeginInit();
            ((ISupportInitialize)pictureBox3).BeginInit();
            ((ISupportInitialize)pictureBox1).BeginInit();
            ((ISupportInitialize)pictureBox2).BeginInit();
            ((ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // Label_MemberSince
            // 
            Label_MemberSince.AutoSize = true;
            Label_MemberSince.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_MemberSince.Location = new Point(53, 503);
            Label_MemberSince.Name = "Label_MemberSince";
            Label_MemberSince.Size = new Size(139, 24);
            Label_MemberSince.TabIndex = 40;
            Label_MemberSince.Text = "Member Since: ";
            // 
            // TextBox_ChangeEmail
            // 
            TextBox_ChangeEmail.BackColor = SystemColors.Window;
            TextBox_ChangeEmail.Enabled = false;
            TextBox_ChangeEmail.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            TextBox_ChangeEmail.ForeColor = SystemColors.WindowText;
            TextBox_ChangeEmail.Location = new Point(423, 277);
            TextBox_ChangeEmail.Name = "TextBox_ChangeEmail";
            TextBox_ChangeEmail.Size = new Size(361, 39);
            TextBox_ChangeEmail.TabIndex = 39;
            TextBox_ChangeEmail.TextChanged += TextBox_ChangeEmail_TextChanged;
            // 
            // TextBox_ChangePassword
            // 
            TextBox_ChangePassword.BackColor = SystemColors.Window;
            TextBox_ChangePassword.Enabled = false;
            TextBox_ChangePassword.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            TextBox_ChangePassword.ForeColor = SystemColors.WindowText;
            TextBox_ChangePassword.Location = new Point(423, 442);
            TextBox_ChangePassword.Name = "TextBox_ChangePassword";
            TextBox_ChangePassword.Size = new Size(361, 39);
            TextBox_ChangePassword.TabIndex = 26;
            TextBox_ChangePassword.TextChanged += TextBox_ChangePassword_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
            label2.Location = new Point(423, 331);
            label2.Name = "label2";
            label2.Size = new Size(58, 24);
            label2.TabIndex = 28;
            label2.Text = "PIN : ";
            // 
            // TextBox_ChangePin
            // 
            TextBox_ChangePin.BackColor = SystemColors.Window;
            TextBox_ChangePin.Enabled = false;
            TextBox_ChangePin.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            TextBox_ChangePin.ForeColor = SystemColors.WindowText;
            TextBox_ChangePin.Location = new Point(423, 360);
            TextBox_ChangePin.Name = "TextBox_ChangePin";
            TextBox_ChangePin.Size = new Size(361, 39);
            TextBox_ChangePin.TabIndex = 25;
            TextBox_ChangePin.TextChanged += TextBox_ChangePin_TextChanged;
            // 
            // Label_Homepage
            // 
            Label_Homepage.AutoSize = true;
            Label_Homepage.BackColor = SystemColors.Control;
            Label_Homepage.BorderStyle = BorderStyle.Fixed3D;
            Label_Homepage.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            Label_Homepage.ForeColor = SystemColors.ControlText;
            Label_Homepage.Location = new Point(423, 145);
            Label_Homepage.Name = "Label_Homepage";
            Label_Homepage.Size = new Size(112, 27);
            Label_Homepage.TabIndex = 49;
            Label_Homepage.Text = "Homepage";
            Label_Homepage.Click += Label_Homepage_Click;
            // 
            // Label_ManageAccount
            // 
            Label_ManageAccount.AutoSize = true;
            Label_ManageAccount.BorderStyle = BorderStyle.Fixed3D;
            Label_ManageAccount.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            Label_ManageAccount.Location = new Point(852, 145);
            Label_ManageAccount.Name = "Label_ManageAccount";
            Label_ManageAccount.Size = new Size(165, 27);
            Label_ManageAccount.TabIndex = 48;
            Label_ManageAccount.Text = "Manage Account";
            // 
            // Label_AddRecord
            // 
            Label_AddRecord.AutoSize = true;
            Label_AddRecord.BorderStyle = BorderStyle.Fixed3D;
            Label_AddRecord.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            Label_AddRecord.Location = new Point(541, 145);
            Label_AddRecord.Name = "Label_AddRecord";
            Label_AddRecord.Size = new Size(143, 27);
            Label_AddRecord.TabIndex = 47;
            Label_AddRecord.Text = "Add to Record";
            Label_AddRecord.Click += Label_AddRecord_Click;
            // 
            // Label_Appointment
            // 
            Label_Appointment.AutoSize = true;
            Label_Appointment.BackColor = SystemColors.Control;
            Label_Appointment.BorderStyle = BorderStyle.Fixed3D;
            Label_Appointment.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            Label_Appointment.ForeColor = SystemColors.ControlText;
            Label_Appointment.Location = new Point(690, 145);
            Label_Appointment.Name = "Label_Appointment";
            Label_Appointment.Size = new Size(156, 27);
            Label_Appointment.TabIndex = 46;
            Label_Appointment.Text = "History Records";
            Label_Appointment.Click += Label_Appointment_Click;
            // 
            // Label_Username
            // 
            Label_Username.AutoSize = true;
            Label_Username.Font = new Font("Sitka Subheading", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Label_Username.Location = new Point(243, 78);
            Label_Username.Name = "Label_Username";
            Label_Username.Size = new Size(268, 53);
            Label_Username.TabIndex = 45;
            Label_Username.Text = "@GMAIL.COM";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Subheading", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(243, 9);
            label3.Name = "label3";
            label3.Size = new Size(286, 69);
            label3.TabIndex = 44;
            label3.Text = "WELCOME!";
            // 
            // Clinic_MainLogo
            // 
            Clinic_MainLogo.Image = (Image)resources.GetObject("Clinic_MainLogo.Image");
            Clinic_MainLogo.Location = new Point(37, 22);
            Clinic_MainLogo.Name = "Clinic_MainLogo";
            Clinic_MainLogo.Size = new Size(164, 150);
            Clinic_MainLogo.SizeMode = PictureBoxSizeMode.Zoom;
            Clinic_MainLogo.TabIndex = 43;
            Clinic_MainLogo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
            label1.Location = new Point(423, 251);
            label1.Name = "label1";
            label1.Size = new Size(85, 24);
            label1.TabIndex = 51;
            label1.Text = "EMAIL : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
            label4.Location = new Point(423, 417);
            label4.Name = "label4";
            label4.Size = new Size(123, 24);
            label4.TabIndex = 52;
            label4.Text = "PASSWORD : ";
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(812, 447);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 57;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(812, 365);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 58;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(812, 282);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 59;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Label_Fullname
            // 
            Label_Fullname.AutoSize = true;
            Label_Fullname.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_Fullname.Location = new Point(53, 527);
            Label_Fullname.Name = "Label_Fullname";
            Label_Fullname.Size = new Size(102, 24);
            Label_Fullname.TabIndex = 60;
            Label_Fullname.Text = "Full name:";
            // 
            // Label_Role
            // 
            Label_Role.AutoSize = true;
            Label_Role.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_Role.Location = new Point(53, 551);
            Label_Role.Name = "Label_Role";
            Label_Role.Size = new Size(138, 24);
            Label_Role.TabIndex = 61;
            Label_Role.Text = "Company Role:";
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BorderStyle = BorderStyle.Fixed3D;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(53, 251);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(248, 230);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 63;
            pictureBox4.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            // 
            // openFileDialog3
            // 
            openFileDialog3.FileName = "openFileDialog3";
            // 
            // Button_EmailConfirm
            // 
            Button_EmailConfirm.Enabled = false;
            Button_EmailConfirm.Font = new Font("Quadrat-Serial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Button_EmailConfirm.Location = new Point(883, 272);
            Button_EmailConfirm.Name = "Button_EmailConfirm";
            Button_EmailConfirm.Size = new Size(150, 50);
            Button_EmailConfirm.TabIndex = 64;
            Button_EmailConfirm.Text = "Confirm";
            Button_EmailConfirm.UseVisualStyleBackColor = true;
            Button_EmailConfirm.Visible = false;
            Button_EmailConfirm.Click += Button_EmailConfirm_Click;
            // 
            // Button_PinConfirm
            // 
            Button_PinConfirm.Enabled = false;
            Button_PinConfirm.Font = new Font("Quadrat-Serial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Button_PinConfirm.Location = new Point(883, 355);
            Button_PinConfirm.Name = "Button_PinConfirm";
            Button_PinConfirm.Size = new Size(150, 50);
            Button_PinConfirm.TabIndex = 65;
            Button_PinConfirm.Text = "Confirm";
            Button_PinConfirm.UseVisualStyleBackColor = true;
            Button_PinConfirm.Visible = false;
            Button_PinConfirm.Click += Button_PinConfirm_Click;
            // 
            // Button_PassConfirm
            // 
            Button_PassConfirm.Enabled = false;
            Button_PassConfirm.Font = new Font("Quadrat-Serial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Button_PassConfirm.Location = new Point(883, 437);
            Button_PassConfirm.Name = "Button_PassConfirm";
            Button_PassConfirm.Size = new Size(150, 50);
            Button_PassConfirm.TabIndex = 66;
            Button_PassConfirm.Text = "Confirm";
            Button_PassConfirm.UseVisualStyleBackColor = true;
            Button_PassConfirm.Visible = false;
            Button_PassConfirm.Click += Button_PassConfirm_Click;
            // 
            // ManageAccount
            // 
            ClientSize = new Size(1064, 681);
            Controls.Add(Button_PassConfirm);
            Controls.Add(Button_PinConfirm);
            Controls.Add(Button_EmailConfirm);
            Controls.Add(pictureBox4);
            Controls.Add(Label_Role);
            Controls.Add(Label_Fullname);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(Label_MemberSince);
            Controls.Add(Label_Homepage);
            Controls.Add(Label_ManageAccount);
            Controls.Add(Label_AddRecord);
            Controls.Add(Label_Appointment);
            Controls.Add(Label_Username);
            Controls.Add(label3);
            Controls.Add(Clinic_MainLogo);
            Controls.Add(TextBox_ChangeEmail);
            Controls.Add(TextBox_ChangePassword);
            Controls.Add(label2);
            Controls.Add(TextBox_ChangePin);
            Name = "ManageAccount";
            Load += ChangePassword_Load;
            ((ISupportInitialize)Clinic_MainLogo).EndInit();
            ((ISupportInitialize)pictureBox3).EndInit();
            ((ISupportInitialize)pictureBox1).EndInit();
            ((ISupportInitialize)pictureBox2).EndInit();
            ((ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label Label_MemberSince;
        private TextBox TextBox_ChangeEmail;
        private TextBox TextBox_ChangePassword;
        private Label label2;
        private TextBox TextBox_ChangePin;
        private Label Label_Homepage;
        private Label Label_ManageAccount;
        private Label Label_AddRecord;
        private Label Label_Appointment;
        private Label Label_Username;
        private Label label3;
        private PictureBox Clinic_MainLogo;





        private void Label_Homepage_Click(object sender, EventArgs e)
        {
            string Username = username;
            Homepage homepage = new Homepage(Username);
            homepage.Show();
            this.Hide();
        }

        private void Label_AddRecord_Click(object sender, EventArgs e)
        {
            string Username = username;
            AddRecord addrecord = new AddRecord(Username);
            addrecord.Show();
            this.Hide();

        }

        private void Label_Appointment_Click(object sender, EventArgs e)
        {
            string Username = username;
            RecordHistory recordhistory = new RecordHistory(Username);
            recordhistory.Show();
            this.Hide();
        }


        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (TextBox_ChangeEmail.Enabled == false)
            {
                TextBox_ChangeEmail.AcceptsReturn = true;
                TextBox_ChangeEmail.Enabled = true;
                Button_EmailConfirm.Visible = true;
            }
            else
            {
                TextBox_ChangeEmail.AcceptsReturn = false;
                TextBox_ChangeEmail.Enabled = false;
                Button_EmailConfirm.Visible = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (TextBox_ChangePin.Enabled == false)
            {
                TextBox_ChangePin.AcceptsReturn = true;
                TextBox_ChangePin.Enabled = true;
                Button_PinConfirm.Visible = true;
            }
            else
            {
                TextBox_ChangePin.AcceptsReturn = false;
                TextBox_ChangePin.Enabled = false;
                Button_PinConfirm.Visible = false;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (TextBox_ChangePassword.Enabled == false)
            {
                TextBox_ChangePassword.AcceptsReturn = true;
                TextBox_ChangePassword.Enabled = true;
                Button_PassConfirm.Visible = true;
            }
            else
            {
                TextBox_ChangePassword.AcceptsReturn = false;
                TextBox_ChangePassword.Enabled = false;
                Button_PassConfirm.Visible = false;
            }
        }

        private void TextBox_ChangeEmail_TextChanged(object sender, EventArgs e)
        {
            Button_EmailConfirm.Enabled = true;
        }

        private void TextBox_ChangePin_TextChanged(object sender, EventArgs e)
        {
            Button_PinConfirm.Enabled = true;
        }

        private void TextBox_ChangePassword_TextChanged(object sender, EventArgs e)
        {
            Button_PassConfirm.Enabled = true;
        }

        private void Button_EmailConfirm_Click(object sender, EventArgs e)
        {
            string choice = "Email";
            DialogResult result = ConfirmChange();
            if (result == DialogResult.Yes) { }
            else return;

            ChangeGo(choice);
            Button_EmailConfirm.Visible = false;
            TextBox_ChangeEmail.Enabled = false;
        }

        private void Button_PinConfirm_Click(object sender, EventArgs e)
        {
            string choice = "Pin";
                DialogResult result = ConfirmChange();
            if (result == DialogResult.Yes) { }
            else return;
            ChangeGo(choice);
            Button_PinConfirm.Visible = false;
            TextBox_ChangePin.Enabled = false;
        }

        private void Button_PassConfirm_Click(object sender, EventArgs e)
        {
            string choice = "Pass";
            DialogResult result = ConfirmChange();
            if (result == DialogResult.Yes) { }
            else return;
            ChangeGo(choice);
            Button_PassConfirm.Visible = false;
            TextBox_ChangePassword.Enabled = false;
        }



            public DialogResult ConfirmChange(){
            
            return MessageBox.Show("Are you sure you want to proceed?",
                          "Confirmation",
                          MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question);
        }



        public void ChangeGo(string choice)
        {
            string query,pin=TextBox_ChangePin.Text,pass=TextBox_ChangePassword.Text,email =TextBox_ChangeEmail.Text;
            if (choice == "Pin") { query = "Update UserInfo set pin = @pin"; }
            else if (choice == "Pass") { query = "Update UserInfo set pass = @password"; }
            else if (choice == "Email") { query = "Update UserInfo set email = @email"; }
            else { query = ""; }
            try
            {
                conn.Open();
                    

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@password", pass);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@pin", pin);

                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Change successful!");

            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
