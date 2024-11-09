namespace CLINIC
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            LinkLabel_Signup = new LinkLabel();
            TextBox_Password = new TextBox();
            TextBox_Email = new TextBox();
            Button_Login = new Button();
            Label_Email = new Label();
            Label_Password = new Label();
            Label_Welcome = new Label();
            LinkLabel_ChangePassword = new LinkLabel();
            PictureBox_PasswordViewer = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PictureBox_PasswordViewer).BeginInit();
            SuspendLayout();
            // 
            // LinkLabel_Signup
            // 
            LinkLabel_Signup.AutoSize = true;
            LinkLabel_Signup.Location = new Point(616, 381);
            LinkLabel_Signup.Name = "LinkLabel_Signup";
            LinkLabel_Signup.Size = new Size(178, 15);
            LinkLabel_Signup.TabIndex = 4;
            LinkLabel_Signup.TabStop = true;
            LinkLabel_Signup.Text = "Don't have an account? Sign Up!";
            LinkLabel_Signup.LinkClicked += LinkLabel_Signup_LinkClicked;
            // 
            // TextBox_Password
            // 
            TextBox_Password.BackColor = SystemColors.Window;
            TextBox_Password.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            TextBox_Password.ForeColor = SystemColors.WindowText;
            TextBox_Password.Location = new Point(398, 321);
            TextBox_Password.Name = "TextBox_Password";
            TextBox_Password.Size = new Size(396, 39);
            TextBox_Password.TabIndex = 2;
            TextBox_Password.UseSystemPasswordChar = true;
            TextBox_Password.WordWrap = false;
            TextBox_Password.TextChanged += TextBox_Password_TextChanged;
            // 
            // TextBox_Email
            // 
            TextBox_Email.BackColor = SystemColors.Window;
            TextBox_Email.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            TextBox_Email.Location = new Point(398, 257);
            TextBox_Email.Name = "TextBox_Email";
            TextBox_Email.Size = new Size(396, 39);
            TextBox_Email.TabIndex = 1;
            TextBox_Email.TextChanged += TextBox_Email_TextChanged;
            // 
            // Button_Login
            // 
            Button_Login.Enabled = false;
            Button_Login.Font = new Font("Quadrat-Serial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Button_Login.Location = new Point(496, 433);
            Button_Login.Name = "Button_Login";
            Button_Login.Size = new Size(189, 75);
            Button_Login.TabIndex = 5;
            Button_Login.Text = "LOG IN!";
            Button_Login.UseVisualStyleBackColor = true;
            Button_Login.Click += Button_Login_Click;
            // 
            // Label_Email
            // 
            Label_Email.AutoSize = true;
            Label_Email.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            Label_Email.Location = new Point(192, 257);
            Label_Email.Name = "Label_Email";
            Label_Email.Size = new Size(128, 40);
            Label_Email.TabIndex = 6;
            Label_Email.Text = "EMAIL : ";
            // 
            // Label_Password
            // 
            Label_Password.AutoSize = true;
            Label_Password.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            Label_Password.Location = new Point(192, 321);
            Label_Password.Name = "Label_Password";
            Label_Password.Size = new Size(200, 40);
            Label_Password.TabIndex = 7;
            Label_Password.Text = "PASSWORD : ";
            // 
            // Label_Welcome
            // 
            Label_Welcome.AutoSize = true;
            Label_Welcome.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            Label_Welcome.Location = new Point(430, 160);
            Label_Welcome.Name = "Label_Welcome";
            Label_Welcome.Size = new Size(304, 40);
            Label_Welcome.TabIndex = 8;
            Label_Welcome.Text = "WELCOME TO CLINIC";
            // 
            // LinkLabel_ChangePassword
            // 
            LinkLabel_ChangePassword.AutoSize = true;
            LinkLabel_ChangePassword.Location = new Point(398, 381);
            LinkLabel_ChangePassword.Name = "LinkLabel_ChangePassword";
            LinkLabel_ChangePassword.Size = new Size(100, 15);
            LinkLabel_ChangePassword.TabIndex = 3;
            LinkLabel_ChangePassword.TabStop = true;
            LinkLabel_ChangePassword.Text = "Forgot Password?";
            LinkLabel_ChangePassword.LinkClicked += LinkLabel_ChangePassword_LinkClicked;
            // 
            // PictureBox_PasswordViewer
            // 
            PictureBox_PasswordViewer.BackColor = SystemColors.ButtonHighlight;
            PictureBox_PasswordViewer.Image = (Image)resources.GetObject("PictureBox_PasswordViewer.Image");
            PictureBox_PasswordViewer.Location = new Point(760, 328);
            PictureBox_PasswordViewer.Name = "PictureBox_PasswordViewer";
            PictureBox_PasswordViewer.Size = new Size(29, 24);
            PictureBox_PasswordViewer.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox_PasswordViewer.TabIndex = 9;
            PictureBox_PasswordViewer.TabStop = false;  
            PictureBox_PasswordViewer.Click += pictureBox1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 681);
            Controls.Add(PictureBox_PasswordViewer);
            Controls.Add(LinkLabel_ChangePassword);
            Controls.Add(LinkLabel_Signup);
            Controls.Add(TextBox_Password);
            Controls.Add(TextBox_Email);
            Controls.Add(Button_Login);
            Controls.Add(Label_Email);
            Controls.Add(Label_Password);
            Controls.Add(Label_Welcome);
            Name = "Login";
            Text = " ";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)PictureBox_PasswordViewer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel LinkLabel_Signup;
        private TextBox TextBox_Password;
        private TextBox TextBox_Email;
        private Button Button_Login;
        private Label Label_Email;
        private Label Label_Password;
        private Label Label_Welcome;
        private LinkLabel LinkLabel_ChangePassword;
        private PictureBox PictureBox_PasswordViewer;
    }
}
