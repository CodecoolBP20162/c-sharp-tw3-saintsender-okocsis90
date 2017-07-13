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
            EmailSenderService.SendEmail(toBox.Text, subjectBox.Text, emailContentBox.Text);
            MessageBox.Show("Email has been sent.");
            CloseWindow();
        }
    }
}
