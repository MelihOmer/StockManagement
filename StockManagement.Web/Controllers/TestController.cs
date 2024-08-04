using Microsoft.AspNetCore.Mvc;
using StockManagement.Web.Abstract.Service;
using StockManagement.Web.Entities;

namespace StockManagement.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IStoreService _storeService;

        public TestController(IStoreService storeService)
        {
            _storeService = storeService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var data = await _storeService.GetAllAsync();
            return Ok(data);
        }
        [HttpPost]
        public async Task<IActionResult> AddEntity([FromBody]Store store)
        {
            await _storeService.AddAsync(store);
            return Ok();
        }
    }
}
