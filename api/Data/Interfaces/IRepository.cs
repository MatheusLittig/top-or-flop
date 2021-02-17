using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data.Interfaces;

namespace api.Repositories
{
    public interface IRepository<T> where T : class, new()
    {
        IQueryable<T> GetAll();
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(int id);
    }
}