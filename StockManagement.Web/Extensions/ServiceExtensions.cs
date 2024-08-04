using Microsoft.EntityFrameworkCore;
using StockManagement.Web.Abstract.Repository;
using StockManagement.Web.Abstract.Service;
using StockManagement.Web.Concrete.Repository;
using StockManagement.Web.Concrete.Service;
using StockManagement.Web.Context;

namespace StockManagement.Web.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddServiceExtension(this IServiceCollection services,IConfiguration configuration)
        {
            //DbConnectService
            services.AddDbContext<AppDbContext>(cfg =>
            {
                cfg.UseSqlServer(configuration.GetConnectionString("default"));
            });
            //GenericRepository and GenericService  
            services.AddScoped(typeof(IGenericRepository<>),typeof(GenericRepository<>));
            services.AddScoped(typeof(IGenericService<>), typeof(GenericService<>));
            //Entities Service
            services.AddScoped<IStoreService, StoreService>();
            services.AddScoped<IOrderDetailService,OrderDetailService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IProductService, ProductService>();
        }
    }
}
