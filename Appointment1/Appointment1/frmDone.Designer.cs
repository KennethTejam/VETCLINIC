﻿namespace Appointment1
{
    partial class frmDone
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
            pAppointment = new Panel();
            lblPending = new Label();
            lblDone = new Label();
            txtSearch = new TextBox();
            cbSort = new ComboBox();
            SuspendLayout();
            // 
            // pAppointment
            // 
            pAppointment.AutoScroll = true;
            pAppointment.Location = new Point(218, 144);
            pAppointment.Name = "pAppointment";
            pAppointment.Size = new Size(386, 243);
            pAppointment.TabIndex = 1;
            // 
            // lblPending
            // 
            lblPending.AutoSize = true;
            lblPending.Location = new Point(261, 62);
            lblPending.Name = "lblPending";
            lblPending.Size = new Size(62, 20);
            lblPending.TabIndex = 2;
            lblPending.Text = "Pending";
            lblPending.Click += lblPending_Click;
            // 
            // lblDone
            // 
            lblDone.AutoSize = true;
            lblDone.Location = new Point(454, 62);
            lblDone.Name = "lblDone";
            lblDone.Size = new Size(45, 20);
            lblDone.TabIndex = 3;
            lblDone.Text = "Done";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(616, 33);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(141, 27);
            txtSearch.TabIndex = 9;
            // 
            // cbSort
            // 
            cbSort.FormattingEnabled = true;
            cbSort.Location = new Point(632, 81);
            cbSort.Name = "cbSort";
            cbSort.Size = new Size(151, 28);
            cbSort.TabIndex = 8;
            // 
            // frmDone
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSearch);
            Controls.Add(cbSort);
            Controls.Add(lblDone);
            Controls.Add(lblPending);
            Controls.Add(pAppointment);
            Name = "frmDone";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pAppointment;
        private Label lblPending;
        private Label lblDone;
        private TextBox txtSearch;
        private ComboBox cbSort;
    }
}