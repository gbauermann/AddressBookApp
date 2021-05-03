
using Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Document
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string RegisterNumber { get; set; }
        [Required]
        public DocumentType Type { get; set; }
        public DateTime? Emission { get; set; }
        public DateTime? Expiration { get; set; }
        [Required]
        [ForeignKey("Person")]
        public int PersonId { get; set; }
    }
}
