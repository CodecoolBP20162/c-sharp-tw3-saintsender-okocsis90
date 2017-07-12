using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using ImapX;
using ImapX.Collections;

namespace SaintSender
{
    class ImapService
    {
        public static string userName;
        public static string passWord;
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
            userName = u;
            passWord = p;
            return client.Login(u, p);
        }

        public static bool Logout()
        {
            if (client.IsAuthenticated) { client.Logout(); }
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

        public static MessageCollection GetMessagesForFolder(string name)
        {
            client.Folders[name].Messages.Download();
            return client.Folders[name].Messages;
        }
    }

}
