using StockManagement.Web.Abstract.Service;
using StockManagement.Web.Context;
using StockManagement.Web.Entities;

namespace StockManagement.Web.Concrete.Service
{
    public class ProductService : GenericService<Product>, IProductService
    {
        public ProductService(AppDbContext context) : base(context)
        {
        }
    }
}
