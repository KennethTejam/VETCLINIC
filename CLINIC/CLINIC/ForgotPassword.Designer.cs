namespace CLINIC
{
    partial class ForgotPassword
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
            LinkLabel_GotoLogin = new LinkLabel();
            LinkLabel_Signup = new LinkLabel();
            TextBox_PinNoAccount = new TextBox();
            TextBox_Email = new TextBox();
            Label_Email = new Label();
            Label_PinNoAccount = new Label();
            Label_Welcome = new Label();
            TextBox_Password = new TextBox();
            label1 = new Label();
            TextBox_ConfirmPass = new TextBox();
            label2 = new Label();
            Button_ConfirmWithAccount = new Button();
            Button_ProceedWithAccount = new Button();
            SuspendLayout();
            // 
            // LinkLabel_GotoLogin
            // 
            LinkLabel_GotoLogin.AutoSize = true;
            LinkLabel_GotoLogin.Location = new Point(171, 599);
            LinkLabel_GotoLogin.Name = "LinkLabel_GotoLogin";
            LinkLabel_GotoLogin.Size = new Size(208, 15);
            LinkLabel_GotoLogin.TabIndex = 7;
            LinkLabel_GotoLogin.TabStop = true;
            LinkLabel_GotoLogin.Text = "Already Have an account? Login Here!";
            LinkLabel_GotoLogin.LinkClicked += LinkLabel_GotoLogin_LinkClicked;
            // 
            // LinkLabel_Signup
            // 
            LinkLabel_Signup.AutoSize = true;
            LinkLabel_Signup.Location = new Point(721, 599);
            LinkLabel_Signup.Name = "LinkLabel_Signup";
            LinkLabel_Signup.Size = new Size(178, 15);
            LinkLabel_Signup.TabIndex = 8;
            LinkLabel_Signup.TabStop = true;
            LinkLabel_Signup.Text = "Don't have an account? Sign Up!";
            LinkLabel_Signup.LinkClicked += LinkLabel_Signup_LinkClicked;
            // 
            // TextBox_PinNoAccount
            // 
            TextBox_PinNoAccount.BackColor = SystemColors.Window;
            TextBox_PinNoAccount.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            TextBox_PinNoAccount.ForeColor = SystemColors.WindowText;
            TextBox_PinNoAccount.Location = new Point(503, 229);
            TextBox_PinNoAccount.Name = "TextBox_PinNoAccount";
            TextBox_PinNoAccount.Size = new Size(396, 39);
            TextBox_PinNoAccount.TabIndex = 2;
            TextBox_PinNoAccount.UseSystemPasswordChar = true;
            // 
            // TextBox_Email
            // 
            TextBox_Email.BackColor = SystemColors.Window;
            TextBox_Email.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            TextBox_Email.Location = new Point(503, 163);
            TextBox_Email.Name = "TextBox_Email";
            TextBox_Email.Size = new Size(396, 39);
            TextBox_Email.TabIndex = 1;
            // 
            // Label_Email
            // 
            Label_Email.AutoSize = true;
            Label_Email.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            Label_Email.Location = new Point(171, 163);
            Label_Email.Name = "Label_Email";
            Label_Email.Size = new Size(128, 40);
            Label_Email.TabIndex = 9;
            Label_Email.Text = "EMAIL : ";
            // 
            // Label_PinNoAccount
            // 
            Label_PinNoAccount.AutoSize = true;
            Label_PinNoAccount.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            Label_PinNoAccount.Location = new Point(171, 229);
            Label_PinNoAccount.Name = "Label_PinNoAccount";
            Label_PinNoAccount.Size = new Size(83, 40);
            Label_PinNoAccount.TabIndex = 10;
            Label_PinNoAccount.Text = "PIN :";
            // 
            // Label_Welcome
            // 
            Label_Welcome.AutoSize = true;
            Label_Welcome.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            Label_Welcome.Location = new Point(406, 76);
            Label_Welcome.Name = "Label_Welcome";
            Label_Welcome.Size = new Size(258, 40);
            Label_Welcome.TabIndex = 11;
            Label_Welcome.Text = "Change Password";
            // 
            // TextBox_Password
            // 
            TextBox_Password.BackColor = SystemColors.Window;
            TextBox_Password.Enabled = false;
            TextBox_Password.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            TextBox_Password.ForeColor = SystemColors.WindowText;
            TextBox_Password.Location = new Point(503, 317);
            TextBox_Password.Name = "TextBox_Password";
            TextBox_Password.Size = new Size(396, 39);
            TextBox_Password.TabIndex = 3;
            TextBox_Password.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            label1.Location = new Point(171, 317);
            label1.Name = "label1";
            label1.Size = new Size(200, 40);
            label1.TabIndex = 8;
            label1.Text = "PASSWORD : ";
            // 
            // TextBox_ConfirmPass
            // 
            TextBox_ConfirmPass.BackColor = SystemColors.Window;
            TextBox_ConfirmPass.Enabled = false;
            TextBox_ConfirmPass.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            TextBox_ConfirmPass.ForeColor = SystemColors.WindowText;
            TextBox_ConfirmPass.Location = new Point(503, 381);
            TextBox_ConfirmPass.Name = "TextBox_ConfirmPass";
            TextBox_ConfirmPass.Size = new Size(396, 39);
            TextBox_ConfirmPass.TabIndex = 4;
            TextBox_ConfirmPass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            label2.Location = new Point(171, 378);
            label2.Name = "label2";
            label2.Size = new Size(342, 40);
            label2.TabIndex = 7;
            label2.Text = "CONFIRM PASSWORD : ";
            // 
            // Button_ConfirmWithAccount
            // 
            Button_ConfirmWithAccount.Font = new Font("Quadrat-Serial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Button_ConfirmWithAccount.Location = new Point(710, 452);
            Button_ConfirmWithAccount.Name = "Button_ConfirmWithAccount";
            Button_ConfirmWithAccount.Size = new Size(189, 75);
            Button_ConfirmWithAccount.TabIndex = 21;
            Button_ConfirmWithAccount.Text = "Confirm";
            Button_ConfirmWithAccount.UseVisualStyleBackColor = true;
            Button_ConfirmWithAccount.Visible = false;
            Button_ConfirmWithAccount.Click += Button_ConfirmWithAccount_Click;
            // 
            // Button_ProceedWithAccount
            // 
            Button_ProceedWithAccount.Font = new Font("Quadrat-Serial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Button_ProceedWithAccount.Location = new Point(503, 452);
            Button_ProceedWithAccount.Name = "Button_ProceedWithAccount";
            Button_ProceedWithAccount.Size = new Size(189, 75);
            Button_ProceedWithAccount.TabIndex = 20;
            Button_ProceedWithAccount.Text = "Proceed";
            Button_ProceedWithAccount.UseVisualStyleBackColor = true;
            Button_ProceedWithAccount.Click += Button_ProceedWithAccount_Click;
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 681);
            Controls.Add(Button_ConfirmWithAccount);
            Controls.Add(Button_ProceedWithAccount);
            Controls.Add(TextBox_ConfirmPass);
            Controls.Add(label2);
            Controls.Add(TextBox_Password);
            Controls.Add(label1);
            Controls.Add(LinkLabel_GotoLogin);
            Controls.Add(LinkLabel_Signup);
            Controls.Add(TextBox_PinNoAccount);
            Controls.Add(TextBox_Email);
            Controls.Add(Label_Email);
            Controls.Add(Label_PinNoAccount);
            Controls.Add(Label_Welcome);
            Name = "ForgotPassword";
            Text = "Form1";
            Load += ForgotPassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel LinkLabel_GotoLogin;
        private LinkLabel LinkLabel_Signup;
        private TextBox TextBox_PinNoAccount;
        private TextBox TextBox_Email;
        private Label Label_Email;
        private Label Label_PinNoAccount;
        private Label Label_Welcome;
        private TextBox TextBox_Password;
        private Label label1;
        private TextBox TextBox_ConfirmPass;
        private Label label2;
        private Button Button_ConfirmWithAccount;
        private Button Button_ProceedWithAccount;
    }
}