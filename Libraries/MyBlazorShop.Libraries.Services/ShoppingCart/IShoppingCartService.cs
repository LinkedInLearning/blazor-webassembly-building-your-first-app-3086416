using MyBlazorShop.Libraries.Services.ShoppingCart.Models;
using MyBlazorShop.Libraries.Services.Product.Models;

namespace MyBlazorShop.Libraries.Services.ShoppingCart
{
    /// <summary>
    /// Used for shopping cart methods.
    /// </summary>
    public interface IShoppingCartService
    {
        /// <summary>
        /// Gets the shopping cart.
        /// </summary>
        /// <returns>The shopping cart as a <see cref="ShoppingCartModel"/> type.</returns>
        /// <exception cref="Exception">Returns an exception if the shopping cart cannot be found.</exception>
        ShoppingCartModel Get();

        /// <summary>
        /// Adds a product to the current shopping cart.
        /// </summary>
        /// <param name="product">An instance of the product</param>
        /// <param name="quantity">The quantity they wish to add.</param>
        void AddProduct(ProductModel product, int quantity);

        /// <summary>
        /// Deletes a product from the shopping cart
        /// </summary>
        /// <param name="item">An instance of the shopping cart item</param>
        void DeleteProduct(ShoppingCartItemModel item);

        /// <summary>
        /// Gets the number of items added to the current shopping cart.
        /// </summary>
        /// <returns>The total number of items.</returns>
        int Count();

        /// <summary>
        /// Has a product been added to the shopping cart?
        /// </summary>
        /// <param name="sku">The unique identifier of the product.</param>
        /// <returns>A <see cref="bool"/> type which determines whether the product has been added to the shopping cart.</returns>
        bool HasProduct(string sku);
    }
}
