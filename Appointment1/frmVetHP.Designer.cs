namespace Appointment1
{
    partial class frmVetHP
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
            SuspendLayout();
            // 
            // pAppointment
            // 
            pAppointment.AutoScroll = true;
            pAppointment.Location = new Point(207, 104);
            pAppointment.Name = "pAppointment";
            pAppointment.Size = new Size(386, 243);
            pAppointment.TabIndex = 2;
            // 
            // frmVetHP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pAppointment);
            Name = "frmVetHP";
            Text = "Form4";
      
            ResumeLayout(false);
        }

        #endregion

        private Panel pAppointment;
    }
}