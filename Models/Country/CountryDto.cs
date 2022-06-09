using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_dev_lessons.Models.Country
{
    public class CountryDto : BaseCountryDto
    {
        public int Id { get; set; }
        public List<HotelDto> Hotels { get; set; }

    }
}