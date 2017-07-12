namespace SaintSender
{
    partial class EmailClient
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
            this.folderListView = new System.Windows.Forms.ListView();
            this.emailDetailsListView = new System.Windows.Forms.ListView();
            this.subjectCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fromCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.newEmailBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // folderListView
            // 
            this.folderListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.folderListView.Location = new System.Drawing.Point(13, 43);
            this.folderListView.Name = "folderListView";
            this.folderListView.Size = new System.Drawing.Size(121, 447);
            this.folderListView.TabIndex = 1;
            this.folderListView.UseCompatibleStateImageBehavior = false;
            this.folderListView.View = System.Windows.Forms.View.List;
            this.folderListView.ItemActivate += new System.EventHandler(this.folderListView_ItemActivate);
            // 
            // emailDetailsListView
            // 
            this.emailDetailsListView.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.emailDetailsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.subjectCol,
            this.fromCol,
            this.dateCol});
            this.emailDetailsListView.FullRowSelect = true;
            this.emailDetailsListView.Location = new System.Drawing.Point(141, 43);
            this.emailDetailsListView.Name = "emailDetailsListView";
            this.emailDetailsListView.Size = new System.Drawing.Size(525, 447);
            this.emailDetailsListView.TabIndex = 2;
            this.emailDetailsListView.UseCompatibleStateImageBehavior = false;
            this.emailDetailsListView.View = System.Windows.Forms.View.Details;
            this.emailDetailsListView.ItemActivate += new System.EventHandler(this.emailDetailsListView_ItemActivate);
            // 
            // subjectCol
            // 
            this.subjectCol.Text = "Subject";
            this.subjectCol.Width = 137;
            // 
            // fromCol
            // 
            this.fromCol.Text = "From";
            this.fromCol.Width = 141;
            // 
            // dateCol
            // 
            this.dateCol.Text = "Date";
            this.dateCol.Width = 195;
            // 
            // newEmailBtn
            // 
            this.newEmailBtn.Location = new System.Drawing.Point(590, 14);
            this.newEmailBtn.Name = "newEmailBtn";
            this.newEmailBtn.Size = new System.Drawing.Size(75, 23);
            this.newEmailBtn.TabIndex = 3;
            this.newEmailBtn.Text = "New Email";
            this.newEmailBtn.UseVisualStyleBackColor = true;
            this.newEmailBtn.Click += new System.EventHandler(this.newEmailBtn_Click);
            // 
            // EmailClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 502);
            this.Controls.Add(this.newEmailBtn);
            this.Controls.Add(this.emailDetailsListView);
            this.Controls.Add(this.folderListView);
            this.Name = "EmailClient";
            this.Text = "EmailClient";
            this.Load += new System.EventHandler(this.EmailClient_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView folderListView;
        private System.Windows.Forms.ListView emailDetailsListView;
        private System.Windows.Forms.ColumnHeader subjectCol;
        private System.Windows.Forms.ColumnHeader fromCol;
        private System.Windows.Forms.ColumnHeader dateCol;
        private System.Windows.Forms.Button newEmailBtn;
    }
}