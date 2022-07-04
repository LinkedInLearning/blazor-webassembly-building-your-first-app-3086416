using MyBlazorShop.Libraries.Services.Product.Models;

namespace MyBlazorShop.Libraries.Services.Product
{
    /// <summary>
    /// Used for product methods.
    /// </summary>
    public interface IProductService
    {
        /// <summary>
        /// Gets a product.
        /// </summary>
        /// <param name="sku">The unique sku reference.</param>
        /// <returns>A <see cref="ProductModel"/> type.</returns>
        ProductModel? Get(string sku);

        /// <summary>
        /// Get a product by slug.
        /// </summary>
        /// <param name="slug">The slug of the product</param>
        /// <returns></returns>
        ProductModel? GetBySlug(string slug);

        /// <summary>
        /// Gets all products
        /// </summary>
        /// <returns>A <see cref="IList<ProductModel>"/> type.</returns>
        IList<ProductModel> GetAll();
    }
}
