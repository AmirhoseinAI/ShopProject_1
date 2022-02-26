using AutoMapper;
using Core.Domain;
using Infrastructure.Context;
using Infrastructure.Entities;

namespace Infrastructure.Map
{
    public class AutoMap : Profile
    {
        public AutoMap()
        {
            CreateMap<MCategory , Category>().ReverseMap();
            CreateMap<MColor , Color>().ReverseMap();
            CreateMap<MSize , Size>().ReverseMap();
        }
    }
}