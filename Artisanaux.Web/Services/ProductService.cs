using Artisanaux.Web.Models;
using Artisanaux.Web.Services.IService;

namespace Artisanaux.Web.Services
{
    public class ProductService : BaseService , IProductService
    {
        private readonly IHttpClientFactory _clientFactory;

        public ProductService(IHttpClientFactory httpClient):base(httpClient)
        {
            _clientFactory = httpClient;
        }
        public ResponseDto responseModel { get ; set; }

        public async Task<T> DeleteProductAsync<T>(int id)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                apitype = SD.APIType.DELETE,
                URL = SD.ProductAPIBase + "/api/products/"+id,
                AccessToken = ""
            });
        }

       
        public async Task<T> GetAllProductsAsync<T>()
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                apitype=SD.APIType.GET,
                URL=SD.ProductAPIBase+"/api/products",
                AccessToken=""
            });


        }

        public async Task<T> GetByProductIdAsync<T>(int id)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                apitype = SD.APIType.GET,
                URL = SD.ProductAPIBase + "/api/products/"+id,
                AccessToken = ""
            });
        }

        public async Task<T> CreateProductAsync<T>(ProductDto productDto)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                apitype = SD.APIType.POST,
                URL = SD.ProductAPIBase + "/api/products",
                AccessToken = "",
                DATA = productDto
            });
        }

       

        public async Task<T> UpdateProductAsync<T>(ProductDto productDto)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                apitype = SD.APIType.PUT,
                URL = SD.ProductAPIBase + "/api/products",
                AccessToken = "",
                DATA = productDto
            });
        }

       

    }
}
