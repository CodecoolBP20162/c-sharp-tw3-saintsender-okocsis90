using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImapX;
using ImapX.Collections;

namespace SaintSender
{
    public partial class EmailClient : Form
    {
        private MessageCollection messages;

        public EmailClient()
        {
            InitializeComponent();
        }

        private void EmailClient_Load(object sender, EventArgs e)
        {
            foreach (Folder folder in ImapService.GetFolders())
            {
                folderListView.Items.Add(folder.Name);
            }
        }

        private void folderListView_ItemActivate(object sender, EventArgs e)
        {
            messages = ImapService.GetMessagesForFolder(folderListView.SelectedItems[0].Text);
            foreach (ImapX.Message message in messages)
            {
                ListViewItem item = new ListViewItem(message.Subject);
                ListViewItem.ListViewSubItem[] subItems = {new ListViewItem.ListViewSubItem(item, message.From.Address),
                    new ListViewItem.ListViewSubItem(item, message.Date.ToString()),
                };
                item.Name = message.UId.ToString();
                item.SubItems.AddRange(subItems);
                emailDetailsListView.Items.Add(item);
            }
        }

        private void emailDetailsListView_ItemActivate(object sender, EventArgs e)
        {
            long emailUId = Convert.ToInt64(emailDetailsListView.SelectedItems[0].Name);
            foreach (ImapX.Message msg in messages)
            {
                if (msg.UId == emailUId)
                {
                    string content = msg.Body.Html;
                    EmailContent contentRepr = new EmailContent(content);
                    contentRepr.Show();
                }
            }
        }

        private void newEmailBtn_Click(object sender, EventArgs e)
        {
            NewEmailCreator creator = new NewEmailCreator();
            creator.Show();
        }
    }
}
