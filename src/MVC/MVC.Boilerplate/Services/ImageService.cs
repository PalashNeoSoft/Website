using MVC.Boilerplate.Common.Helpers.ApiHelper;
using MVC.Boilerplate.Common.Models.Responses;
using MVC.Boilerplate.Models.Images;
using MVC.Boilerplate.Models.Videos;

namespace MVC.Boilerplate.Services
{
    public class ImageService : IImageService
    {
        private readonly IApiClient<Image> _apiClient;

        public ImageService(IApiClient<Image> apiClient)
        {
            _apiClient = apiClient;
        }


        public async Task<Response<IEnumerable<Image>>?> GetAllImages()
        {
            Response<IEnumerable<Image>> allImages = await _apiClient.GetAllAsync("Image/GetAllImages");
            return allImages;
        }

        public async Task<Response<IEnumerable<Image>>?> GetImageByTherapistId(Guid therapistId)
        {
            Response<IEnumerable<Image>> imageList = await _apiClient.GetAllAsync("Image/GetImageByTherapistId?TherapistId=" + therapistId);
            return imageList;
        }
    }
}
