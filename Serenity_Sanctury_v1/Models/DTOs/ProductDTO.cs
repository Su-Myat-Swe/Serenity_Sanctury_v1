namespace Serenity_Sanctury_v1.Models.DTOs
{
    public class ProductDTO
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public decimal Price { get; set; }
        

        // default constructor (required for model binding)
        public ProductDTO() { }

        // overloaded constructor accepts a Book object
        public ProductDTO(Product product)
        {
            ProductID = product.ProductID;
            ProductName = product.ProductName;
            Price = product.Price;

        }
    }
}
