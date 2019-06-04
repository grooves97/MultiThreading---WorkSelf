using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace TaskScheduler.Models
{
    public class EmailTask : Tasks
    {
        public string FromPath { get; set; }
        public string ToPath { get; set; }

        public void EmailMessage()
        {
            try
            {
                MailMessage mail = new MailMessage(FromPath, ToPath);
                SmtpClient client = new SmtpClient();
                client.Port = 25;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Host = "smtp.gmail.com";
                mail.Subject = "this is a test email.";
                mail.Body = "this is my test email body";
                client.Send(mail);
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Error: {exception.Message}");
            }          
        }
    }
}
