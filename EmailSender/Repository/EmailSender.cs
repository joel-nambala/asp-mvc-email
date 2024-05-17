using EmailSender.Services;
using Microsoft.AspNetCore.Identity;
using System.Net;
using System.Net.Mail;

namespace EmailSender.Repository
{
    public class EmailSenders : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string body)
        {

                var senderEmail = "wanjala.n.joel@gmail.com";
                var senderPassword = "zwcg anmt ktru czdj";

                var smtpClient = new SmtpClient("smtp.gmail.com");
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword);

               return smtpClient.SendMailAsync(new MailMessage(from: senderEmail, to: email, subject: subject, body: body));
        }
    }
}
