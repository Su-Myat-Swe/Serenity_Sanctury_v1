using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Serenity_Sanctury_v1.Data.Enum;  // Added this to use things in Enum folder

namespace Serenity_Sanctury_v1.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [StringLength(100)] // length restriction
        public string ProductName { get; set; }

        public Category Category { get; set; }

        [StringLength(500)] // length restriction
        public string Description { get; set; }

        [StringLength(100)] // length restriction
        public string? Scent { get; set; }

        [StringLength(50)] // length restriction
        public string? BurnTime { get; set; }

        [StringLength(50)] // length restriction
        public string? Size { get; set; }

        [StringLength(100)] // length restriction
        public string Container { get; set; }

        [Column(TypeName = "decimal(18, 2)")] // column type for SQL Server
        public decimal Price { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? DiscountedPrice { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Quantity must be a non-negative number")] //This makes sure that quantity cannot be negative
        public int Quantity { get; set; }

        [Url] //validation for Image
        public string ImageUrl { get; set; }
    }
}
