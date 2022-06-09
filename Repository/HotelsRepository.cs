using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_dev_lessons.Contracts;
using api_dev_lessons.Data;

namespace api_dev_lessons.Repository
{
    public class HotelsRepository : GenericRepository<Hotel>, IHotelsRepository
    {
        public HotelsRepository(HotelListingDbContext context) : base(context)
        {
        }
    }
}