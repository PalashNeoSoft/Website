using MVC.Boilerplate.Common.Helpers.ApiHelper;
using MVC.Boilerplate.Common.Models.Responses;
using MVC.Boilerplate.Models.Documents;
using MVC.Boilerplate.Models.Videos;

namespace MVC.Boilerplate.Services
{
    public class DocumentService : IDocumentService
    {
        private readonly IApiClient<Document> _apiClient;

        public DocumentService(IApiClient<Document> apiClient) 
        {
            _apiClient = apiClient;
        }

        public async Task<Response<IEnumerable<Document>>?> GetAllDocuments()
        {
            Response<IEnumerable<Document>> allDocuments = await _apiClient.GetAllAsync("Document/GetAllDocuments");
            return allDocuments;
        }

        public async Task<Response<IEnumerable<Document>>?> GetDocumentByTherapistId(Guid therapistId)
        {
            Response<IEnumerable<Document>> documentList = await _apiClient.GetAllAsync("Document/GetDocumentByTherapistId?TherapistId=" + therapistId);
            return documentList;
        }
    }
}
