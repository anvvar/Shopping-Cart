using ShoppingCart.Shared;

namespace ShoppingCart.Server.Pages.Services.ProductService
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProducts();

        Task<List<Product>> GetProductsCategory(string categoryUrl);

        Task<Product> GetProduct(int Id);


    }
}
