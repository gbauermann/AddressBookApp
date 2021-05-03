using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Address
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string AddressLine1 { get; set; }
        [Required]
        [MaxLength(20)]
        public string AddressLine2 { get; set; }
        [Required]
        [MaxLength(20)]
        public string State { get; set; }
        [Required]
        [MaxLength(20)]
        public string Country { get; set; }
        [Required]
        [ForeignKey("Person")]
        public int PersonId { get; set; }
    }
}
