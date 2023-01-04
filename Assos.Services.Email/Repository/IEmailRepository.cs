using Assos.Services.Email.Messages;
using System.Threading.Tasks;

namespace Assos.Services.Email.Repository
{
    public interface IEmailRepository
    {
        Task SendAndLogEmail(UpdatePaymentResultMessage message);
    }
}
