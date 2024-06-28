namespace Serenity_Sanctury_v1.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public string ShippingAddress { get; set; }
        public string OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
        public OrderStatus Status { get; set; }

        // Define the Status enum within the Order class or separately
        public enum OrderStatus
        {
            Pending,
            Shipped,
            Delivered,
            Cancelled
        }
    }
}
