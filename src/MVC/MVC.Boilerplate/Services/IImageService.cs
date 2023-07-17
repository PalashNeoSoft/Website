using MVC.Boilerplate.Common.Models.Responses;
using MVC.Boilerplate.Models.Images;
using MVC.Boilerplate.Models.Videos;

namespace MVC.Boilerplate.Services
{
    public interface IImageService
    {
        public Task<Response<IEnumerable<Image>>?> GetAllImages();
        public Task<Response<IEnumerable<Image>>?> GetImageByTherapistId(Guid therapistId);
    }
}
