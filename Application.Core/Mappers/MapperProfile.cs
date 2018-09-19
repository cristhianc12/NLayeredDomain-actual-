using AutoMapper;
using Domain.Core;

namespace Application.Core
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<House, HouseDTO>();
            CreateMap<HouseDTO, House>();
        }
    }
}
