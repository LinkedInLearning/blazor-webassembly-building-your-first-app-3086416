using MyBlazorShop.Libraries.Services.Product.Models;
using MyBlazorShop.Libraries.Services.ShoppingCart.Models;

namespace MyBlazorShop.Libraries.Services.Storage
{
    /// <summary>
    /// Stores the data used for the application.
    /// </summary>
    public class StorageService : IStorageService
    {
        /// <summary>
        /// Stores a list of products.
        /// </summary>
        public IList<ProductModel> Products { get; private set; }

        /// <summary>
        /// Stores the shopping cart.        
        /// </summary>
        public ShoppingCartModel ShoppingCart { get; private set; }

        /// <summary>
        ///  Constructs a storage service.
        /// </summary>
        public StorageService()
        {
            Products = new List<ProductModel>();
            ShoppingCart = new ShoppingCartModel();

            // Store a list of all the products for the online shop.
            AddProduct(new ProductModel("BUBBLES-GUMBALL-APRON", "A Gumball for Your Thoughts Apron", 24, "bubbles-gumball-apron-black.jpg"));
            AddProduct(new ProductModel("REX-MICROCONTROLLERS-APRON", "Great Microcontrollers Think Alike Apron", 24, "rex-microcontrollers-apron-black.jpg"));
            AddProduct(new ProductModel("DOLORES-COMPUTE-BASEBALLHAT", "I Compute, Therefore I Am Baseball Hat", 29, "dolores-compute-baseballhat-black.jpg"));
            AddProduct(new ProductModel("BUBBLES-GUMBALL-BASEBALLHAT", "A Gumball for Your Thoughts Baseball Hat", 29, "bubbles-gumball-baseballhat-black.jpg"));
            AddProduct(new ProductModel("REX-MICROCONTROLLERS-BASEBALLHAT", "Great Microcontrollers Think Alike Baseball Hat", 29, "rex-microcontrollers-baseballhat-black.jpg"));
            AddProduct(new ProductModel("DOLORES-COMPUTE-MUG", "I Compute, Therefore I Am Mug", 16, "dolores-compute-mug-black.jpg"));
            AddProduct(new ProductModel("DOLORES-COMPUTE-TSHIRT", "I Compute, Therefore I Am T-shirt", 26, "dolores-compute-tshirt-black.jpg"));
            AddProduct(new ProductModel("REX-MICROCONTROLLERS-TSHIRT", "Great Microcontrollers Think Alike T-shirt", 26, "rex-microcontrollers-tshirt-black.jpg"));
        }

        /// <summary>
        /// Adds a product to the storage.
        /// </summary>
        /// <param name="productModel">The <see cref="ProductModel"/> type to be added.</param>
        private void AddProduct(ProductModel productModel)
        {
            if (!Products.Any(p => p.Sku == productModel.Sku))
            {
                Products.Add(productModel);
            }
        }
    }
}
