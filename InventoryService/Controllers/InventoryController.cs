using DataLayer;
using Microsoft.AspNetCore.Mvc;

namespace InventoryService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InventoryController : ControllerBase
    {

        IProductProvider _productProvider;
        public InventoryController(IProductProvider productProvider)
        {
            _productProvider = productProvider;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _productProvider.GetAllProducts();
        }
    }
}
