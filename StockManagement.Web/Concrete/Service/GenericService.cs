using StockManagement.Web.Abstract.Service;
using StockManagement.Web.Concrete.Repository;
using StockManagement.Web.Context;

namespace StockManagement.Web.Concrete.Service
{
    public class GenericService<T> : GenericRepository<T>, IGenericService<T> where T : class
    {
        public GenericService(AppDbContext context) : base(context)
        {
        }
    }
}
