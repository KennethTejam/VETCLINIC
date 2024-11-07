namespace CLINIC
{
    partial class AddRecord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRecord));
            Label_Homepage = new Label();
            Label_ManageAccount = new Label();
            Label_AddRecord = new Label();
            Label_Appointment = new Label();
            Label_Username = new Label();
            Label_Welcome = new Label();
            Clinic_MainLogo = new PictureBox();
            Label_ForgotPass = new Label();
            TextBox_Breed = new TextBox();
            TextBox_PetName = new TextBox();
            Button_AddToRecord = new Button();
            Label_Password = new Label();
            Label_Gender = new Label();
            Label_Mname = new Label();
            Label_ConfirmPass = new Label();
            label3 = new Label();
            Label_Email = new Label();
            Label_Fname = new Label();
            TextBox_Email = new TextBox();
            TextBox_ContactNumber = new TextBox();
            TextBox_Owner = new TextBox();
            TextBox_Note = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)Clinic_MainLogo).BeginInit();
            SuspendLayout();
            // 
            // Label_Homepage
            // 
            Label_Homepage.AutoSize = true;
            Label_Homepage.BackColor = SystemColors.Control;
            Label_Homepage.BorderStyle = BorderStyle.Fixed3D;
            Label_Homepage.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            Label_Homepage.ForeColor = SystemColors.ControlText;
            Label_Homepage.Location = new Point(394, 145);
            Label_Homepage.Name = "Label_Homepage";
            Label_Homepage.Size = new Size(112, 27);
            Label_Homepage.TabIndex = 21;
            Label_Homepage.Text = "Homepage";
            Label_Homepage.Click += Label_Homepage_Click;
            // 
            // Label_ManageAccount
            // 
            Label_ManageAccount.AutoSize = true;
            Label_ManageAccount.BorderStyle = BorderStyle.Fixed3D;
            Label_ManageAccount.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            Label_ManageAccount.Location = new Point(823, 145);
            Label_ManageAccount.Name = "Label_ManageAccount";
            Label_ManageAccount.Size = new Size(165, 27);
            Label_ManageAccount.TabIndex = 17;
            Label_ManageAccount.Text = "Manage Account";
            // 
            // Label_AddRecord
            // 
            Label_AddRecord.AutoSize = true;
            Label_AddRecord.BorderStyle = BorderStyle.Fixed3D;
            Label_AddRecord.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            Label_AddRecord.Location = new Point(512, 145);
            Label_AddRecord.Name = "Label_AddRecord";
            Label_AddRecord.Size = new Size(143, 27);
            Label_AddRecord.TabIndex = 16;
            Label_AddRecord.Text = "Add to Record";
            // 
            // Label_Appointment
            // 
            Label_Appointment.AutoSize = true;
            Label_Appointment.BackColor = SystemColors.Control;
            Label_Appointment.BorderStyle = BorderStyle.Fixed3D;
            Label_Appointment.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            Label_Appointment.ForeColor = SystemColors.ControlText;
            Label_Appointment.Location = new Point(661, 145);
            Label_Appointment.Name = "Label_Appointment";
            Label_Appointment.Size = new Size(156, 27);
            Label_Appointment.TabIndex = 15;
            Label_Appointment.Text = "History Records";
            Label_Appointment.Click += Label_Appointment_Click;
            // 
            // Label_Username
            // 
            Label_Username.AutoSize = true;
            Label_Username.Font = new Font("Sitka Subheading", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Label_Username.Location = new Point(214, 78);
            Label_Username.Name = "Label_Username";
            Label_Username.Size = new Size(268, 53);
            Label_Username.TabIndex = 14;
            Label_Username.Text = "@GMAIL.COM";
            // 
            // Label_Welcome
            // 
            Label_Welcome.AutoSize = true;
            Label_Welcome.Font = new Font("Sitka Subheading", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Label_Welcome.Location = new Point(214, 9);
            Label_Welcome.Name = "Label_Welcome";
            Label_Welcome.Size = new Size(286, 69);
            Label_Welcome.TabIndex = 13;
            Label_Welcome.Text = "WELCOME!";
            // 
            // Clinic_MainLogo
            // 
            Clinic_MainLogo.Image = (Image)resources.GetObject("Clinic_MainLogo.Image");
            Clinic_MainLogo.Location = new Point(8, 22);
            Clinic_MainLogo.Name = "Clinic_MainLogo";
            Clinic_MainLogo.Size = new Size(164, 150);
            Clinic_MainLogo.SizeMode = PictureBoxSizeMode.Zoom;
            Clinic_MainLogo.TabIndex = 12;
            Clinic_MainLogo.TabStop = false;
            // 
            // Label_ForgotPass
            // 
            Label_ForgotPass.AutoSize = true;
            Label_ForgotPass.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            Label_ForgotPass.Location = new Point(78, 475);
            Label_ForgotPass.Name = "Label_ForgotPass";
            Label_ForgotPass.Size = new Size(89, 30);
            Label_ForgotPass.TabIndex = 37;
            Label_ForgotPass.Text = "EMAIL: ";
            // 
            // TextBox_Breed
            // 
            TextBox_Breed.BackColor = SystemColors.Window;
            TextBox_Breed.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold);
            TextBox_Breed.Location = new Point(305, 281);
            TextBox_Breed.Margin = new Padding(3, 0, 3, 3);
            TextBox_Breed.Multiline = true;
            TextBox_Breed.Name = "TextBox_Breed";
            TextBox_Breed.Size = new Size(259, 31);
            TextBox_Breed.TabIndex = 29;
            TextBox_Breed.TextChanged += TextBox_Breed_TextChanged;
            // 
            // TextBox_PetName
            // 
            TextBox_PetName.BackColor = SystemColors.Window;
            TextBox_PetName.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold);
            TextBox_PetName.Location = new Point(305, 229);
            TextBox_PetName.Margin = new Padding(3, 0, 3, 3);
            TextBox_PetName.Multiline = true;
            TextBox_PetName.Name = "TextBox_PetName";
            TextBox_PetName.Size = new Size(259, 31);
            TextBox_PetName.TabIndex = 28;
            TextBox_PetName.TextChanged += TextBox_PetName_TextChanged;
            // 
            // Button_AddToRecord
            // 
            Button_AddToRecord.Enabled = false;
            Button_AddToRecord.Font = new Font("Quadrat-Serial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Button_AddToRecord.Location = new Point(490, 538);
            Button_AddToRecord.Name = "Button_AddToRecord";
            Button_AddToRecord.Size = new Size(189, 75);
            Button_AddToRecord.TabIndex = 39;
            Button_AddToRecord.Text = "ADD TO RECORD";
            Button_AddToRecord.UseVisualStyleBackColor = true;
            Button_AddToRecord.Click += Button_AddToRecord_Click;
            // 
            // Label_Password
            // 
            Label_Password.AutoSize = true;
            Label_Password.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            Label_Password.Location = new Point(733, 196);
            Label_Password.Name = "Label_Password";
            Label_Password.Size = new Size(283, 30);
            Label_Password.TabIndex = 40;
            Label_Password.Text = "NOTE: (MEDICAL HISTORY)";
            // 
            // Label_Gender
            // 
            Label_Gender.AutoSize = true;
            Label_Gender.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            Label_Gender.Location = new Point(79, 383);
            Label_Gender.Name = "Label_Gender";
            Label_Gender.Size = new Size(173, 30);
            Label_Gender.TabIndex = 41;
            Label_Gender.Text = "OWNER NAME: ";
            // 
            // Label_Mname
            // 
            Label_Mname.AutoSize = true;
            Label_Mname.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            Label_Mname.Location = new Point(78, 280);
            Label_Mname.Name = "Label_Mname";
            Label_Mname.Size = new Size(83, 30);
            Label_Mname.TabIndex = 42;
            Label_Mname.Text = "BREED:";
            // 
            // Label_ConfirmPass
            // 
            Label_ConfirmPass.AutoSize = true;
            Label_ConfirmPass.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            Label_ConfirmPass.Location = new Point(78, 429);
            Label_ConfirmPass.Name = "Label_ConfirmPass";
            Label_ConfirmPass.Size = new Size(224, 30);
            Label_ConfirmPass.TabIndex = 43;
            Label_ConfirmPass.Text = "CONTACT NUMBER:  ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            label3.Location = new Point(203, 325);
            label3.Name = "label3";
            label3.Size = new Size(0, 40);
            label3.TabIndex = 44;
            // 
            // Label_Email
            // 
            Label_Email.AutoSize = true;
            Label_Email.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            Label_Email.Location = new Point(78, 335);
            Label_Email.Name = "Label_Email";
            Label_Email.Size = new Size(164, 30);
            Label_Email.TabIndex = 45;
            Label_Email.Text = "PET BIRTHDAY:";
            // 
            // Label_Fname
            // 
            Label_Fname.AutoSize = true;
            Label_Fname.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            Label_Fname.Location = new Point(78, 234);
            Label_Fname.Name = "Label_Fname";
            Label_Fname.Size = new Size(124, 30);
            Label_Fname.TabIndex = 47;
            Label_Fname.Text = "PET NAME:";
            // 
            // TextBox_Email
            // 
            TextBox_Email.BackColor = SystemColors.Window;
            TextBox_Email.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold);
            TextBox_Email.Location = new Point(305, 476);
            TextBox_Email.Margin = new Padding(3, 0, 3, 3);
            TextBox_Email.Multiline = true;
            TextBox_Email.Name = "TextBox_Email";
            TextBox_Email.Size = new Size(374, 31);
            TextBox_Email.TabIndex = 50;
            TextBox_Email.TextChanged += TextBox_Email_TextChanged;
            // 
            // TextBox_ContactNumber
            // 
            TextBox_ContactNumber.BackColor = SystemColors.Window;
            TextBox_ContactNumber.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold);
            TextBox_ContactNumber.Location = new Point(305, 430);
            TextBox_ContactNumber.Margin = new Padding(3, 0, 3, 3);
            TextBox_ContactNumber.Multiline = true;
            TextBox_ContactNumber.Name = "TextBox_ContactNumber";
            TextBox_ContactNumber.Size = new Size(374, 31);
            TextBox_ContactNumber.TabIndex = 49;
            TextBox_ContactNumber.TextChanged += TextBox_ContactNumber_TextChanged;
            // 
            // TextBox_Owner
            // 
            TextBox_Owner.BackColor = SystemColors.Window;
            TextBox_Owner.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold);
            TextBox_Owner.Location = new Point(305, 384);
            TextBox_Owner.Margin = new Padding(3, 0, 3, 3);
            TextBox_Owner.Multiline = true;
            TextBox_Owner.Name = "TextBox_Owner";
            TextBox_Owner.Size = new Size(374, 31);
            TextBox_Owner.TabIndex = 48;
            TextBox_Owner.TextChanged += TextBox_Owner_TextChanged;
            // 
            // TextBox_Note
            // 
            TextBox_Note.BackColor = SystemColors.Window;
            TextBox_Note.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            TextBox_Note.Location = new Point(733, 229);
            TextBox_Note.Multiline = true;
            TextBox_Note.Name = "TextBox_Note";
            TextBox_Note.Size = new Size(276, 278);
            TextBox_Note.TabIndex = 51;
            TextBox_Note.TextChanged += TextBox_Note_TextChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Microsoft Sans Serif", 14.25F);
            radioButton1.Location = new Point(587, 237);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(69, 28);
            radioButton1.TabIndex = 52;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Microsoft Sans Serif", 14.25F);
            radioButton2.Location = new Point(587, 281);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(92, 28);
            radioButton2.TabIndex = 53;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold);
            dateTimePicker1.Location = new Point(305, 335);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(374, 31);
            dateTimePicker1.TabIndex = 54;
            // 
            // AddRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 681);
            Controls.Add(dateTimePicker1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(TextBox_Note);
            Controls.Add(TextBox_Email);
            Controls.Add(TextBox_ContactNumber);
            Controls.Add(TextBox_Owner);
            Controls.Add(Label_ForgotPass);
            Controls.Add(TextBox_Breed);
            Controls.Add(TextBox_PetName);
            Controls.Add(Button_AddToRecord);
            Controls.Add(Label_Password);
            Controls.Add(Label_Gender);
            Controls.Add(Label_Mname);
            Controls.Add(Label_ConfirmPass);
            Controls.Add(label3);
            Controls.Add(Label_Email);
            Controls.Add(Label_Fname);
            Controls.Add(Label_Homepage);
            Controls.Add(Label_ManageAccount);
            Controls.Add(Label_AddRecord);
            Controls.Add(Label_Appointment);
            Controls.Add(Label_Username);
            Controls.Add(Label_Welcome);
            Controls.Add(Clinic_MainLogo);
            Name = "AddRecord";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Clinic_MainLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Label_Homepage;
        private Label Label_ManageAccount;
        private Label Label_AddRecord;
        private Label Label_Appointment;
        private Label Label_Username;
        private Label Label_Welcome;
        private PictureBox Clinic_MainLogo;
        private Label Label_ForgotPass;
        private TextBox TextBox_Breed;
        private TextBox TextBox_PetName;
        private Button Button_AddToRecord;
        private Label Label_Password;
        private Label Label_Gender;
        private Label Label_Mname;
        private Label Label_ConfirmPass;
        private Label label3;
        private Label Label_Email;
        private Label Label_Fname;
        private TextBox TextBox_Email;
        private TextBox TextBox_ContactNumber;
        private TextBox TextBox_Owner;
        private TextBox TextBox_Note;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private DateTimePicker dateTimePicker1;
    }
}