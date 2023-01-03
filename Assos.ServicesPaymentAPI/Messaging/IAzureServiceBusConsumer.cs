using System.Threading.Tasks;

namespace Assos.Services.PaymentAPI.Messaging
{
    public interface IAzureServiceBusConsumer
    {
        Task Start();
        Task Stop();
    }
}
