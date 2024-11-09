namespace Appointment1
{
    partial class Info_Form
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
            lblInfo = new Label();
            lblAppointment = new Label();
            btnSubmit = new Button();
            txtLname = new TextBox();
            txtFname = new TextBox();
            txtMname = new TextBox();
            txtBirthday = new TextBox();
            txtGender = new TextBox();
            txtEmail = new TextBox();
            txtContact = new TextBox();
            txtNote = new TextBox();
            SuspendLayout();
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInfo.ForeColor = SystemColors.ControlText;
            lblInfo.Location = new Point(259, 87);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(285, 29);
            lblInfo.TabIndex = 3;
            lblInfo.Text = "Personal Information";
            // 
            // lblAppointment
            // 
            lblAppointment.AutoSize = true;
            lblAppointment.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAppointment.ForeColor = SystemColors.ControlText;
            lblAppointment.Location = new Point(312, 38);
            lblAppointment.Name = "lblAppointment";
            lblAppointment.Size = new Size(170, 29);
            lblAppointment.TabIndex = 2;
            lblAppointment.Text = "Appointment";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(506, 391);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "Next";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtLname
            // 
            txtLname.Location = new Point(124, 155);
            txtLname.Name = "txtLname";
            txtLname.ReadOnly = true;
            txtLname.Size = new Size(125, 27);
            txtLname.TabIndex = 5;
            // 
            // txtFname
            // 
            txtFname.Location = new Point(259, 155);
            txtFname.Name = "txtFname";
            txtFname.ReadOnly = true;
            txtFname.Size = new Size(125, 27);
            txtFname.TabIndex = 6;
            // 
            // txtMname
            // 
            txtMname.Location = new Point(390, 155);
            txtMname.Name = "txtMname";
            txtMname.ReadOnly = true;
            txtMname.Size = new Size(125, 27);
            txtMname.TabIndex = 7;
            // 
            // txtBirthday
            // 
            txtBirthday.Location = new Point(124, 254);
            txtBirthday.Name = "txtBirthday";
            txtBirthday.ReadOnly = true;
            txtBirthday.Size = new Size(125, 27);
            txtBirthday.TabIndex = 8;
            // 
            // txtGender
            // 
            txtGender.Location = new Point(124, 188);
            txtGender.Name = "txtGender";
            txtGender.ReadOnly = true;
            txtGender.Size = new Size(125, 27);
            txtGender.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(124, 221);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 9;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(124, 287);
            txtContact.Name = "txtContact";
            txtContact.ReadOnly = true;
            txtContact.Size = new Size(125, 27);
            txtContact.TabIndex = 10;
            // 
            // txtNote
            // 
            txtNote.Location = new Point(124, 331);
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(347, 89);
            txtNote.TabIndex = 11;
            // 
            // Info_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNote);
            Controls.Add(txtContact);
            Controls.Add(txtEmail);
            Controls.Add(txtGender);
            Controls.Add(txtBirthday);
            Controls.Add(txtMname);
            Controls.Add(txtFname);
            Controls.Add(txtLname);
            Controls.Add(btnSubmit);
            Controls.Add(lblInfo);
            Controls.Add(lblAppointment);
            Name = "Info_Form";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxTimes;
        private ComboBox cbTime;
        private Label lblInfo;
        private Label lblAppointment;
        private Button btnSubmit;
        private TextBox txtLname;
        private TextBox txtFname;
        private TextBox txtMname;
        private TextBox txtBirthday;
        private TextBox txtGender;
        private TextBox txtEmail;
        private TextBox txtContact;
        private TextBox txtNote;
    }
}