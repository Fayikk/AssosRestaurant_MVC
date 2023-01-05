using Assos.MessageBus;

namespace Assos.Services.ShoppingCartAPI.RabbitMQSender
{
    public interface IRabbitMQCardMessageSender
    {
        void SendMessage(BaseMessage baseMessage,string queueName);
    }
}
