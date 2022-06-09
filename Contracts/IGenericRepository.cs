using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_dev_lessons.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetAsync(int? id);
        Task<List<T>> GetAllAsync(int? id);
        Task<T> AddAsync(T entity);

        Task DeleteAsync(int id);
        Task UpdateAsync(T entity);

        Task<bool> Exists(int id);
    }
}