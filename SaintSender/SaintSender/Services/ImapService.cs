using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using ImapX;
using ImapX.Collections;

namespace SaintSender
{
    public class ImapService
    {
        public static MessageCollection currentMessages;
        public static User user;
        private static ImapClient client { get; set; }

        public static void Initialize()
        {
            client = new ImapClient("imap.gmail.com", true);

            if (!client.Connect())
            {
                throw new Exception("Error connecting to the client.");
            }
        }

        public static bool Login(string u, string p)
        {
            user = new User(u, p);
            user.Serialize();
            return client.Login(u, p);
        }

        public static bool Logout()
        {
            if (client.IsAuthenticated)
            {
                client.Logout();
            }
            user = null;
            return true;
        }

        public static List<Folder> GetFolders()
        {
            var folders = new List<Folder>();

            foreach (var folder in client.Folders)
            {
                folders.Add(folder);
            }

            client.Folders.Inbox.StartIdling();

            client.Folders.Inbox.OnNewMessagesArrived += Inbox_OnNewMessagesArrived;
            return folders;
        }

        private static void Inbox_OnNewMessagesArrived(object sender, IdleEventArgs e)
        {
            MessageBox.Show($"A new message was downloaded in {e.Folder.Name} folder.");
        }

        public static List<ListViewItem> LoadListViewItemsOfMessages(string folderName)
        {
            currentMessages = GetMessagesForFolder(folderName);
            List<ListViewItem> itemsList = new List<ListViewItem>();
            foreach (ImapX.Message message in currentMessages)
            {
                ListViewItem item = new ListViewItem(message.Subject);
                ListViewItem.ListViewSubItem[] subItems =
                {
                    new ListViewItem.ListViewSubItem(item, message.From.Address),
                    new ListViewItem.ListViewSubItem(item, message.Date.ToString()),
                };
                item.Name = message.UId.ToString();
                item.SubItems.AddRange(subItems);
                itemsList.Add(item);
            }
            return itemsList;
        }

        public static string GetEmailContent(string selectedEmailId)
        {
            long emailUId = Convert.ToInt64(selectedEmailId);
            foreach (ImapX.Message msg in currentMessages)
            {
                if (msg.UId == emailUId)
                {
                    return msg.Body.Html;
                }
            }
            return String.Empty;
        }

        public static MessageCollection GetMessagesForFolder(string name)
        {

            ParameterizedThreadStart threadStart = new ParameterizedThreadStart(DownloadMessages);
            Thread searcherThread = new Thread(threadStart);
            searcherThread.Start(name);
            searcherThread.Join();
            return client.Folders[name].Messages;
        }

        public static void DownloadMessages(object name)
        {
            client.Folders[name.ToString()].Messages.Download();
        }
    }
}


