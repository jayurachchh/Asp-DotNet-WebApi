using System.Net.Mail;

namespace Project_Management_Admin_Panel.Email_Services 
{
    #region IEmailSender
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
        Task SendEmailWithAttachmentAsync(string email, string subject, string body, Attachment attachment);
    }
}
#endregion