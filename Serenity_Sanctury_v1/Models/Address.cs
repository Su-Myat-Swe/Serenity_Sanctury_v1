using System.ComponentModel.DataAnnotations;

namespace Serenity_Sanctury_v1.Models
{
    public class Address
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(100)]
        public string Streetline { get; set; }

        [Required]
        [MaxLength(50)]
        public string City { get; set; }

        [Required]
        [MaxLength(10)]
        public string State { get; set; }

        [Required]
        [MaxLength(50)]
        public string PostalCode { get; set; }

        [Required]
        [MaxLength(50)]
        public string Country { get; set; }
    }
}
