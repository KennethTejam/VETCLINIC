namespace CLINIC
{
    partial class PatientInfoForm
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
            TextBox_OwnerName = new TextBox();
            TextBox_PetName = new TextBox();
            TextBox_PetBreed = new TextBox();
            TextBox_Age = new TextBox();
            TextBox_Gender = new TextBox();
            TextBox_Contact = new TextBox();
            TextBox_Email = new TextBox();
            TextBox_AppointmentDate = new TextBox();
            TextBox_AppointmentTime = new TextBox();
            TextBox_Status = new TextBox();
            SuspendLayout();
            // 
            // TextBox_OwnerName
            // 
            TextBox_OwnerName.Enabled = false;
            TextBox_OwnerName.Location = new Point(200, 31);
            TextBox_OwnerName.Name = "TextBox_OwnerName";
            TextBox_OwnerName.Size = new Size(370, 23);
            TextBox_OwnerName.TabIndex = 0;
            // 
            // TextBox_PetName
            // 
            TextBox_PetName.Enabled = false;
            TextBox_PetName.Location = new Point(200, 60);
            TextBox_PetName.Name = "TextBox_PetName";
            TextBox_PetName.Size = new Size(370, 23);
            TextBox_PetName.TabIndex = 1;
            // 
            // TextBox_PetBreed
            // 
            TextBox_PetBreed.Enabled = false;
            TextBox_PetBreed.Location = new Point(200, 89);
            TextBox_PetBreed.Name = "TextBox_PetBreed";
            TextBox_PetBreed.Size = new Size(370, 23);
            TextBox_PetBreed.TabIndex = 2;
            // 
            // TextBox_Age
            // 
            TextBox_Age.Enabled = false;
            TextBox_Age.Location = new Point(200, 118);
            TextBox_Age.Name = "TextBox_Age";
            TextBox_Age.Size = new Size(370, 23);
            TextBox_Age.TabIndex = 3;
            // 
            // TextBox_Gender
            // 
            TextBox_Gender.Enabled = false;
            TextBox_Gender.Location = new Point(200, 147);
            TextBox_Gender.Name = "TextBox_Gender";
            TextBox_Gender.Size = new Size(370, 23);
            TextBox_Gender.TabIndex = 4;
            // 
            // TextBox_Contact
            // 
            TextBox_Contact.Enabled = false;
            TextBox_Contact.Location = new Point(200, 176);
            TextBox_Contact.Name = "TextBox_Contact";
            TextBox_Contact.Size = new Size(370, 23);
            TextBox_Contact.TabIndex = 5;
            // 
            // TextBox_Email
            // 
            TextBox_Email.Enabled = false;
            TextBox_Email.Location = new Point(200, 205);
            TextBox_Email.Name = "TextBox_Email";
            TextBox_Email.Size = new Size(370, 23);
            TextBox_Email.TabIndex = 6;
            // 
            // TextBox_AppointmentDate
            // 
            TextBox_AppointmentDate.Enabled = false;
            TextBox_AppointmentDate.Location = new Point(200, 234);
            TextBox_AppointmentDate.Name = "TextBox_AppointmentDate";
            TextBox_AppointmentDate.Size = new Size(370, 23);
            TextBox_AppointmentDate.TabIndex = 7;
            // 
            // TextBox_AppointmentTime
            // 
            TextBox_AppointmentTime.Enabled = false;
            TextBox_AppointmentTime.Location = new Point(200, 263);
            TextBox_AppointmentTime.Name = "TextBox_AppointmentTime";
            TextBox_AppointmentTime.Size = new Size(370, 23);
            TextBox_AppointmentTime.TabIndex = 8;
            // 
            // TextBox_Status
            // 
            TextBox_Status.Enabled = false;
            TextBox_Status.Location = new Point(200, 292);
            TextBox_Status.Name = "TextBox_Status";
            TextBox_Status.Size = new Size(370, 23);
            TextBox_Status.TabIndex = 9;
            // 
            // PatientInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TextBox_Status);
            Controls.Add(TextBox_AppointmentTime);
            Controls.Add(TextBox_AppointmentDate);
            Controls.Add(TextBox_Email);
            Controls.Add(TextBox_Contact);
            Controls.Add(TextBox_Gender);
            Controls.Add(TextBox_Age);
            Controls.Add(TextBox_PetBreed);
            Controls.Add(TextBox_PetName);
            Controls.Add(TextBox_OwnerName);
            Name = "PatientInfoForm";
            Text = "PatientInfoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBox_OwnerName;
        private TextBox TextBox_PetName;
        private TextBox TextBox_PetBreed;
        private TextBox TextBox_Age;
        private TextBox TextBox_Gender;
        private TextBox TextBox_Contact;
        private TextBox TextBox_Email;
        private TextBox TextBox_AppointmentDate;
        private TextBox TextBox_AppointmentTime;
        private TextBox TextBox_Status;
    }
}