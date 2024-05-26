using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IOrderProvider
    {
        bool AddOrders(Order order);
        List<Order> GetAllOrders();
    }

    public interface IProductProvider
    {
        List<Product> GetAllProducts();
    }
}
