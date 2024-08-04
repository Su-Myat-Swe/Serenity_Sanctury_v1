using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; //for not mapped
using Microsoft.AspNetCore.Identity;

namespace Serenity_Sanctury_v1.Models
{
    public class User : IdentityUser
    {
        public string? LastName { get; set; }

        public string? FirstName { get; set; }

        [MaxLength(100)]
        public string? FullName { get; set; }

        [MaxLength(15)]
        public string? PhoneNo { get; set; }

        [DataType(DataType.Date)]
        public DateTime? Birthday { get; set; } 

        [MaxLength(10)]
        public string? Gender { get; set; }

        public string? Address { get; set; }

        [NotMapped]
        public IList<string> RoleNames { get; set; } = new List<string>();
    }

}
