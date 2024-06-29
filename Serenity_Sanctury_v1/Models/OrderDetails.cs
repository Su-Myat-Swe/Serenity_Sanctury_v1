namespace Serenity_Sanctury_v1.Models
{
    public class OrderDetails
    {
        public int OrderID { get; set; }
        public int Product {  get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; } = decimal.Zero;
    }
}
