using MVC.Boilerplate.Common.Helpers.ApiHelper;
using MVC.Boilerplate.Common.Models.Responses;
using MVC.Boilerplate.Models.Therapists;

namespace MVC.Boilerplate.Services
{
    public interface ITherapistService
    {
        public Task<Response<IEnumerable<Therapist>>?> GetAllTherapist();
        public Task<Response<Therapist>?> GetTherapistByID(Guid therapistId);
    }
}
