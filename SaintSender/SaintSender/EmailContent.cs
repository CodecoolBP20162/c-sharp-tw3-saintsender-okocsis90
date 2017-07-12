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
        public EmailContent(string text)
        {
            InitializeComponent();
            emailTextBox.Text = text;
        }
    }
}
