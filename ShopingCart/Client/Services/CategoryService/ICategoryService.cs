using ShoppingCart.Shared;
namespace ShoppingCart.Client.Services.CategoryService
{
    public interface ICategoryService
    {
        List<Category> Categories { get; set; }
        Task LoadCategories();
    }
}
