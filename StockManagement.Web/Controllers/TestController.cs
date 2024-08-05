using Microsoft.AspNetCore.Mvc;
using StockManagement.Web.Abstract.Service;
using StockManagement.Web.Entities;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace StockManagement.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IStoreService _storeService;
        private readonly IOrderService _orderService;

        public TestController(IStoreService storeService, IOrderService orderService)
        {
            _storeService = storeService;
            _orderService = orderService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var data = await _storeService.GetAllAsync();
            return Ok(data);
        }
        [HttpPost]
        public async Task<IActionResult> AddEntity([FromBody] Store store)
        {
            await _storeService.AddAsync(store);
            return Ok();
        }
        [HttpGet("store-orders")]
        public IActionResult GetStoreAndOrders()
        {
            var data = _storeService.StoreAndOrdersInfo();
            return Ok(data);
        }
    }
}