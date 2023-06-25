using ShoppingCart.Shared;
using System.Runtime.InteropServices;

namespace ShoppingCart.Server.Pages.Services.CategoryService
{
    public class CategoryServices : ICategoryService
    {
        public List<Category> Categories { get; set; } = new List<Category>
        {

                new Category{Id=1,Name="Books",Url="Books",Icon="book"},
                new Category{Id=2,Name="Electronics",Url="electronics",Icon="camera-slr"},
                new Category{Id=3,Name="Video Games",Url="video-games",Icon="aperture"}
        };
        public async Task<List<Category>> GetCategories()
        {
            return Categories;
        }

        public async Task<Category> GetCategoryByUrl(string categoryUrl)
        {
            return Categories.FirstOrDefault(c => c.Url.ToLower().Equals(categoryUrl.ToLower()));
        }
    }
}
