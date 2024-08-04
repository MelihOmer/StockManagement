using StockManagement.Web.Abstract.Service;
using StockManagement.Web.Context;
using StockManagement.Web.Entities;

namespace StockManagement.Web.Concrete.Service
{
    public class OrderDetailService : GenericService<OrderDetail>, IOrderDetailService
    {
        public OrderDetailService(AppDbContext context) : base(context)
        {
        }
    }
}
