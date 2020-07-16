using ChickenStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace ChickenStore
{
    public class emailer
    {
        public bool SendEmail(EmailMessage message, EmailSetup emailsetup)
        {
            bool sent = false;

            try
            {
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(emailsetup.username);
                    mail.To.Add(emailsetup.username);
                    mail.Subject = string.Format("Customer Message #{0}", message.Id);
                    mail.Body = string.Format("<h1>{0}</h1><br>{1}<br>From: {2}<br>{3}", message.Subject, message.MessageText, message.FromName, message.FromEMail);
                    mail.IsBodyHtml = true;
                    //mail.Attachments.Add(new Attachment("C:\\file.zip"));

                    using (SmtpClient smtp = new SmtpClient(emailsetup.mailserver, 587))
                    {
                        smtp.Credentials = new NetworkCredential(emailsetup.username, emailsetup.pwd);
                        smtp.EnableSsl = true;
                        smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                        smtp.Timeout = 20000;
                        smtp.Send(mail);
                    }

                    sent = true;
                }
            }
            catch (Exception ex)
            {
                sent = false;
            }

            return sent;
        }

    }
}
