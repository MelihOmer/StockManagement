using StockManagement.Web.Abstract.Service;
using StockManagement.Web.Context;
using StockManagement.Web.Entities;

namespace StockManagement.Web.Concrete.Service
{
    public class StoreService : GenericService<Store> ,IStoreService
    {
        public StoreService(AppDbContext context) : base(context)
        {
        }
    }
}
