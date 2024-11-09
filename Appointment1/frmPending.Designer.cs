namespace Appointment1
{
    partial class frmPending
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
            lblDone = new Label();
            lblPending = new Label();
            cbSort = new ComboBox();
            txtSearch = new TextBox();
            SuspendLayout();
            // 
            // pAppointment
            // 
            pAppointment.AutoScroll = true;
            pAppointment.Location = new Point(196, 208);
            pAppointment.Name = "pAppointment";
            pAppointment.Size = new Size(297, 172);
            pAppointment.TabIndex = 0;
            // 
            // lblDone
            // 
            lblDone.AutoSize = true;
            lblDone.Location = new Point(437, 116);
            lblDone.Name = "lblDone";
            lblDone.Size = new Size(45, 20);
            lblDone.TabIndex = 5;
            lblDone.Text = "Done";
            lblDone.Click += lblDone_Click;
            // 
            // lblPending
            // 
            lblPending.AutoSize = true;
            lblPending.Location = new Point(214, 116);
            lblPending.Name = "lblPending";
            lblPending.Size = new Size(62, 20);
            lblPending.TabIndex = 4;
            lblPending.Text = "Pending";
            // 
            // cbSort
            // 
            cbSort.FormattingEnabled = true;
            cbSort.Location = new Point(588, 80);
            cbSort.Name = "cbSort";
            cbSort.Size = new Size(151, 28);
            cbSort.TabIndex = 6;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(572, 32);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(141, 27);
            txtSearch.TabIndex = 7;
            // 
            // frmPending
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 484);
            Controls.Add(txtSearch);
            Controls.Add(cbSort);
            Controls.Add(lblDone);
            Controls.Add(lblPending);
            Controls.Add(pAppointment);
            Name = "frmPending";
            Text = "Homepage";

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pAppointment;
        private Label lblDone;
        private Label lblPending;
        private ComboBox cbSort;
        private TextBox txtSearch;
    }
}