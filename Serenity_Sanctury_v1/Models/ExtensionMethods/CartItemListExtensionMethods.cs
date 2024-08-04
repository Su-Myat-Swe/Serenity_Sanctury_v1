namespace Serenity_Sanctury_v1.Models.ExtensionMethods
{
    public static class CartItemListExtensions
    {
        public static List<CartItemDTO> ToDTO(this List<CartItem> list) =>
            list.Select(ci => new CartItemDTO
            {
              ProductID = ci.Product.ProductID,
                Quantity = ci.Quantity
            }).ToList();
    }
}
