using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_dev_lessons.Data;
using api_dev_lessons.Models.Country;
using AutoMapper;

namespace api_dev_lessons.Configurations
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Country, CreateCountryDto>().ReverseMap();
            CreateMap<Country, GetCountryDto>().ReverseMap();
            CreateMap<Country, CountryDto>().ReverseMap();
            CreateMap<Country, UpdateCountryDto>().ReverseMap();

            CreateMap<Hotel, HotelDto>().ReverseMap();
        }
    }
}