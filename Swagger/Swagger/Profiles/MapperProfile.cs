using Swagger.Data.Entities;
using Swagger.Dto;
using AutoMapper;

namespace Swagger.Profiles
{
    public class MapperProfile:Profile
    {
        public MapperProfile()
        {
            CreateMap<Product, ProductReturnDto>()
                .ForMember(ds => ds.FullImageUrl, map => map.MapFrom(sr => "https://localhost:44358/img/"+sr.ImageUrl));
        }
    }
}
