
using Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class PhoneNumber
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string FormatedNumber { get; set; }
        public PhoneNumberType Type { get; set; }
        [Required]
        [ForeignKey("Person")]
        public int PersonId { get; set; }
    }
}
