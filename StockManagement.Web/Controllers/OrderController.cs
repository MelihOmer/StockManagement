using Microsoft.AspNetCore.Mvc;
using StockManagement.Web.Abstract.Service;

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
            var result = await _orderService.GetWhere(x => x.StoreId == storeId && x.OrderStatus == orderStatus);
            return View(result);
        }
    }
}
