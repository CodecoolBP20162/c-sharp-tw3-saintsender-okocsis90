namespace SaintSender
{
    partial class NewEmailCreator
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
            this.toBox = new System.Windows.Forms.TextBox();
            this.subjectBox = new System.Windows.Forms.TextBox();
            this.emailContentBox = new System.Windows.Forms.RichTextBox();
            this.toLbl = new System.Windows.Forms.Label();
            this.subjectLbl = new System.Windows.Forms.Label();
            this.contentLbl = new System.Windows.Forms.Label();
            this.sendMailBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // toBox
            // 
            this.toBox.Location = new System.Drawing.Point(12, 41);
            this.toBox.Name = "toBox";
            this.toBox.Size = new System.Drawing.Size(253, 20);
            this.toBox.TabIndex = 0;
            // 
            // subjectBox
            // 
            this.subjectBox.Location = new System.Drawing.Point(12, 93);
            this.subjectBox.Name = "subjectBox";
            this.subjectBox.Size = new System.Drawing.Size(253, 20);
            this.subjectBox.TabIndex = 1;
            // 
            // emailContentBox
            // 
            this.emailContentBox.Location = new System.Drawing.Point(12, 150);
            this.emailContentBox.Name = "emailContentBox";
            this.emailContentBox.Size = new System.Drawing.Size(494, 193);
            this.emailContentBox.TabIndex = 2;
            this.emailContentBox.Text = "";
            // 
            // toLbl
            // 
            this.toLbl.AutoSize = true;
            this.toLbl.Location = new System.Drawing.Point(13, 22);
            this.toLbl.Name = "toLbl";
            this.toLbl.Size = new System.Drawing.Size(23, 13);
            this.toLbl.TabIndex = 3;
            this.toLbl.Text = "To:";
            // 
            // subjectLbl
            // 
            this.subjectLbl.AutoSize = true;
            this.subjectLbl.Location = new System.Drawing.Point(13, 77);
            this.subjectLbl.Name = "subjectLbl";
            this.subjectLbl.Size = new System.Drawing.Size(46, 13);
            this.subjectLbl.TabIndex = 4;
            this.subjectLbl.Text = "Subject:";
            // 
            // contentLbl
            // 
            this.contentLbl.AutoSize = true;
            this.contentLbl.Location = new System.Drawing.Point(12, 134);
            this.contentLbl.Name = "contentLbl";
            this.contentLbl.Size = new System.Drawing.Size(47, 13);
            this.contentLbl.TabIndex = 5;
            this.contentLbl.Text = "Content:";
            // 
            // sendMailBtn
            // 
            this.sendMailBtn.Location = new System.Drawing.Point(430, 365);
            this.sendMailBtn.Name = "sendMailBtn";
            this.sendMailBtn.Size = new System.Drawing.Size(75, 23);
            this.sendMailBtn.TabIndex = 6;
            this.sendMailBtn.Text = "Send";
            this.sendMailBtn.UseVisualStyleBackColor = true;
            this.sendMailBtn.Click += new System.EventHandler(this.sendMailBtn_Click);
            // 
            // NewEmailCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 400);
            this.Controls.Add(this.sendMailBtn);
            this.Controls.Add(this.contentLbl);
            this.Controls.Add(this.subjectLbl);
            this.Controls.Add(this.toLbl);
            this.Controls.Add(this.emailContentBox);
            this.Controls.Add(this.subjectBox);
            this.Controls.Add(this.toBox);
            this.Name = "NewEmailCreator";
            this.Text = "NewEmailCreator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox toBox;
        private System.Windows.Forms.TextBox subjectBox;
        private System.Windows.Forms.RichTextBox emailContentBox;
        private System.Windows.Forms.Label toLbl;
        private System.Windows.Forms.Label subjectLbl;
        private System.Windows.Forms.Label contentLbl;
        private System.Windows.Forms.Button sendMailBtn;
    }
}