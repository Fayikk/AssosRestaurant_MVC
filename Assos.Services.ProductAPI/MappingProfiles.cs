using Assos.Services.ProductAPI.Model;
using Assos.Services.ProductAPI.Model.Dto;
using AutoMapper;

namespace Assos.Services.ProductAPI
{
    public class MappingProfiles : Profile
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>();
                config.CreateMap<Product, ProductDto>();
            });

            return mappingConfig;
        }

    }
}
