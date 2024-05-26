﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMqProvider
{
    public interface IRabitMQProducer
    {
        public void PublishMessage<T>(T message);
    }
}
