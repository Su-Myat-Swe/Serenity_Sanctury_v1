using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Serenity_Sanctury_v1.Models
{
    public class OrderTracking
    {
        [Key]
        public int TrackingID { get; set; }

        [ForeignKey("Order")]
        public int OrderID { get; set; }

        [Required]
        public string OrderEmail { get; set; }

        [Required]
        [MaxLength(10)]
        public string PostalCode { get; set; }

        [Required]
        public string StatusUpdate { get; set; }

        [Required]
        public DateTime UpdateTime { get; set; }

        // Navigation property
        public Order? Order { get; set; }
    }
}
