using Assos.Services.ShoppingCartAPI.Models.Dto;
using System.Threading.Tasks;

namespace Assos.Services.ShoppingCartAPI.Repository
{
    public interface ICouponRepository
    {
        Task<CouponDto> GetCoupon(string couponName);
    }
}
