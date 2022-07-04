using MyBlazorShop.Libraries.Services.Product.Models;
using MyBlazorShop.Libraries.Services.ShoppingCart.Models;

namespace MyBlazorShop.Libraries.Services.Storage
{
    /// <summary>
    /// Stores the data used for the application.
    /// </summary>
    public interface IStorageService
    {
        /// <summary>
        /// Stores a list of products.
        /// </summary>
        IList<ProductModel> Products { get; }

        /// <summary>
        /// Stores the shopping cart.
        /// </summary>
        ShoppingCartModel ShoppingCart { get; }

    }
}
