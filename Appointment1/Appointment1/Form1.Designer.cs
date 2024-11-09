namespace Appointment1
{
    partial class Date_Form
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
            lblAppointment = new Label();
            lblDate = new Label();
            cbdate = new ComboBox();
            cbTime = new ComboBox();
            lblTime = new Label();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // lblAppointment
            // 
            lblAppointment.AutoSize = true;
            lblAppointment.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAppointment.ForeColor = SystemColors.ControlText;
            lblAppointment.Location = new Point(429, 59);
            lblAppointment.Name = "lblAppointment";
            lblAppointment.Size = new Size(170, 29);
            lblAppointment.TabIndex = 0;
            lblAppointment.Text = "Appointment";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.ForeColor = SystemColors.ControlText;
            lblDate.Location = new Point(481, 107);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(71, 29);
            lblDate.TabIndex = 1;
            lblDate.Text = "Date";
            // 
            // cbdate
            // 
            cbdate.FormattingEnabled = true;
            cbdate.Location = new Point(353, 206);
            cbdate.Name = "cbdate";
            cbdate.Size = new Size(299, 28);
            cbdate.TabIndex = 2;
            // 
            // cbTime
            // 
            cbTime.FormattingEnabled = true;
            cbTime.Location = new Point(429, 355);
            cbTime.Name = "cbTime";
            cbTime.Size = new Size(187, 28);
            cbTime.TabIndex = 4;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTime.ForeColor = SystemColors.ControlText;
            lblTime.Location = new Point(485, 311);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(67, 29);
            lblTime.TabIndex = 5;
            lblTime.Text = "Time";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(474, 452);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 7;
            btnSubmit.Text = "Next";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // Date_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 673);
            Controls.Add(btnSubmit);
            Controls.Add(lblTime);
            Controls.Add(cbTime);
            Controls.Add(cbdate);
            Controls.Add(lblDate);
            Controls.Add(lblAppointment);
            Name = "Date_Form";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppointment;
        private Label lblDate;
        private ComboBox cbdate;
        private ComboBox cbTime;
        private Label lblTime;
        private Button btnSubmit;
    }
}
