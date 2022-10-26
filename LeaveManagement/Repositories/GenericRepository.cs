using LeaveManagement.Data;
using LeaveManagement.Repository;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext _Context;
        public GenericRepository(ApplicationDbContext context)
        {
            _Context = context;
        }


        public async Task<T> CreateAsync(T entity)
        {
            //throw new NotImplementedException();
            await _Context.AddAsync(entity);
            await _Context.SaveChangesAsync();
            return entity;

        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _Context.Set<T>().FindAsync(id);
                             _Context.Set<T>().Remove(entity);
                            await _Context.SaveChangesAsync();
        }

        public async Task<bool> Exists(int id)
        {
            var entity = await GetAsync(id);
            return entity != null;
        }

        public async Task<List<T>> GetAllAsync()
        {
            var list = await _Context.Set<T>().ToListAsync();
            return list;
            
        }

        public async Task<T?> GetAsync(int? id)
        {

            if(id == null)
            {
                return null;
            }
            var result = await _Context.Set<T>().FindAsync(id);
            return result;

        }

        public async Task UpdateAsync(T entity)
        {
            // _Context.Entry(entity).State = EntityState.Modified;
            _Context.Update(entity);
            await _Context.SaveChangesAsync();
            
        }
    }
}
