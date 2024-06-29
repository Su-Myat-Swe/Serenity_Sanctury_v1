using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Serenity_Sanctury_v1.Models
{
    public class OrderDetails
    {
        [Key]
        public int OrderDetailsID { get; set; }

        [ForeignKey("Order")]
        public int OrderID { get; set; }

        [ForeignKey("Product")]
        public int ProductID { get; set; }

        [Required]
        public int Quantity { get; set; }

        // Navigation properties
        public Order? Order { get; set; }

        public Product? Product { get; set; }
    }
}
