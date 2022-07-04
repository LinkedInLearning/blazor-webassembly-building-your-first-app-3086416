using MyBlazorShop.Libraries.Services.Storage;
using MyBlazorShop.Libraries.Services.ShoppingCart.Models;
using MyBlazorShop.Libraries.Services.Product.Models;

namespace MyBlazorShop.Libraries.Services.ShoppingCart
{
    /// <summary>
    /// Used for shopping cart methods.
    /// </summary>
    public class ShoppingCartService : IShoppingCartService
    {
        /// <summary>
        /// A private reference to the storage service from the DI container.
        /// </summary>
        private readonly IStorageService _storageService;

        /// <summary>
        /// Constructs a shopping cart service.
        /// </summary>
        /// <param name="storageService">A reference to the storage service from the DI container.</param>
        public ShoppingCartService(IStorageService storageService)
        {
            _storageService = storageService;
        }

        /// <summary>
        /// Gets the shopping cart.
        /// </summary>
        /// <returns>The shopping cart as a <see cref="ShoppingCartModel"/> type.</returns>
        /// <exception cref="Exception">Returns an exception if the shopping cart cannot be found.</exception>
        public ShoppingCartModel Get()
        {
            return _storageService.ShoppingCart;
        }

        /// <summary>
        /// Adds a product to the shopping cart.
        /// </summary>
        /// <param name="product">An instance of the product</param>
        /// <param name="quantity">The quantity they wish to add.</param>
        public void AddProduct(ProductModel product, int quantity)
        {
            // Get all items from shopping cart.
            var items = Get().Items;

            if (HasProduct(product.Sku))
            {
                // Product exists, so find it in the shopping cart.
                var item = items.First(i => i.Product.Sku == product.Sku);

                // Update quantity of the item.
                item.UpdateQuantity(product, quantity);
            }
            else
            {
                // Add the item to the shopping cart.
                items.Add(new ShoppingCartItemModel(product, quantity));
            }
        }

        /// <summary>
        /// Deletes a product from the shopping cart
        /// </summary>
        /// <param name="item">An instance of the shopping cart item</param>
        public void DeleteProduct(ShoppingCartItemModel item)
        {
            // Get all items from the cart.
            var items = Get().Items;

            if (HasProduct(item.Product.Sku))
            {
                // Delete item from shopping cart
                items.Remove(items.First(i => i.Product.Sku == item.Product.Sku));
            }
        }

        /// <summary>
        /// Gets the number of items added to the current shopping cart.
        /// </summary>
        /// <returns>The total number of items.</returns>
        public int Count()
        {
            return Get().Items.Count();
        }

        /// <summary>
        /// Has a product been added to the shopping cart?
        /// </summary>
        /// <param name="sku">The unique identifier of the product.</param>
        /// <returns>A <see cref="bool"/> type which determines whether the product has been added to the shopping cart.</returns>
        public bool HasProduct(string sku)
        {
            var shoppingCart = Get();

            return shoppingCart.Items.Any(i => i.Product.Sku == sku);
        }

    }
}
