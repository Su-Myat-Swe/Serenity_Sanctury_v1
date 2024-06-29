using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Serenity_Sanctury_v1.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        public string ProductName { get; set; }

        [Required]
        public string Category { get; set; }

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