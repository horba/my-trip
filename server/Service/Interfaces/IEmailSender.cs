using System.Threading.Tasks;
using Service.Models;

namespace Service.Interfaces
{
    public interface IEmailSender
    {
        void SendEmail(Message message);
        Task SendEmailAsync(Message message);
    }
}
