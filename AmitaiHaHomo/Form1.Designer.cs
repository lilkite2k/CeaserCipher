namespace AmitaiHaHomo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox decryptedText;
        private System.Windows.Forms.Button decryptedBtn;

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
            this.decryptedText = new System.Windows.Forms.TextBox();
            this.decryptedBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // decryptedText
            // 
            this.decryptedText.Location = new System.Drawing.Point(12, 12);
            this.decryptedText.Name = "decryptedText";
            this.decryptedText.Size = new System.Drawing.Size(246, 20);
            this.decryptedText.TabIndex = 0;
            // 
            // decryptedBtn
            // 
            this.decryptedBtn.Location = new System.Drawing.Point(264, 10);
            this.decryptedBtn.Name = "decryptedBtn";
            this.decryptedBtn.Size = new System.Drawing.Size(75, 23);
            this.decryptedBtn.TabIndex = 1;
            this.decryptedBtn.Text = "Decrypt";
            this.decryptedBtn.UseVisualStyleBackColor = true;
            this.decryptedBtn.Click += new System.EventHandler(this.decryptedBtn_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(370, 346);
            this.Controls.Add(this.decryptedBtn);
            this.Controls.Add(this.decryptedText);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
