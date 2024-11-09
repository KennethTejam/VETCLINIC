namespace Appointment1
{
    partial class frmFollowUp
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
            rbNoF = new RadioButton();
            rb1m = new RadioButton();
            rb3m = new RadioButton();
            rb6m = new RadioButton();
            txtDate = new TextBox();
            txtMedNote = new TextBox();
            cbTime = new ComboBox();
            btnConfirm = new Button();
            groupBox1 = new GroupBox();
            btnGetTimes = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // rbNoF
            // 
            rbNoF.AutoSize = true;
            rbNoF.Location = new Point(15, 27);
            rbNoF.Name = "rbNoF";
            rbNoF.Size = new Size(117, 24);
            rbNoF.TabIndex = 0;
            rbNoF.TabStop = true;
            rbNoF.Text = "No follow up";
            rbNoF.UseVisualStyleBackColor = true;
            // 
            // rb1m
            // 
            rb1m.AutoSize = true;
            rb1m.Location = new Point(15, 57);
            rb1m.Name = "rb1m";
            rb1m.Size = new Size(162, 24);
            rb1m.TabIndex = 1;
            rb1m.TabStop = true;
            rb1m.Text = "Vaccine X - 1 month";
            rb1m.UseVisualStyleBackColor = true;
            // 
            // rb3m
            // 
            rb3m.AutoSize = true;
            rb3m.Location = new Point(15, 87);
            rb3m.Name = "rb3m";
            rb3m.Size = new Size(167, 24);
            rb3m.TabIndex = 2;
            rb3m.TabStop = true;
            rb3m.Text = "Vaccine Y - 3 months";
            rb3m.UseVisualStyleBackColor = true;
            // 
            // rb6m
            // 
            rb6m.AutoSize = true;
            rb6m.Location = new Point(15, 117);
            rb6m.Name = "rb6m";
            rb6m.Size = new Size(168, 24);
            rb6m.TabIndex = 3;
            rb6m.TabStop = true;
            rb6m.Text = "Vaccine Z - 6 months";
            rb6m.UseVisualStyleBackColor = true;
            // 
            // txtDate
            // 
            txtDate.Location = new Point(409, 71);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(186, 27);
            txtDate.TabIndex = 4;
            // 
            // txtMedNote
            // 
            txtMedNote.Location = new Point(70, 209);
            txtMedNote.Multiline = true;
            txtMedNote.Name = "txtMedNote";
            txtMedNote.Size = new Size(268, 174);
            txtMedNote.TabIndex = 5;
            // 
            // cbTime
            // 
            cbTime.FormattingEnabled = true;
            cbTime.Location = new Point(426, 146);
            cbTime.Name = "cbTime";
            cbTime.Size = new Size(151, 28);
            cbTime.TabIndex = 6;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(537, 367);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(94, 29);
            btnConfirm.TabIndex = 7;
            btnConfirm.Text = "confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rb1m);
            groupBox1.Controls.Add(rbNoF);
            groupBox1.Controls.Add(rb3m);
            groupBox1.Controls.Add(rb6m);
            groupBox1.Location = new Point(70, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(281, 148);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnGetTimes
            // 
            btnGetTimes.Location = new Point(426, 111);
            btnGetTimes.Name = "btnGetTimes";
            btnGetTimes.Size = new Size(140, 29);
            btnGetTimes.TabIndex = 9;
            btnGetTimes.Text = "Available Times";
            btnGetTimes.UseVisualStyleBackColor = true;
            btnGetTimes.Click += btnGetTimes_Click;
            // 
            // frmFollowUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 450);
            Controls.Add(btnGetTimes);
            Controls.Add(btnConfirm);
            Controls.Add(cbTime);
            Controls.Add(txtMedNote);
            Controls.Add(txtDate);
            Controls.Add(groupBox1);
            Name = "frmFollowUp";
            Text = "Form4";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rbNoF;
        private RadioButton rb1m;
        private RadioButton rb3m;
        private RadioButton rb6m;
        private TextBox txtDate;
        private TextBox txtMedNote;
        private ComboBox cbTime;
        private Button btnConfirm;
        private GroupBox groupBox1;
        private Button btnGetTimes;
    }
}