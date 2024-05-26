using Microsoft.AspNetCore.Mvc;
using DataLayer;
using RabbitMqProvider;

namespace OrderService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        IOrderProvider _orderProvider;
        IRabitMQProducer _rabitMQProducer;
        public OrderController(IOrderProvider orderProvider, IRabitMQProducer rabitMQProducer) {
            _orderProvider = orderProvider;
            _rabitMQProducer = rabitMQProducer;
        }

        [HttpGet]
        public IEnumerable<Order> Get()
        {
           return _orderProvider.GetAllOrders();
        }

        [HttpPost]
        public bool AddOrder(Order order)
        {
            _orderProvider.AddOrders(order);
            _rabitMQProducer.PublishMessage<Order>(order);
            return true;
        }
    }
}
