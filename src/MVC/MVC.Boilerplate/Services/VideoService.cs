using Microsoft.AspNetCore.Mvc;
using MVC.Boilerplate.Common.Helpers.ApiHelper;
using MVC.Boilerplate.Common.Models.Responses;
using MVC.Boilerplate.Models.Therapists;
using MVC.Boilerplate.Models.Videos;

namespace MVC.Boilerplate.Services
{
    public class VideoService : IVideoService
    {
        private readonly IApiClient<Video> _apiClient;

        public VideoService(IApiClient<Video> apiClient) 
        {             
            _apiClient = apiClient;
        }

        public async Task<Response<IEnumerable<Video>>?> GetAllVideos()
        {
            Response<IEnumerable<Video>> allVideos = await _apiClient.GetAllAsync("Video/GetAllVideos");
            return allVideos;
        }

        public async Task<Response<IEnumerable<Video>>?> GetVideoByTherapistId(Guid therapistId)
        {
            Response<IEnumerable<Video>> videoList = await _apiClient.GetAllAsync("Video/GetVideoByTherapistId?TherapistId=" + therapistId);
            return videoList;
        }
    }
}
