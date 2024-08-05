using Microsoft.EntityFrameworkCore;
using StockManagement.Web.Abstract.Service;
using StockManagement.Web.Context;
using StockManagement.Web.Entities;

namespace StockManagement.Web.Concrete.Service
{
    public class OrderService : GenericService<Order>, IOrderService
    {
        private readonly AppDbContext _context;
        public OrderService(AppDbContext context) : base(context)
        {
            _context = context;
        }
        public async Task<List<Order>> OrderListWithStore(int storeId, string orderStatus)
        {
            var result = await _context.Orders
                .Where(x => x.StoreId == storeId && x.OrderStatus == orderStatus)
                .AsNoTracking()
                .Include(x => x.Store)
                .ToListAsync();
            return result;
            
        }
        

    }
}
