using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaintSender
{
    public class User
    {
        public string UserName { get; set; }
        public string PassWord { get; set; }

        public User(string uName, string pWord)
        {
            UserName = uName;
            PassWord = pWord;
        }
    }
}
