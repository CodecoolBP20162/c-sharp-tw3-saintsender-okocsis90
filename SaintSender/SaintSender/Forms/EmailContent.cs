using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaintSender
{
    public partial class EmailContent : Form
    {
        public string SenderEmail { get; set; }

        public EmailContent(string text, string senderEmail)
        {
            InitializeComponent();
            emailTextBox.Text = HTMLToText.StripHTML(text);
            SenderEmail = senderEmail;
        }

        private void responseBtn_Click(object sender, EventArgs e)
        {
            NewEmailCreator creator = new NewEmailCreator(SenderEmail);
            creator.Show();
        }
    }
}
