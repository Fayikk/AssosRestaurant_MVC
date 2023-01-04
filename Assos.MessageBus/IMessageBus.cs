using Assos.MessageBus;
using System;
using System.Threading.Tasks;

namespace Assos.MessageBus
{
    public interface IMessageBus
    {
        Task PublishMessage(BaseMessage message, string topicName);
    }
}