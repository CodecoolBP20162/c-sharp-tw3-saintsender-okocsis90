﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImapX;
using ImapX.Collections;

namespace SaintSender
{
    public partial class EmailClient : Form
    {
        public EmailClient()
        {
            InitializeComponent();
        }

        private void EmailClient_Load(object sender, EventArgs e)
        {
            foreach (Folder folder in ImapService.GetFolders())
            {
                if (!Regex.IsMatch(folder.Name, @"\[.*\]")) folderListView.Items.Add(folder.Name);
            }
        }

        private void folderListView_ItemActivate(object sender, EventArgs e)
        {
            List<ListViewItem> messages = ImapService.LoadListViewItemsOfMessages(folderListView.SelectedItems[0].Text);
            foreach (ListViewItem item in messages)
            {
                emailDetailsListView.Items.Add(item);
            }
        }

        private void emailDetailsListView_ItemActivate(object sender, EventArgs e)
        {
            string content = ImapService.GetEmailContent(emailDetailsListView.SelectedItems[0].Name);
            EmailContent contentRepr = new EmailContent(content);
            contentRepr.Show();
        }

        private void newEmailBtn_Click(object sender, EventArgs e)
        {
            NewEmailCreator creator = new NewEmailCreator();
            creator.Show();
        }
    }
}