using System.ComponentModel.DataAnnotations;

namespace MVC.Boilerplate.Models.TerapCategorys
{
    public class TerapCategory
    {
        [Key]
        public Guid ID { get; set; }
        public string Name { get; set; }
    }
}
