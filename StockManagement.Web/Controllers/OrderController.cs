using Microsoft.AspNetCore.Mvc;
using StockManagement.Web.Abstract.Service;
using StockManagement.Web.Concrete.Dtos.OrderDto;
using StockManagement.Web.Entities;

namespace StockManagement.Web.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("order-list")]
        public async Task<IActionResult> Index(int storeId,string orderStatus)
        {
            var result = await _orderService.OrderListWithStore(storeId,orderStatus);
            return View(result);
        }
        [HttpGet("order-create")]
        public async Task<IActionResult> CreateOrder()
        {
            return View(new OrderCreateModel());
        }
        [HttpPost("order-create")]
        public async Task<IActionResult> CreateOrder(OrderCreateModel orderCreateModel)
        {
            Order order = new()
            {
                OrderDate = orderCreateModel.OrderDate,
                OrderNote = orderCreateModel.OrderNote,
                OrderStatus = "0",
                StoreId = 1
            };
            await _orderService.AddAsync(order);
            return View();
        }
    }
}
