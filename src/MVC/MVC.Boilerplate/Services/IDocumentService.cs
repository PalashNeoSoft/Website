using MVC.Boilerplate.Common.Models.Responses;
using MVC.Boilerplate.Models.Documents;
using MVC.Boilerplate.Models.Videos;

namespace MVC.Boilerplate.Services
{
    public interface IDocumentService
    {
        public Task<Response<IEnumerable<Document>>?> GetAllDocuments();
        public Task<Response<IEnumerable<Document>>?> GetDocumentByTherapistId(Guid therapistId);
    }
}
