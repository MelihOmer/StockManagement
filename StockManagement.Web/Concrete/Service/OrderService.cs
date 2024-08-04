using StockManagement.Web.Abstract.Service;
using StockManagement.Web.Context;
using StockManagement.Web.Entities;

namespace StockManagement.Web.Concrete.Service
{
    public class OrderService : GenericService<Order>, IOrderService
    {
        public OrderService(AppDbContext context) : base(context)
        {
        }
    }
}
