
using User.Management.Service.Models;

namespace User.Management.Service.Services
{
    internal interface IEmailService
    {
        void SendEmail(Message message);
    }
}
