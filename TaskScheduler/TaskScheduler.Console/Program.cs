using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.IO;

namespace TaskScheduler.Consol
{
    class Program
    {
        static void Main(string[] args)
        {
            //MailMessage mail = new MailMessage("grooves97@gmail.com", "anurakishev97@gmail.com");
            //SmtpClient client = new SmtpClient();
            //client.Port = 25;
            //client.DeliveryMethod = SmtpDeliveryMethod.Network;
            //client.UseDefaultCredentials = false;
            //client.EnableSsl = true;
            //client.Host = "smtp.gmail.com";
            //mail.Subject = "this is a test email.";
            //mail.Body = "this is my test email body";
            //client.Send(mail);
            //Console.WriteLine("Mail Sent", "Succes");

            string ToPath = "Z:\baku";
            string FromPath = "C:\blah";

            DirectoryCreate(ToPath,FromPath);
        }


        public static void DirectoryCreate(string ToPath,string FromPath)
        {
            if (!Directory.Exists(ToPath))
                Directory.CreateDirectory(ToPath);
            string[] files = Directory.GetFiles(FromPath);
            foreach (string file in files)
            {
                string name = Path.GetFileName(file);
                string dest = Path.Combine(ToPath, name);
                File.Copy(file, dest);
            }
            string[] folders = Directory.GetDirectories(FromPath);
            foreach (string folder in folders)
            {
                string name = Path.GetFileName(folder);
                string dest = Path.Combine(ToPath, name);
                DirectoryCreate(dest,FromPath);
            }
        }
    }
}
