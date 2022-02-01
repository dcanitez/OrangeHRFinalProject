using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.BLL.ServiceOperations.Common
{
    public static class SendMailService
    {
        public static void SendMail(string confirmationLink, string userName)
        {
            //From ve To alanlarının doldurulması gerekiyor.
            MailMessage mailMessage = new MailMessage("dilaycanitez@gmail.com", "dilaycanitez@gmail.com");
            mailMessage.Body = RegistrationEmailBody(confirmationLink, userName);
            mailMessage.IsBodyHtml = true;
            mailMessage.Subject = "Konu:  ";
            mailMessage.Priority = MailPriority.High;

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.Credentials = new System.Net.NetworkCredential
            {
                UserName = "mail@gmail.com",
                Password = ""
            };
            smtpClient.EnableSsl = true;
            smtpClient.Send(mailMessage);

        }

        private static string RegistrationEmailBody(string confirmationLink, string userName)
        {
            string body = string.Empty;
            string path = "~/wwwroot/dilay/emailtemplates/emailVerification.html";
            using (StreamReader reader = new StreamReader(path))
            {
                body = reader.ReadToEnd();
            }
            body = body.Replace("{UserName}", userName);
            body = body.Replace("{confirmationLink}", confirmationLink);

            return body;
        }
    }
}
