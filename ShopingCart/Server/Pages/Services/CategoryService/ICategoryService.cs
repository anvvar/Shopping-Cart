﻿using ShoppingCart.Shared;

namespace ShoppingCart.Server.Pages.Services.CategoryService
{
    public interface ICategoryService
    {
        Task<List<Category>> GetCategories();
        Task<Category> GetCategoryByUrl(string categoryUrl);
    }
}
