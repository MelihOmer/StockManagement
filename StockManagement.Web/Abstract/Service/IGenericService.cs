using StockManagement.Web.Abstract.Repository;
using System.Linq.Expressions;

namespace StockManagement.Web.Abstract.Service
{
    public interface IGenericService<T> 
    {
        public Task<List<T>> GetAllAsync();
        public Task<List<T>> GetWhere(Expression<Func<T, bool>> filter);
        public Task<T> GetAsync(int id);
        public Task AddAsync(T entity);
        public Task UpdateAsync(T entity);
        public Task DeleteAsync(int id);
    }
}
