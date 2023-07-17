using MVC.Boilerplate.Common.Helpers.ApiHelper;
using MVC.Boilerplate.Common.Models.Responses;
using MVC.Boilerplate.Models.Products;

namespace MVC.Boilerplate.Services
{
    public class ProductService : IProductService
    {
        private readonly IApiClient<Product> _apiClient;

        public ProductService(IApiClient<Product> apiClient)
        {
            _apiClient = apiClient;
        }

        public async Task<Response<IEnumerable<Product>>?> GetAllProduct()
        {
            Response<IEnumerable<Product>> allProducts = await _apiClient.GetAllAsync("Product/GetAllProduct");
            return allProducts;
        }

        public async Task<Response<IEnumerable<Product>>?> GetProductByTherapistId(Guid therapistId)
        {
            Response<IEnumerable<Product>> productList = await _apiClient.GetAllAsync("Product/GetProductByTherapistId?therapistId=" + therapistId);
            return productList;
        }
    }
}
