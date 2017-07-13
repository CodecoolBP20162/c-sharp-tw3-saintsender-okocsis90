using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
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
            emailDetailsListView.Items.Clear();
            string name = folderListView.SelectedItems[0].Text;

            List<ListViewItem> listViewItems = ImapService.LoadListViewItemsOfMessages(name);

            foreach (ListViewItem item in listViewItems)
            {
                emailDetailsListView.Items.Add(item);
            }
        }

        private void emailDetailsListView_ItemActivate(object sender, EventArgs e)
        {
            string content = ImapService.GetEmailContent(emailDetailsListView.SelectedItems[0].Name);
            string senderEmail = emailDetailsListView.SelectedItems[0].SubItems[1].Text;
            EmailContent contentRepr = new EmailContent(content, senderEmail);
            contentRepr.Show();
        }

        private void newEmailBtn_Click(object sender, EventArgs e)
        {
            NewEmailCreator creator = new NewEmailCreator();
            creator.Show();
        }
    }
}
