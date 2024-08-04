using System.Text.Json.Serialization;

namespace Serenity_Sanctury_v1.Models
{
    public class CartItem
    {
        public Product Product { get; set; } = new Product();
        public int Quantity { get; set; }

        [JsonIgnore]
        public decimal Subtotal => Product.Price * Quantity;
    }
}
