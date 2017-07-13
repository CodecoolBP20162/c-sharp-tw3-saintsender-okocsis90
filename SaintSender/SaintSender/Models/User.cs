using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SaintSender
{
    [Serializable]
    public class User
    {
        public string UserName { get; set; }
        public string PassWord { get; set; }

        public User()
        {
        }

        public User(string uName, string pWord)
        {
            UserName = uName;
            PassWord = pWord;
        }

        public void Serialize()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("last_user.dat", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, this);
            stream.Close();
        }

        public static User Deserialize()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("last_user.dat", FileMode.Open, FileAccess.Read, FileShare.Read);
            User user = (User)formatter.Deserialize(stream);
            stream.Close();
            return user;
        }
    }
}
