using Microsoft.AspNetCore.Mvc;
using MVC.Boilerplate.Common.Models.Responses;
using MVC.Boilerplate.Models.Documents;
using MVC.Boilerplate.Models.Images;
using MVC.Boilerplate.Models.PartialMasterContextModel;
using MVC.Boilerplate.Models.Products;
using MVC.Boilerplate.Models.Therapists;
using MVC.Boilerplate.Models.Videos;
using MVC.Boilerplate.Services;

namespace MVC.Boilerplate.Controllers
{
    public class TherapistController : Controller
    {
        private readonly ITherapistService _therapistService;
        private readonly IVideoService _videoService;
        private readonly IImageService _imageService;
        private readonly IDocumentService _documentService;
        private readonly IProductService _productService;

        public TherapistController(ITherapistService therapistService, IVideoService videoService, IImageService imageService, IDocumentService documentService, IProductService productService) 
        {
            _therapistService = therapistService;
            _videoService = videoService;
            _imageService = imageService;
            _documentService = documentService;
            _productService = productService;
        }

        public async Task<IActionResult> Index()
        {
            var therapist = _therapistService.GetAllTherapist();
            return View(therapist.Result.Data.ToList());
        }

        
        public async Task<IActionResult> TherapistProfile(Guid id)
        {
            //string guid = "0C72F07A-11BC-4C0C-B7AB-111293B7286E";
            //Guid therapistId = new Guid(guid);

            //Therapist
            Response<Therapist>? therapist = await _therapistService.GetTherapistByID(id);
            if (therapist == null)
            {
                return NotFound();
            }

            //Videos
            var videoList = await _videoService.GetVideoByTherapistId(id);
            if (videoList == null)
            {
                return NotFound();
            }

            //Images
            var imageList = await _imageService.GetImageByTherapistId(id);
            if (imageList == null)
            {
                return NotFound();
            }

            //Documents
            var documentList = await _documentService.GetDocumentByTherapistId(id);
            if (documentList == null)
            {
                return NotFound();
            }

            //Products
            var ProductList = await _productService.GetProductByTherapistId(id);
            if (ProductList == null)
            {
                return NotFound();
            }

            PartialMasterContextModel partialMasterContextModel = new PartialMasterContextModel();
            partialMasterContextModel.Therapist = therapist.Data;
            partialMasterContextModel.ProductList = ProductList.Data.ToList();
            partialMasterContextModel.DocumentList = documentList.Data.ToList();
            partialMasterContextModel.VideoList = videoList.Data.ToList();
            partialMasterContextModel.ImageList = imageList.Data.ToList();
            return View(partialMasterContextModel);
        }



        //=================================================================================================================================
        //=================================================================================================================================
        //=================================================================================================================================



        //public async Task<IActionResult> Index()
        //{           
        //    string guid = "0C72F07A-11BC-4C0C-B7AB-111293B7286E";
        //    Guid therapistId = new Guid(guid);

        //    //Videos
        //    var videoList = await _videoService.GetVideoByTherapistId(therapistId);
        //    if (videoList == null)
        //    {
        //        return NotFound();
        //    }

        //    //Images
        //    var imageList = await _imageService.GetImageByTherapistId(therapistId);
        //    if (imageList == null)
        //    {
        //        return NotFound();
        //    }

        //    //Documents
        //    var documentList = await _documentService.GetDocumentByTherapistId(therapistId);
        //    if (documentList == null)
        //    {
        //        return NotFound();
        //    }

        //    //Products
        //    var ProductList = await _productService.GetProductByTherapistId(therapistId);
        //    if (ProductList == null)
        //    {
        //        return NotFound();
        //    }

        //    PartialMasterContextModel partialMasterContextModel = new PartialMasterContextModel();
        //    //partialMasterContextModel.VideoList = videoList;
        //    //partialMasterContextModel.ProductList = ProductList;
        //    //partialMasterContextModel.DocumentList = DocumentList;
        //    //partialMasterContextModel.ImageList = ImageList;

        //    partialMasterContextModel.ProductList = ProductList.Data.ToList();
        //    partialMasterContextModel.DocumentList = documentList.Data.ToList();
        //    partialMasterContextModel.VideoList = videoList.Data.ToList();
        //    partialMasterContextModel.ImageList = imageList.Data.ToList();
        //    //ViewBag.VideoList = videoList;
        //    return View(partialMasterContextModel);



        //    //Rough Data
        //    //------------------------------------------------------------------------------------------------------------------

        //    //List<Video> videoList = new List<Video>()
        //    //{
        //    //    new Video(){Title="VideoTest1",Description="VideoTest1",Path="Videotest1.com",PostedDate=new DateTime()},
        //    //     new Video(){Title="VideoTest2",Description="VideoTest2",Path="Videotest2.com",PostedDate=new DateTime()},
        //    //      new Video(){Title="VideoTest3",Description="VideoTest3",Path="Videotest3.com",PostedDate=new DateTime()},
        //    //       new Video(){Title="VideoTest4",Description="VideoTest4",Path="Videotest.com",PostedDate=new DateTime()}
        //    //};
        //    //List<Image> ImageList = new List<Image>()
        //    //{
        //    //    new Image(){Title="ImageTest1",Description="ImageTest1",Path="Imagetest1.com",PostedDate=new DateTime()},
        //    //     new Image(){Title="ImageTest2",Description="ImageTest2",Path="Imagetest2.com",PostedDate=new DateTime()},
        //    //      new Image(){Title="ImageTest3",Description="ImageTest3",Path="Imagetest3.com",PostedDate=new DateTime()},
        //    //       new Image(){Title="ImageTest4",Description="ImageTest4",Path="Imagetest.com",PostedDate=new DateTime()}
        //    //};
        //    //List<Document> DocumentList = new List<Document>()
        //    //{
        //    //    new Document(){Title="DocTest1",Description="DocTest1",Path="Doctest1.com",PostedDate=new DateTime()},
        //    //     new Document(){Title="DocTest2",Description="DocTest2",Path="Doctest2.com",PostedDate=new DateTime()},
        //    //      new Document(){Title="DocTest3",Description="DocTest3",Path="Doctest3.com",PostedDate=new DateTime()},
        //    //       new Document(){Title="DocTest4",Description="DocTest4",Path="Doctest.com",PostedDate=new DateTime()}
        //    //};
        //    //List<Product> ProductList = new List<Product>()
        //    //{
        //    //    new Product(){Name="productTest1",Overview="ProductTest1",Description="productTest1",KeyFeature="ProductTest1",Specification="ProductTest1"},
        //    //    new Product(){Name="productTest2",Overview="ProductTest2",Description="productTest2",KeyFeature="ProductTest2",Specification="ProductTest2"}
        //    //};
        //}

    }
}
