using Assos.Services.ShoppingCartAPI.Models.Dto;
using System.Threading.Tasks;

namespace Assos.Services.ShoppingCartAPI.Repository
{
    public interface ICartRepository
    {
        Task<CartDto> GetCartBuUserId(string userId);
        Task<CartDto> CreateUpdateCart(CartDto cartDto);
        Task<bool> RemoveFromCart(int carDetailsId);
        Task<bool> ClearCart(string userId);

    }
}
