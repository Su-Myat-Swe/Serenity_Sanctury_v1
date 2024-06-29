using System.ComponentModel.DataAnnotations;

namespace Serenity_Sanctury_v1.Models
{
    public class Address
    {
        [Key]
        public int ID { get; set; }
        public string Streetline { get; set; }
        public string UnitNumber { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }

    }
}
