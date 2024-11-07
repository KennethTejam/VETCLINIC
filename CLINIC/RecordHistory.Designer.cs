namespace CLINIC
{
    partial class RecordHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecordHistory));
            Label_HistoryText = new Label();
            Label_Homepage = new Label();
            Label_ManageAccount = new Label();
            Label_AddRecord = new Label();
            Label_HistoryRecords = new Label();
            Label_Username = new Label();
            Label_Welcome = new Label();
            Clinic_MainLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Clinic_MainLogo).BeginInit();
            SuspendLayout();
            // 
            // Label_HistoryText
            // 
            Label_HistoryText.AutoSize = true;
            Label_HistoryText.Font = new Font("Sitka Subheading", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Label_HistoryText.Location = new Point(193, 228);
            Label_HistoryText.Name = "Label_HistoryText";
            Label_HistoryText.Size = new Size(306, 53);
            Label_HistoryText.TabIndex = 30;
            Label_HistoryText.Text = "Daily Dashboard";
            Label_HistoryText.Visible = false;
            // 
            // Label_Homepage
            // 
            Label_Homepage.AutoSize = true;
            Label_Homepage.BackColor = SystemColors.Control;
            Label_Homepage.BorderStyle = BorderStyle.Fixed3D;
            Label_Homepage.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            Label_Homepage.ForeColor = SystemColors.ControlText;
            Label_Homepage.Location = new Point(398, 147);
            Label_Homepage.Name = "Label_Homepage";
            Label_Homepage.Size = new Size(112, 27);
            Label_Homepage.TabIndex = 29;
            Label_Homepage.Text = "Homepage";
            Label_Homepage.Click += Label_Homepage_Click;
            // 
            // Label_ManageAccount
            // 
            Label_ManageAccount.AutoSize = true;
            Label_ManageAccount.BorderStyle = BorderStyle.Fixed3D;
            Label_ManageAccount.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            Label_ManageAccount.Location = new Point(827, 147);
            Label_ManageAccount.Name = "Label_ManageAccount";
            Label_ManageAccount.Size = new Size(165, 27);
            Label_ManageAccount.TabIndex = 28;
            Label_ManageAccount.Text = "Manage Account";
            // 
            // Label_AddRecord
            // 
            Label_AddRecord.AutoSize = true;
            Label_AddRecord.BorderStyle = BorderStyle.Fixed3D;
            Label_AddRecord.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            Label_AddRecord.Location = new Point(516, 147);
            Label_AddRecord.Name = "Label_AddRecord";
            Label_AddRecord.Size = new Size(143, 27);
            Label_AddRecord.TabIndex = 27;
            Label_AddRecord.Text = "Add to Record";
            Label_AddRecord.Click += Label_AddRecord_Click;
            // 
            // Label_HistoryRecords
            // 
            Label_HistoryRecords.AutoSize = true;
            Label_HistoryRecords.BackColor = SystemColors.Control;
            Label_HistoryRecords.BorderStyle = BorderStyle.Fixed3D;
            Label_HistoryRecords.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            Label_HistoryRecords.ForeColor = SystemColors.ControlText;
            Label_HistoryRecords.Location = new Point(665, 147);
            Label_HistoryRecords.Name = "Label_HistoryRecords";
            Label_HistoryRecords.Size = new Size(156, 27);
            Label_HistoryRecords.TabIndex = 26;
            Label_HistoryRecords.Text = "History Records";
            // 
            // Label_Username
            // 
            Label_Username.AutoSize = true;
            Label_Username.Font = new Font("Sitka Subheading", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Label_Username.Location = new Point(218, 80);
            Label_Username.Name = "Label_Username";
            Label_Username.Size = new Size(268, 53);
            Label_Username.TabIndex = 25;
            Label_Username.Text = "@GMAIL.COM";
            // 
            // Label_Welcome
            // 
            Label_Welcome.AutoSize = true;
            Label_Welcome.Font = new Font("Sitka Subheading", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Label_Welcome.Location = new Point(218, 11);
            Label_Welcome.Name = "Label_Welcome";
            Label_Welcome.Size = new Size(286, 69);
            Label_Welcome.TabIndex = 24;
            Label_Welcome.Text = "WELCOME!";
            // 
            // Clinic_MainLogo
            // 
            Clinic_MainLogo.Image = (Image)resources.GetObject("Clinic_MainLogo.Image");
            Clinic_MainLogo.Location = new Point(12, 24);
            Clinic_MainLogo.Name = "Clinic_MainLogo";
            Clinic_MainLogo.Size = new Size(164, 150);
            Clinic_MainLogo.SizeMode = PictureBoxSizeMode.Zoom;
            Clinic_MainLogo.TabIndex = 23;
            Clinic_MainLogo.TabStop = false;
            // 
            // RecordHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 681);
            Controls.Add(Label_HistoryText);
            Controls.Add(Label_Homepage);
            Controls.Add(Label_ManageAccount);
            Controls.Add(Label_AddRecord);
            Controls.Add(Label_HistoryRecords);
            Controls.Add(Label_Username);
            Controls.Add(Label_Welcome);
            Controls.Add(Clinic_MainLogo);
            Name = "RecordHistory";
            Text = "RecordHistory";
            ((System.ComponentModel.ISupportInitialize)Clinic_MainLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label_HistoryText;
        private Label Label_Homepage;
        private Label Label_ManageAccount;
        private Label Label_AddRecord;
        private Label Label_HistoryRecords;
        private Label Label_Username;
        private Label Label_Welcome;
        private PictureBox Clinic_MainLogo;
    }
}