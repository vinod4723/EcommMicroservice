using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMqProvider
{
    public interface IRabitMQConsumer
    {
        public void ReceiveMessage<T>(T message);
    }
}
