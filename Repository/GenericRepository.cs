using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_dev_lessons.Contracts;
using api_dev_lessons.Data;
using Microsoft.EntityFrameworkCore;

namespace api_dev_lessons.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly HotelListingDbContext context;
        public GenericRepository(HotelListingDbContext context)
        {
            this.context = context;
            
        }
        public async Task<T> AddAsync(T entity)
        {
            await this.context.AddAsync(entity);
            await this.context.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await GetAsync(id);
            this.context.Set<T>().Remove(entity);
            await context.SaveChangesAsync();
        }

        public async Task<bool> Exists(int id)
        {
            var entity = await GetAsync(id);
            return entity is not null;
        }

        public async Task<List<T>> GetAllAsync(int? id)
        {
            return await this.context.Set<T>().ToListAsync();
        }

        public async Task<T> GetAsync(int? id)
        {
            if (id is null)
            {
                return null;
            }

            return await this.context.Set<T>().FindAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
            this.context.Update(entity);
            await this.context.SaveChangesAsync();
        }
    }
}