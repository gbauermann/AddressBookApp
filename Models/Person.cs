using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Person
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        public List<Document> Documents { get; set; }
        public List<PhoneNumber> PhoneNumbers { get; set; }
        public List<Address> Addresses { get; set; }

        public Person()
        {
            Documents = new List<Document>();
            PhoneNumbers = new List<PhoneNumber>();
            Addresses = new List<Address>();
        }
    }
}
