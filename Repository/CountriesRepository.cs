using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_dev_lessons.Contracts;
using api_dev_lessons.Data;
using Microsoft.EntityFrameworkCore;

namespace api_dev_lessons.Repository
{
    public class CountriesRepository : GenericRepository<Country>, ICountriesRepository
    {
        private readonly HotelListingDbContext _context;

        public CountriesRepository(HotelListingDbContext context) : base(context)
        {
            this._context = context;
        }

        public async Task<Country> GetDetails(int id)
        {
            return await _context.Countries.Include(a => a.Hotels)
                .FirstOrDefaultAsync(h => h.Id == id);
        }
    }
}