using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaintSender
{
    public partial class NewEmailCreator
    {
        private void ClearWindow()
        {
            toBox.Clear();
            subjectBox.Clear();
            emailContentBox.Clear();
        }

        private void CloseWindow()
        {
            ClearWindow();
            Hide();
        }
    }
}
