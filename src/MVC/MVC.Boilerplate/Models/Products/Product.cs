using MVC.Boilerplate.Models.Brands;
using MVC.Boilerplate.Models.TerapCategorys;
using MVC.Boilerplate.Models.Therapists;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing.Drawing2D;

namespace MVC.Boilerplate.Models.Products
{
    public class Product
    {
        [Key]
        public Guid ID { get; set; } // Primary key
        public string Name { get; set; }
        public string KeyFeature { get; set; }
        public string Description { get; set; }
        public string Overview { get; set; }
        public string Specification { get; set; }

        [ForeignKey("Brand")]
        public Guid BrandId { get; set; }
        [ForeignKey("Therapist")]
        public Guid TherapistId { get; set; }
        [ForeignKey("Category")]
        public Guid CategoryId { get; set; }

        public Brand Brand { get; set; }

        public Therapist Therapist { get; set; }

        public TerapCategory Category { get; set; }

    }
}
