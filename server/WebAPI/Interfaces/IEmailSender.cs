using System.Threading.Tasks;
using WebAPI.DTO;

namespace WebAPI.Interfaces
{
  public interface IEmailSender
    {
        void SendEmail(Message message);
        Task SendEmailAsync(Message message);
    }
}
