using Assos.Services.CouponAPI.Models.Dto;
using System.Threading.Tasks;

namespace Assos.Services.CouponAPI.Repository
{
    public interface ICouponRepository
    {
        Task<CouponDto> GetCouponByCode(string couponCode);
    }
}
