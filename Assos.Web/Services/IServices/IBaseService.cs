using Assos.Web.Models;
using System;
using System.Threading.Tasks;

namespace Assos.Web.Services.IServices
{
    public interface IBaseService : IDisposable
    {
        Task<T> SendAsync<T>(ApiRequest apiRequest);
        ResponseDto responseModel { get; set; }

    }
}
