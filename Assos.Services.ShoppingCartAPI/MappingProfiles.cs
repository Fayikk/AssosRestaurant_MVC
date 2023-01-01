using Assos.Services.ShoppingCartAPI.Models;
using Assos.Services.ShoppingCartAPI.Models.Dto;
using AutoMapper;

namespace Assos.Services.ShoppingCartAPI
{
    public class MappingProfiles : Profile
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>().ReverseMap();
                config.CreateMap<CartHeader, CartHeaderDto>().ReverseMap();
                config.CreateMap<CartDetails, CartDetailsDto>().ReverseMap();
                config.CreateMap<CartDto, Cart>().ReverseMap();
            });

            return mappingConfig;
        }
    }
}
