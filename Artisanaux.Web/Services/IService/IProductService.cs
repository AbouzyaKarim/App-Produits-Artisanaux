using Artisanaux.Web.Models;

namespace Artisanaux.Web.Services.IService
{
    public interface IProductService : IBaseService
    {
        //token
        Task<T> GetAllProductsAsync<T>();
        Task<T> GetByProductIdAsync<T>(int id);
        Task<T> CreateProductAsync<T>(ProductDto productDto);
        Task<T> UpdateProductAsync<T>(ProductDto productDto);
        Task<T> DeleteProductAsync<T>(int id);
    }
}
