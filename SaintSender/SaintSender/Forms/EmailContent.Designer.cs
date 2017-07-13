namespace SaintSender
{
    partial class EmailContent
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
            this.emailTextBox = new System.Windows.Forms.RichTextBox();
            this.responseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(13, 13);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(474, 432);
            this.emailTextBox.TabIndex = 0;
            this.emailTextBox.Text = "";
            // 
            // responseBtn
            // 
            this.responseBtn.Location = new System.Drawing.Point(412, 455);
            this.responseBtn.Name = "responseBtn";
            this.responseBtn.Size = new System.Drawing.Size(75, 23);
            this.responseBtn.TabIndex = 1;
            this.responseBtn.Text = "Respond";
            this.responseBtn.UseVisualStyleBackColor = true;
            this.responseBtn.Click += new System.EventHandler(this.responseBtn_Click);
            // 
            // EmailContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 490);
            this.Controls.Add(this.responseBtn);
            this.Controls.Add(this.emailTextBox);
            this.Name = "EmailContent";
            this.Text = "Email Content";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox emailTextBox;
        private System.Windows.Forms.Button responseBtn;
    }
}