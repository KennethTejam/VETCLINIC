namespace CLINIC
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            TextBox_ConfirmPass = new TextBox();
            TextBox_Password = new TextBox();
            TextBox_Email = new TextBox();
            TextBox_Lname = new TextBox();
            TextBox_Mname = new TextBox();
            TextBox_Fname = new TextBox();
            Button_Signin = new Button();
            Label_Password = new Label();
            Label_Mname = new Label();
            Label_ConfirmPass = new Label();
            label3 = new Label();
            Label_Email = new Label();
            Label_Lname = new Label();
            Label_Fname = new Label();
            linkLabel_Signup = new LinkLabel();
            TextBox_Pin = new TextBox();
            Label_ForgotPass = new Label();
            Label_Gender = new Label();
            RadioButton_Male = new RadioButton();
            RadioButton_Female = new RadioButton();
            PictureBox_PasswordViewer = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PictureBox_PasswordViewer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // TextBox_ConfirmPass
            // 
            TextBox_ConfirmPass.BackColor = SystemColors.Window;
            TextBox_ConfirmPass.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            TextBox_ConfirmPass.Location = new Point(460, 378);
            TextBox_ConfirmPass.Name = "TextBox_ConfirmPass";
            TextBox_ConfirmPass.Size = new Size(396, 39);
            TextBox_ConfirmPass.TabIndex = 11;
            TextBox_ConfirmPass.UseSystemPasswordChar = true;
            TextBox_ConfirmPass.WordWrap = false;
            TextBox_ConfirmPass.TextChanged += TextBox_ConfirmPass_TextChanged;
            // 
            // TextBox_Password
            // 
            TextBox_Password.BackColor = SystemColors.Window;
            TextBox_Password.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            TextBox_Password.Location = new Point(460, 332);
            TextBox_Password.Name = "TextBox_Password";
            TextBox_Password.Size = new Size(396, 39);
            TextBox_Password.TabIndex = 10;
            TextBox_Password.UseSystemPasswordChar = true;
            TextBox_Password.WordWrap = false;
            TextBox_Password.TextChanged += TextBox_Password_TextChanged;
            // 
            // TextBox_Email
            // 
            TextBox_Email.BackColor = SystemColors.Window;
            TextBox_Email.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            TextBox_Email.Location = new Point(460, 241);
            TextBox_Email.Multiline = true;
            TextBox_Email.Name = "TextBox_Email";
            TextBox_Email.Size = new Size(396, 40);
            TextBox_Email.TabIndex = 4;
            TextBox_Email.TextChanged += TextBox_Email_TextChanged;
            // 
            // TextBox_Lname
            // 
            TextBox_Lname.BackColor = SystemColors.Window;
            TextBox_Lname.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            TextBox_Lname.Location = new Point(460, 192);
            TextBox_Lname.Multiline = true;
            TextBox_Lname.Name = "TextBox_Lname";
            TextBox_Lname.Size = new Size(396, 40);
            TextBox_Lname.TabIndex = 3;
            TextBox_Lname.TextChanged += TextBox_Lname_TextChanged;
            // 
            // TextBox_Mname
            // 
            TextBox_Mname.BackColor = SystemColors.Window;
            TextBox_Mname.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            TextBox_Mname.Location = new Point(460, 146);
            TextBox_Mname.Multiline = true;
            TextBox_Mname.Name = "TextBox_Mname";
            TextBox_Mname.Size = new Size(396, 40);
            TextBox_Mname.TabIndex = 2;
            TextBox_Mname.TextChanged += TextBox_Mname_TextChanged;
            // 
            // TextBox_Fname
            // 
            TextBox_Fname.BackColor = SystemColors.Window;
            TextBox_Fname.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            TextBox_Fname.Location = new Point(460, 100);
            TextBox_Fname.Multiline = true;
            TextBox_Fname.Name = "TextBox_Fname";
            TextBox_Fname.Size = new Size(396, 40);
            TextBox_Fname.TabIndex = 1;
            TextBox_Fname.TextChanged += TextBox_Fname_TextChanged;
            // 
            // Button_Signin
            // 
            Button_Signin.Enabled = false;
            Button_Signin.Font = new Font("Quadrat-Serial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Button_Signin.Location = new Point(450, 525);
            Button_Signin.Name = "Button_Signin";
            Button_Signin.Size = new Size(189, 75);
            Button_Signin.TabIndex = 14;
            Button_Signin.Text = "SIGN ME UP!";
            Button_Signin.UseVisualStyleBackColor = true;
            Button_Signin.Click += Button_Signin_Click;
            // 
            // Label_Password
            // 
            Label_Password.AutoSize = true;
            Label_Password.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            Label_Password.Location = new Point(178, 329);
            Label_Password.Name = "Label_Password";
            Label_Password.Size = new Size(200, 40);
            Label_Password.TabIndex = 16;
            Label_Password.Text = "PASSWORD : ";
            // 
            // Label_Mname
            // 
            Label_Mname.AutoSize = true;
            Label_Mname.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            Label_Mname.Location = new Point(178, 146);
            Label_Mname.Name = "Label_Mname";
            Label_Mname.Size = new Size(244, 40);
            Label_Mname.TabIndex = 19;
            Label_Mname.Text = "MIDDLE NAME : ";
            // 
            // Label_ConfirmPass
            // 
            Label_ConfirmPass.AutoSize = true;
            Label_ConfirmPass.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            Label_ConfirmPass.Location = new Point(178, 375);
            Label_ConfirmPass.Name = "Label_ConfirmPass";
            Label_ConfirmPass.Size = new Size(251, 40);
            Label_ConfirmPass.TabIndex = 20;
            Label_ConfirmPass.Text = "CONFIRM PASS : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            label3.Location = new Point(199, 210);
            label3.Name = "label3";
            label3.Size = new Size(0, 40);
            label3.TabIndex = 21;
            // 
            // Label_Email
            // 
            Label_Email.AutoSize = true;
            Label_Email.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            Label_Email.Location = new Point(178, 238);
            Label_Email.Name = "Label_Email";
            Label_Email.Size = new Size(128, 40);
            Label_Email.TabIndex = 22;
            Label_Email.Text = "EMAIL : ";
            // 
            // Label_Lname
            // 
            Label_Lname.AutoSize = true;
            Label_Lname.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            Label_Lname.Location = new Point(178, 192);
            Label_Lname.Name = "Label_Lname";
            Label_Lname.Size = new Size(196, 40);
            Label_Lname.TabIndex = 23;
            Label_Lname.Text = "LAST NAME :";
            // 
            // Label_Fname
            // 
            Label_Fname.AutoSize = true;
            Label_Fname.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            Label_Fname.Location = new Point(178, 100);
            Label_Fname.Name = "Label_Fname";
            Label_Fname.Size = new Size(203, 40);
            Label_Fname.TabIndex = 24;
            Label_Fname.Text = "FIRST NAME :";
            // 
            // linkLabel_Signup
            // 
            linkLabel_Signup.AutoSize = true;
            linkLabel_Signup.Location = new Point(633, 468);
            linkLabel_Signup.Name = "linkLabel_Signup";
            linkLabel_Signup.Size = new Size(213, 15);
            linkLabel_Signup.TabIndex = 13;
            linkLabel_Signup.TabStop = true;
            linkLabel_Signup.Text = "Already have an account? Log In here...";
            linkLabel_Signup.LinkClicked += linkLabel_Signup_LinkClicked;
            // 
            // TextBox_Pin
            // 
            TextBox_Pin.BackColor = SystemColors.Window;
            TextBox_Pin.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            TextBox_Pin.Location = new Point(460, 421);
            TextBox_Pin.Name = "TextBox_Pin";
            TextBox_Pin.Size = new Size(396, 39);
            TextBox_Pin.TabIndex = 12;
            TextBox_Pin.UseSystemPasswordChar = true;
            TextBox_Pin.WordWrap = false;
            TextBox_Pin.TextChanged += TextBox_Pin_TextChanged;
            // 
            // Label_ForgotPass
            // 
            Label_ForgotPass.AutoSize = true;
            Label_ForgotPass.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            Label_ForgotPass.Location = new Point(178, 421);
            Label_ForgotPass.Name = "Label_ForgotPass";
            Label_ForgotPass.Size = new Size(282, 40);
            Label_ForgotPass.TabIndex = 13;
            Label_ForgotPass.Text = "FORGOT PASS PIN :";
            // 
            // Label_Gender
            // 
            Label_Gender.AutoSize = true;
            Label_Gender.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            Label_Gender.Location = new Point(179, 283);
            Label_Gender.Name = "Label_Gender";
            Label_Gender.Size = new Size(169, 40);
            Label_Gender.TabIndex = 17;
            Label_Gender.Text = "POSITION :";
            // 
            // RadioButton_Male
            // 
            RadioButton_Male.AutoSize = true;
            RadioButton_Male.Font = new Font("Segoe UI", 18.75F);
            RadioButton_Male.Location = new Point(461, 287);
            RadioButton_Male.Name = "RadioButton_Male";
            RadioButton_Male.Size = new Size(202, 39);
            RadioButton_Male.TabIndex = 6;
            RadioButton_Male.TabStop = true;
            RadioButton_Male.Text = "VETERINARIAN";
            RadioButton_Male.UseVisualStyleBackColor = true;
            RadioButton_Male.CheckedChanged += RadioButton_Male_CheckedChanged;
            // 
            // RadioButton_Female
            // 
            RadioButton_Female.AutoSize = true;
            RadioButton_Female.Font = new Font("Segoe UI", 18.75F);
            RadioButton_Female.Location = new Point(683, 287);
            RadioButton_Female.Name = "RadioButton_Female";
            RadioButton_Female.Size = new Size(97, 39);
            RadioButton_Female.TabIndex = 7;
            RadioButton_Female.TabStop = true;
            RadioButton_Female.Text = "STAFF";
            RadioButton_Female.UseVisualStyleBackColor = true;
            RadioButton_Female.CheckedChanged += RadioButton_Female_CheckedChanged;
            // 
            // PictureBox_PasswordViewer
            // 
            PictureBox_PasswordViewer.BackColor = SystemColors.ButtonHighlight;
            PictureBox_PasswordViewer.Image = (Image)resources.GetObject("PictureBox_PasswordViewer.Image");
            PictureBox_PasswordViewer.Location = new Point(817, 432);
            PictureBox_PasswordViewer.Name = "PictureBox_PasswordViewer";
            PictureBox_PasswordViewer.Size = new Size(29, 24);
            PictureBox_PasswordViewer.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox_PasswordViewer.TabIndex = 25;
            PictureBox_PasswordViewer.TabStop = false;
            PictureBox_PasswordViewer.Click += PictureBox_PasswordViewer_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(817, 385);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(29, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ButtonHighlight;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(817, 340);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(29, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 27;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 681);
            Controls.Add(PictureBox_PasswordViewer);
            Controls.Add(TextBox_Pin);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(Label_ForgotPass);
            Controls.Add(RadioButton_Female);
            Controls.Add(linkLabel_Signup);
            Controls.Add(RadioButton_Male);
            Controls.Add(TextBox_ConfirmPass);
            Controls.Add(TextBox_Password);
            Controls.Add(TextBox_Email);
            Controls.Add(TextBox_Lname);
            Controls.Add(TextBox_Mname);
            Controls.Add(TextBox_Fname);
            Controls.Add(Button_Signin);
            Controls.Add(Label_Password);
            Controls.Add(Label_Gender);
            Controls.Add(Label_Mname);
            Controls.Add(Label_ConfirmPass);
            Controls.Add(label3);
            Controls.Add(Label_Email);
            Controls.Add(Label_Lname);
            Controls.Add(Label_Fname);
            Name = "Signup";
            Text = "Form1";
            WindowState = FormWindowState.Minimized;
            Load += Signup_Load;
            ((System.ComponentModel.ISupportInitialize)PictureBox_PasswordViewer).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox TextBox_ConfirmPass;
        private TextBox TextBox_Password;
        private TextBox TextBox_Email;
        private TextBox TextBox_Lname;
        private TextBox TextBox_Mname;
        private TextBox TextBox_Fname;
        private Button Button_Signin;
        private Label Label_Password;
        private Label Label_Mname;
        private Label Label_ConfirmPass;
        private Label label3;
        private Label Label_Email;
        private Label Label_Lname;
        private Label Label_Fname;
        private LinkLabel linkLabel_Signup;
        private DateTimePicker dateTimePicker1;
        private TextBox TextBox_Pin;
        private Label Label_ForgotPass;
        private Label Label_Gender;
        private RadioButton RadioButton_Male;
        private RadioButton RadioButton_Female;
        private PictureBox PictureBox_PasswordViewer;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}