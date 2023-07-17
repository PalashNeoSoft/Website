using Microsoft.AspNetCore.Mvc;
using MVC.Boilerplate.Common.Models.Responses;
using MVC.Boilerplate.Models.Videos;

namespace MVC.Boilerplate.Services
{
    public interface IVideoService
    {
        public Task<Response<IEnumerable<Video>>?> GetAllVideos();
        public Task<Response<IEnumerable<Video>>?> GetVideoByTherapistId(Guid therapistId);
    }
}
