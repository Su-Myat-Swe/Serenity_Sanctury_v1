using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Serenity_Sanctury_v1.Models
{
    public class Admin
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string FirstName { get; set; }

        public string FullName { get; set; }

        public string? PhoneNo { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(6)] // Example: Minimum length for password
        public string Password { get; set; }

        // Navigation property
        public Address? Address { get; set; }
    }
}
