using System.Threading.Tasks;

namespace Assos.Web.Services.IServices
{
    public interface ICouponService
    {
        Task<T> GetCoupon<T>(string couponCode, string token = null);
    }
}
