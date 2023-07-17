using MVC.Boilerplate.Models.TerapCategorys;
using MVC.Boilerplate.Models.Therapists;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC.Boilerplate.Models.Images
{
    public class Image
    {

        [Key]
        public Guid ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Path { get; set; }
        public DateTime PostedDate { get; set; }

        [ForeignKey("Therapist")]
        public Guid TherapistId { get; set; }
        [ForeignKey("TerapCategory")]
        public Guid CategoryId { get; set; }

        public Therapist Therapist { get; set; }

        public TerapCategory Category { get; set; }
    }
}
