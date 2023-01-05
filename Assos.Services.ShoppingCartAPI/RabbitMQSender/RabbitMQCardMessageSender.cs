using Assos.MessageBus;
using NetMQ;
using Newtonsoft.Json;
using RabbitMQ.Client;
using System;
using System.Text;

namespace Assos.Services.ShoppingCartAPI.RabbitMQSender
{
    public class RabbitMQCardMessageSender : IRabbitMQCardMessageSender
    {

        private readonly string _hostname;
        private readonly string _password;
        private readonly string _username;
        private IConnection _connection;

        public RabbitMQCardMessageSender()
        {
            _hostname = "localhost";
            _password = "guest";
            _username = "guest";
        }

       

        public void SendMessage(BaseMessage message, string queueName)
        {
            if (ConnectionExists())
            {
                using var channel = _connection.CreateModel();
                channel.QueueDeclare(queue: queueName, false, false, false, arguments: null);
                var json = JsonConvert.SerializeObject(message);
                var body = Encoding.UTF8.GetBytes(json);
                channel.BasicPublish(exchange: "", routingKey: queueName, basicProperties: null, body: body);
            }

          
        }


        private void CreateConnection()
        {
            try
            {

                var factory = new ConnectionFactory
                {
                    HostName = _hostname,
                    Password = _password,
                    UserName = _username
                };
                _connection = factory.CreateConnection();
            }
            catch(Exception ex)
            {

            }
        }

        private bool ConnectionExists()
        {
            if(_connection != null)
            {
                return true;
            }
            CreateConnection();
            return _connection != null;
        }
    }
}
