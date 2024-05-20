﻿namespace Project_Management_Admin_Panel.Email_Services
{
    using System.Net;
    using System.Net.Mail;
    using System.Threading.Tasks;

    #region EmailSender
    public class EmailSender : IEmailSender
    {
        private readonly string _host;
        private readonly int _port;
        private readonly bool _enableSSL;
        private readonly string _userName;
        private readonly string _password;

        public EmailSender(string host, int port, bool enableSSL, string userName, string password)
        {
            _host = host;
            _port = port;
            _enableSSL = enableSSL;
            _userName = userName;
            _password = password;
        }

        public Task SendEmailAsync(string email, string subject, string message)
        {
            var smtpClient = new SmtpClient(_host)
            {
                Port = _port,
                Credentials = new NetworkCredential(_userName, _password),
                EnableSsl = _enableSSL,
            };

            var mailMessage = new MailMessage
            {
                From = new MailAddress(_userName),
                Subject = subject,
                Body = message,
                IsBodyHtml = true,
            };
            mailMessage.To.Add(email);

            return smtpClient.SendMailAsync(mailMessage);
        }

        public async Task SendEmailWithAttachmentAsync(string email, string subject, string body, Attachment attachment)
        {
            try
            {
                using (var smtpClient = new SmtpClient(_host)
                {
                    Port = _port,
                    Credentials = new NetworkCredential(_userName, _password),
                    EnableSsl = _enableSSL,
                })
                using (var mailMessage = new MailMessage
                {
                    From = new MailAddress(_userName, "Project Management Systen"),
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = true,
                })
                {
                    mailMessage.To.Add(email);
                    mailMessage.Attachments.Add(attachment);

                    Console.WriteLine("Attempting to send an email...");
                    await smtpClient.SendMailAsync(mailMessage);
                    Console.WriteLine("Email sent successfully.");
                }
            }
            catch (Exception ex)
            {
                // It's better to log the full exception to preserve the stack trace in your logging mechanism
                Console.WriteLine($"An error occurred while sending email: {ex}");
                throw; // Consider the appropriate error handling here (logging, retrying, etc.)
            }
        }
    }
}
#endregion
