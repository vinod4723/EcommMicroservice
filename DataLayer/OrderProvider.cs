using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class OrderProvider : IOrderProvider
    {

        private readonly ApplicationDbContext _dbContext;

        public OrderProvider(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool AddOrders(Order order)
        {
            _dbContext.Orders.Add(order);
            return true;
        }

        public List<Order> GetAllOrders()
        {
            return _dbContext.Orders.ToList();
        }
    }
    public class ProductProvider : IProductProvider
    {

        private readonly ApplicationDbContext _dbContext;

        public ProductProvider(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public List<Product> GetAllProducts()
        {
            return _dbContext.Products.ToList();
        }
    }

}
