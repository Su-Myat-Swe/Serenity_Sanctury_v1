using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Serenity_Sanctury_v1.Data.Enum; // Ensure Enum namespace is correctly referenced

namespace Serenity_Sanctury_v1.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }

        public string CustomerID { get; set; }

        public string Address { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalPrice { get; set; }

        [Required]
        public OrderStatus OrderStatus { get; set; }

        // Navigation properties
        public User User { get; set; }
    }
}
