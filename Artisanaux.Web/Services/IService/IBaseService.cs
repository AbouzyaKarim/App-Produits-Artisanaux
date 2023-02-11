using Artisanaux.Web.Models;

namespace Artisanaux.Web.Services.IService
{
    public interface IBaseService : IDisposable
    {
        public ResponseDto responseModel { get; set; }

        //Http recognize only header and body so we have to create a method to implement this function
        Task<T> SendAsync<T>(ApiRequest apiRequest);
    }
}
