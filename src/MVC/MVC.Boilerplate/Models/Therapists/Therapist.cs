using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC.Boilerplate.Models.Therapists
{
    public class Therapist
    {
        [Key]
        public Guid ID { get; set; }
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string LastName { get; set; }

        [ForeignKey("Country")]
        public Guid CountryID { get; set; }
        public string ImagePath { get; set; }
    }
}
