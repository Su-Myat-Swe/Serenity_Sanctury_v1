using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Serenity_Sanctury_v1.Data.Enum; // Added this to use things in Enum folder

namespace Serenity_Sanctury_v1.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Required]
        public string ProductName { get; set; }

        [Required]
        public Category Category { get; set; }

        public string Description { get; set; }

        [Required]
        public string Color { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")] // Example column type for SQL Server
        public decimal Price { get; set; }

        [Required]
        public int Quantity { get; set; }

        public string ImageUrl { get; set; }
    }
}