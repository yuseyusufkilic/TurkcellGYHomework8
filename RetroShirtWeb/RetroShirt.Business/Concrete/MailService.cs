using RetroShirt.Business.Abstract;
using RetroShirtDAL.Repositories;
using RetroShirtEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace RetroShirt.Business.Concrete
{
    public class MailService:IMailService
    {
        
       
            public void sendMail(User user)
            {
                MailMessage mailMessage = new MailMessage();
                mailMessage.To.Add("censored");
                mailMessage.From = new MailAddress("censored");
                mailMessage.Subject = "RetroShirt Registration";
                mailMessage.Body = $"We are pleased to see you {user.Fullname} in our website. Thanks for your registration.";
                mailMessage.IsBodyHtml = true;

                SmtpClient smtpClient = new SmtpClient();
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential("censored", "censored");
                smtpClient.Port = 587;
                smtpClient.Host = "smtp.gmail.com";
                smtpClient.EnableSsl = true;


                smtpClient.Send(mailMessage);
            }
        
    }
}
