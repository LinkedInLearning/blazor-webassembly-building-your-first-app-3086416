using MyBlazorShop.Libraries.Services.Product.Models;

namespace MyBlazorShop.Libraries.Services.ShoppingCart.Models
{
    /// <summary>
    /// Stores a shopping cart item.
    /// </summary>
    public class ShoppingCartItemModel
    {
        /// <summary>
        /// Product type.
        /// </summary>
        public ProductModel Product { get; }

        /// <summary>
        /// Price of the product.
        /// </summary>
        public decimal Price { get; protected set; }

        /// <summary>
        /// Quantity of the product.
        /// </summary>
        public int Quantity { get; protected set; }

        /// <summary>
        /// Get the total price of the product.
        /// </summary>
        public decimal TotalPrice
        {
            get
            {
                return Price * Quantity;
            }
        }

        /// <summary>
        /// Constructs a new shopping cart item.
        /// </summary>
        /// <param name="product">Product type.</param>
        /// <param name="quantity">Quantity of the product.</param>
        public ShoppingCartItemModel(ProductModel product, int quantity)
        {
            Product = product;
            Price = product.Price;
            Quantity = quantity;
        }

        /// <summary>
        /// Updates the quantity and the price.
        /// </summary>
        /// <param name="product">Product type.</param>
        /// <param name="quantity">Quantity of the product.</param>
        public void UpdateQuantity(ProductModel product, int quantity)
        {
            Price = product.Price;
            Quantity += quantity;
        }
    }
}
