using Assos.Services.CouponAPI.Models;
using Assos.Services.CouponAPI.Models.Dto;
using AutoMapper;
using System.Reflection.PortableExecutable;

namespace Assos.Services.CouponAPI
{
    public class MappingProfiles : Profile
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CouponDto,Coupon>().ReverseMap();
            });

            return mappingConfig;
        }
    }
}
