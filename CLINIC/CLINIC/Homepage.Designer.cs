namespace CLINIC
{
    partial class Homepage
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
            Label_Welcome = new Label();
            Label_Username = new Label();
            Label_Appointment = new Label();
            Label_History = new Label();
            Label_ManageAccount = new Label();
            Label_Homepage = new Label();
            Label_HistoryText = new Label();
            monthCalendar1 = new MonthCalendar();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // Label_Welcome
            // 
            Label_Welcome.AutoSize = true;
            Label_Welcome.Font = new Font("Sitka Subheading", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Label_Welcome.Location = new Point(218, 19);
            Label_Welcome.Name = "Label_Welcome";
            Label_Welcome.Size = new Size(286, 69);
            Label_Welcome.TabIndex = 1;
            Label_Welcome.Text = "WELCOME!";
            // 
            // Label_Username
            // 
            Label_Username.AutoSize = true;
            Label_Username.Font = new Font("Sitka Subheading", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Label_Username.Location = new Point(218, 88);
            Label_Username.Name = "Label_Username";
            Label_Username.Size = new Size(268, 53);
            Label_Username.TabIndex = 2;
            Label_Username.Text = "@GMAIL.COM";
            // 
            // Label_Appointment
            // 
            Label_Appointment.AutoSize = true;
            Label_Appointment.BackColor = SystemColors.Control;
            Label_Appointment.BorderStyle = BorderStyle.Fixed3D;
            Label_Appointment.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            Label_Appointment.ForeColor = SystemColors.ControlText;
            Label_Appointment.Location = new Point(561, 155);
            Label_Appointment.Name = "Label_Appointment";
            Label_Appointment.Size = new Size(119, 27);
            Label_Appointment.TabIndex = 4;
            Label_Appointment.Text = "Add Record";
            Label_Appointment.Click += label1_Click;
            // 
            // Label_History
            // 
            Label_History.AutoSize = true;
            Label_History.BorderStyle = BorderStyle.Fixed3D;
            Label_History.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            Label_History.Location = new Point(696, 155);
            Label_History.Name = "Label_History";
            Label_History.Size = new Size(156, 27);
            Label_History.TabIndex = 5;
            Label_History.Text = "History Records";
            Label_History.Click += Label_History_Click;
            // 
            // Label_ManageAccount
            // 
            Label_ManageAccount.AutoSize = true;
            Label_ManageAccount.BorderStyle = BorderStyle.Fixed3D;
            Label_ManageAccount.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            Label_ManageAccount.Location = new Point(868, 155);
            Label_ManageAccount.Name = "Label_ManageAccount";
            Label_ManageAccount.Size = new Size(165, 27);
            Label_ManageAccount.TabIndex = 6;
            Label_ManageAccount.Text = "Manage Account";
            // 
            // Label_Homepage
            // 
            Label_Homepage.AutoSize = true;
            Label_Homepage.BackColor = SystemColors.Control;
            Label_Homepage.BorderStyle = BorderStyle.Fixed3D;
            Label_Homepage.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            Label_Homepage.ForeColor = SystemColors.ControlText;
            Label_Homepage.Location = new Point(432, 155);
            Label_Homepage.Name = "Label_Homepage";
            Label_Homepage.Size = new Size(112, 27);
            Label_Homepage.TabIndex = 10;
            Label_Homepage.Text = "Homepage";
            // 
            // Label_HistoryText
            // 
            Label_HistoryText.AutoSize = true;
            Label_HistoryText.Font = new Font("Sitka Subheading", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Label_HistoryText.Location = new Point(257, 223);
            Label_HistoryText.Name = "Label_HistoryText";
            Label_HistoryText.Size = new Size(306, 53);
            Label_HistoryText.TabIndex = 23;
            Label_HistoryText.Text = "Daily Dashboard";
            Label_HistoryText.Visible = false;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(18, 279);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 25;
            monthCalendar1.TodayDate = new DateTime(2024, 11, 13, 0, 0, 0, 0);
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(257, 279);
            panel1.Name = "panel1";
            panel1.Size = new Size(306, 265);
            panel1.TabIndex = 26;
            // 
            // Homepage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 681);
            Controls.Add(panel1);
            Controls.Add(monthCalendar1);
            Controls.Add(Label_HistoryText);
            Controls.Add(Label_Homepage);
            Controls.Add(Label_ManageAccount);
            Controls.Add(Label_History);
            Controls.Add(Label_Appointment);
            Controls.Add(Label_Username);
            Controls.Add(Label_Welcome);
            Name = "Homepage";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Label_Welcome;
        private Label Label_Username;
        private Label Label_Appointment;
        private Label Label_History;
        private Label Label_ManageAccount;
        private Label Label_Homepage;
        private Label Label_HistoryText;
        private MonthCalendar monthCalendar1;
        private Panel panel1;
    }
}