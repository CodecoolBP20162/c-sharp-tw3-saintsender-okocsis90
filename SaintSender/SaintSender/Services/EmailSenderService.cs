using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SaintSender
{
    public class EmailSenderService
    {
        public static void SendEmail(string to, string subject, string content)
        {
            using (SmtpClient client = new SmtpClient("smtp.gmail.com", 25))
            {
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(ImapService.user.UserName, ImapService.user.PassWord);
                string userName = ValidateUserName(ImapService.user.UserName);
                
                MailMessage message = new MailMessage(
                    userName,
                    to,
                    subject,
                    content
                );

                client.Send(message);
            }
        }

        public static string ValidateUserName(string userName)
        {
            if (userName.Contains("gmail.com")) return userName;
            return userName + "@gmail.com";
        } 
    }
}
