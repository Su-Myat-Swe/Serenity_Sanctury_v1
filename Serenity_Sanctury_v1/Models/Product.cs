namespace Serenity_Sanctury_v1.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; } // Changed from char to string
        public string Description { get; set; }
        public string Color { get; set; } // Changed from int to string
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}