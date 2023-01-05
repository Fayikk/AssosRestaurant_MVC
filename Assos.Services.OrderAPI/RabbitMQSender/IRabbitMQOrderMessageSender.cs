using Assos.MessageBus;

namespace Assos.Services.OrderAPI.RabbitMQSender
{
    public interface IRabbitMQOrderMessageSender
    {
        void SendMessage(BaseMessage baseMessage,string queueName);
    }
}
