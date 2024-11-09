namespace CLINIC
{
    partial class customMessageBox
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
            tbxMessage = new Label();
            btnOK = new Button();
            textBox1 = new TextBox();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // tbxMessage
            // 
            tbxMessage.AutoSize = true;
            tbxMessage.BackColor = Color.Bisque;
            tbxMessage.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbxMessage.Location = new Point(83, 42);
            tbxMessage.Name = "tbxMessage";
            tbxMessage.Size = new Size(275, 25);
            tbxMessage.TabIndex = 0;
            tbxMessage.Text = "Verify Password to Continue..";
            // 
            // btnOK
            // 
            btnOK.BackColor = Color.Bisque;
            btnOK.ForeColor = SystemColors.ActiveCaptionText;
            btnOK.Location = new Point(236, 184);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 1;
            btnOK.Text = "Verify";
            btnOK.UseVisualStyleBackColor = false;
            btnOK.Click += btnOK_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(122, 105);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(189, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Bisque;
            btnCancel.ForeColor = SystemColors.ActiveCaptionText;
            btnCancel.Location = new Point(122, 184);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // customMessageBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(434, 261);
            ControlBox = false;
            Controls.Add(btnCancel);
            Controls.Add(textBox1);
            Controls.Add(btnOK);
            Controls.Add(tbxMessage);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            IsMdiContainer = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "customMessageBox";
            ShowInTaskbar = false;
            Text = "customMessageBox";
            TopMost = true;
            Load += customMessageBox_Load;
            MouseDown += TransparentForm_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tbxMessage;
        private Button btnOK;
        private TextBox textBox1;
        private Button btnCancel;
    }
}