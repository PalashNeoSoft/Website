using MVC.Boilerplate.Models.Documents;
using MVC.Boilerplate.Models.Images;
using MVC.Boilerplate.Models.Products;
using MVC.Boilerplate.Models.Therapists;
using MVC.Boilerplate.Models.Videos;

namespace MVC.Boilerplate.Models.PartialMasterContextModel
{
    public class PartialMasterContextModel 
    {
        public Therapist Therapist { get; set; }
        public List<Video> VideoList { get; set; }
        public List<Document> DocumentList { get; set; }
        public List<Image> ImageList { get; set; }
        public List<Product> ProductList { get; set; }
    }
}
