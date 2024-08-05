using StockManagement.Web.Concrete.Dtos.StoreAndOrders;
using StockManagement.Web.Entities;

namespace StockManagement.Web.Abstract.Service
{
    public interface IStoreService : IGenericService<Store>
    {
        public List<StoreAndOrdersDto> StoreAndOrdersInfo();

    }
}
