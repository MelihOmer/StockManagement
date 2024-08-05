using Microsoft.AspNetCore.Mvc;
using StockManagement.Web.Abstract.Service;

namespace StockManagement.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStoreService _storeService;

        public HomeController(IStoreService storeService)
        {
            _storeService = storeService;
        }


        [HttpGet]
        public  IActionResult Index()
        {
            var datas =  _storeService.StoreAndOrdersInfo();
            return View(datas);
        }


    }
}
