using StockManagement.Web.Entities;

namespace StockManagement.Web.Abstract.Service
{
    public interface IOrderService : IGenericService<Order>
    {
        public Task<List<Order>> OrderListWithStore(int storeId, string orderStatus);
    }
}
