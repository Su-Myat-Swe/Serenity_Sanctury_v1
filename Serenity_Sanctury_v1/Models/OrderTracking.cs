namespace Serenity_Sanctury_v1.Models
{
    public class OrderTracking
    {
        public int TrackingID { get; set; }
        public int OrderID { get; set; }
        public string OrderEmail { get; set; }
        public string PostalCode { get; set; }
        public string StatusUpdate { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
