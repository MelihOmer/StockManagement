using Microsoft.EntityFrameworkCore;
using StockManagement.Web.Abstract.Repository;
using StockManagement.Web.Context;

namespace StockManagement.Web.Concrete.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly AppDbContext _context;
        private DbSet<T> _table;
        public GenericRepository(AppDbContext context)
        {
            _context = context;
            _table = _context.Set<T>();
        }

        public async Task AddAsync(T entity)
        {
            await _table.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity =await _table.FindAsync(id);
            _table.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<List<T>> GetAllAsync()
        {
            var datas = await _table.ToListAsync();
            return datas;
        }

        public async Task<T> GetAsync(int id)
        {
            var data = await _table.FindAsync(id);
            return data;
        }

        public async Task UpdateAsync(T entity)
        {
            _table.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
