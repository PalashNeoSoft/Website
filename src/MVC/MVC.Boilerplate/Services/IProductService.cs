using MVC.Boilerplate.Common.Models.Responses;
using MVC.Boilerplate.Models.Products;

namespace MVC.Boilerplate.Services
{
    public interface IProductService
    {
        public Task<Response<IEnumerable<Product>>?> GetAllProduct();
        public Task<Response<IEnumerable<Product>>?> GetProductByTherapistId(Guid therapistId);
    }
}
