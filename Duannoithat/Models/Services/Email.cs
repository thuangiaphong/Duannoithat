using Microsoft.AspNetCore.Identity.UI.Services;
using System.Threading.Tasks;

namespace Duannoithat.Models.Services
{
    public class Email : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            Console.WriteLine($"Fake email sent to {email}: {subject}");
            return Task.CompletedTask;
        }
    }
}
