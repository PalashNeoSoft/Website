using System.ComponentModel.DataAnnotations;

namespace MVC.Boilerplate.Models.Brands
{
    public class Brand
    {
        [Key]
        public Guid ID { get; set; }
        public string Name { get; set; }
    }
}
