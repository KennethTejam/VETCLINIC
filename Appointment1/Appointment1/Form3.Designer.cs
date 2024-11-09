namespace Appointment1
{
    partial class Summary_Form
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
            lblSummary = new Label();
            lblAppointment = new Label();
            txtDate = new TextBox();
            txtTime = new TextBox();
            txtNote = new TextBox();
            btnConfirm = new Button();
            SuspendLayout();
            // 
            // lblSummary
            // 
            lblSummary.AutoSize = true;
            lblSummary.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSummary.ForeColor = SystemColors.ControlText;
            lblSummary.Location = new Point(317, 80);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(125, 29);
            lblSummary.TabIndex = 5;
            lblSummary.Text = "Summary";
            // 
            // lblAppointment
            // 
            lblAppointment.AutoSize = true;
            lblAppointment.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAppointment.ForeColor = SystemColors.ControlText;
            lblAppointment.Location = new Point(301, 31);
            lblAppointment.Name = "lblAppointment";
            lblAppointment.Size = new Size(170, 29);
            lblAppointment.TabIndex = 4;
            lblAppointment.Text = "Appointment";
            // 
            // txtDate
            // 
            txtDate.Location = new Point(146, 137);
            txtDate.Name = "txtDate";
            txtDate.ReadOnly = true;
            txtDate.Size = new Size(189, 27);
            txtDate.TabIndex = 6;
            // 
            // txtTime
            // 
            txtTime.Location = new Point(146, 181);
            txtTime.Name = "txtTime";
            txtTime.ReadOnly = true;
            txtTime.Size = new Size(189, 27);
            txtTime.TabIndex = 7;
            // 
            // txtNote
            // 
            txtNote.Location = new Point(146, 224);
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.ReadOnly = true;
            txtNote.Size = new Size(347, 89);
            txtNote.TabIndex = 12;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(146, 360);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(94, 29);
            btnConfirm.TabIndex = 13;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // Summary_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConfirm);
            Controls.Add(txtNote);
            Controls.Add(txtTime);
            Controls.Add(txtDate);
            Controls.Add(lblSummary);
            Controls.Add(lblAppointment);
            Name = "Summary_Form";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSummary;
        private Label lblAppointment;
        private TextBox txtDate;
        private TextBox txtTime;
        private TextBox txtNote;
        private Button btnConfirm;
    }
}