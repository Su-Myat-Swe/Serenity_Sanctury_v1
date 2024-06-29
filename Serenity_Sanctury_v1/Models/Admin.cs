using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Serenity_Sanctury_v1.Models
{
    public class Admin
    {
        [Key]
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string FullName { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        // Navigation property
        public Address? Address { get; set; }
    }
}
