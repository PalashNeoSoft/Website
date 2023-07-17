using MVC.Boilerplate.Common.Helpers.ApiHelper;
using MVC.Boilerplate.Common.Models.Responses;
using MVC.Boilerplate.Models.Therapists;

namespace MVC.Boilerplate.Services
{
    public class TherapistService : ITherapistService
    {
        private readonly IApiClient<Therapist> _apiClient;
        public TherapistService(IApiClient<Therapist> apiClient)
        {
            _apiClient = apiClient;

        }

        public async Task<Response<IEnumerable<Therapist>>?> GetAllTherapist()
        {
            Response<IEnumerable<Therapist>> data = await _apiClient.GetAllAsync("Therapist/GetAllTherapists");
            return data;
        }

        public async Task<Response<Therapist>?> GetTherapistByID(Guid therapistId)
        {
            Response<Therapist> data = await _apiClient.GetByIdAsync("Therapist/GetTherapistByID?id=" + therapistId);
            return data;
        }
    }
}
