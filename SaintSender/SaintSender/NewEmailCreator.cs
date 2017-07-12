using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaintSender
{
    public partial class NewEmailCreator : Form
    {
        public NewEmailCreator()
        {
            InitializeComponent();
        }

        private void sendMailBtn_Click(object sender, EventArgs e)
        {
            using (SmtpClient client = new SmtpClient("smtp.gmail.com", 25))
            {
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(ImapService.userName, ImapService.passWord);

                MailMessage message = new MailMessage(
                    "mosaicteam00@gmail.com",
                    toBox.Text,
                    subjectBox.Text,
                    emailContentBox.Text
                );

                client.Send(message);

                MessageBox.Show("Email has been sent.");
                toBox.Clear();
                subjectBox.Clear();
                emailContentBox.Clear();
                Hide();
            }
        }
    }
}
