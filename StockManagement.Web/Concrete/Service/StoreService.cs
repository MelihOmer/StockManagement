using Microsoft.EntityFrameworkCore;
using StockManagement.Web.Abstract.Service;
using StockManagement.Web.Concrete.Dtos.StoreAndOrders;
using StockManagement.Web.Context;
using StockManagement.Web.Entities;

namespace StockManagement.Web.Concrete.Service
{
    public class StoreService : GenericService<Store> ,IStoreService
    {
        private readonly AppDbContext _context;
        public StoreService(AppDbContext context) : base(context)
        {
            _context = context;
        }
        public List<StoreAndOrdersDto> StoreAndOrdersInfo()
        {
            var datas = _context.Stores
                .Select(x => new StoreAndOrdersDto
                {
                    Store = new StoreInfo { StoreId = x.Id,StoreName = x.StoreName,StoreCode =x.StoreCode},
                    PendingOrders = x.Orders.Where(order => order.OrderStatus == "0").Count(),
                    CompletedOrders = x.Orders.Where(order => order.OrderStatus == "1").Count(),
                    TotalOrders = x.Orders.Count

                }).ToList();
            return datas;


        }
    }
}
