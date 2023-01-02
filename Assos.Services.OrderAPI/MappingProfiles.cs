using AutoMapper;

namespace Assos.Services.OrderAPI
{
    public class MappingProfiles : Profile
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                
            });

            return mappingConfig;
        }
    }
}
