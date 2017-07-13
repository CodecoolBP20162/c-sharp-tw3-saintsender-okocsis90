using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net.Security;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImapX;
using ImapX.Collections;

namespace SaintSender
{
    public partial class LoginPage : Form
    {
        public bool LoggedIn { get; set; }

        public LoginPage()
        {
            InitializeComponent();
            ImapService.Initialize();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            LoggedIn = ImapService.Login(userNameBox.Text, passBox.Text);

            if (LoggedIn)
            {
                MessageBox.Show("Logged In");
                Hide();
                EmailClient emailClient = new EmailClient();
                emailClient.Show();
            }
            else
            {
                MessageBox.Show("There was a problem logging you in to Google Mail.");
            }
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            if (File.Exists(PathGetter.GetCurrentPath() + @"\last_user.dat"))
            {
                User deserialized = User.Deserialize();
                userNameBox.Text = deserialized.UserName;
                passBox.Text = deserialized.PassWord;
            }
        }
    }
}
