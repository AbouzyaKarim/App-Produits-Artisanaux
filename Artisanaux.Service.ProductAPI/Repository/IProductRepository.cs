using Artisanaux.Service.ProductAPI.Models;
using Artisanaux.Service.ProductAPI.Models.Dto;

namespace Artisanaux.Service.ProductAPI.Repository
{
    public interface IProductRepository
    {
        //Task : asynchrone method
        //IEnumerable : list without data. It get data when we demand it
        Task<IEnumerable<ProductDto>> GetProducts();
        Task<ProductDto> GetProductById(int productId);
        Task<ProductDto> CreateUpdateProduct(ProductDto productDto);
        Task<bool> DeleteProduct(int productId);
        

    }
}
