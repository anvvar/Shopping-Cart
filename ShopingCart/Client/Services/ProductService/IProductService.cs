﻿using ShopingCart.Shared;
namespace ShopingCart.Client.Services.ProductService
{
    public interface IProductService
    {
        event Action OnChange;
        List<Product> Products { get; set; }
        Task LoadProducts(string CategoryUrl = null);

        Task<Product> GetProduct(int id);
    }
}
