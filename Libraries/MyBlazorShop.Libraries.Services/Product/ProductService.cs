using MyBlazorShop.Libraries.Services.Product.Models;
using MyBlazorShop.Libraries.Services.Storage;

namespace MyBlazorShop.Libraries.Services.Product
{

    /// <summary>
    /// Used for product methods.
    /// </summary>
    public class ProductService : IProductService
    {
        /// <summary>
        /// A private reference to the storage service from the DI container.
        /// </summary>
        private readonly IStorageService _storageService;

        /// <summary>
        /// Constructs a product service.
        /// </summary>
        /// <param name="storageService">A reference to the storage service from the DI container.</param>
        public ProductService(IStorageService storageService)
        {
            _storageService = storageService;
        }

        /// <summary>
        /// Gets a product.
        /// </summary>
        /// <param name="sku">The unique sku reference.</param>
        /// <returns>A <see cref="ProductModel"/> type.</returns>
        public ProductModel? Get(string sku)
        {
            return _storageService.Products.FirstOrDefault(p => p.Sku == sku);
        }

        /// <summary>
        /// Get a product by slug.
        /// </summary>
        /// <param name="slug">The slug of the product</param>
        /// <returns></returns>
        public ProductModel? GetBySlug(string slug)
        {
            return _storageService.Products.FirstOrDefault(p => p.Slug == slug);
        }

        /// <summary>
        /// Gets all products
        /// </summary>
        /// <returns>A <see cref="IList<ProductModel>"/> type.</returns>
        public IList<ProductModel> GetAll()
        {
            return _storageService.Products.ToList();
        }
    }
    
}
