using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace TaskScheduler.Consol
{
    class Program
    {
        static void Main(string[] args)
        {
            MailMessage mail = new MailMessage("grooves97@gmail.com", "anurakishev97@gmail.com");
            SmtpClient client = new SmtpClient();
            client.Port = 25;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.EnableSsl = true;
            client.Host = "smtp.gmail.com";
            mail.Subject = "this is a test email.";
            mail.Body = "this is my test email body";
            client.Send(mail);
            Console.WriteLine("Mail Sent", "Succes");
        }
    }
}
