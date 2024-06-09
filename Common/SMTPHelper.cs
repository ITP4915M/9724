using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace Common
{
    public class SMTPHelper
    {


        public string sendRestCode(string to)
        {


            string from, pwd, messageBody;
            Random rand = new Random();
            string randomCode = (rand.Next(999999)).ToString();
            MailMessage message = new MailMessage();
            from = "legendmotorsystem@gmail.com";
            pwd = "wyxjcllzngamlkpa";
            messageBody = "Your reset code is " + randomCode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "password reseting code";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(from, pwd);
            smtp.Send(message);
            return randomCode;


        }
        
    }
}
