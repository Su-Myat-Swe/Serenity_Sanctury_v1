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

        [ForeignKey("User")]
        public int CustomerID { get; set; }

        [ForeignKey("Address")]
        public int AddressID { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalPrice { get; set; }

        [Required]
        public OrderStatus OrderStatus { get; set; }

        // Navigation properties
        public User? User { get; set; }
        public Address? Address { get; set; }
    }
}
