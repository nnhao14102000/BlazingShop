using BlazingShop.Server.Services.CategoryService;
using BlazingShop.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingShop.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly ICategoryService _categoryService;

        public ProductService(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<List<Product>> GetAllProducts()
        {
            return Products;
        }

        public async Task<Product> GetProduct(int id)
        {
            Product product = Products.FirstOrDefault(p => p.Id == id);
            return product;
        }

        public async Task<List<Product>> GetProductsByCategory(string categoryUrl)
        {
            Category category = await _categoryService.GetCategoryByUrl(categoryUrl);
            return Products.Where(p => p.CategoryId == category.Id).ToList();
        }

        public List<Product> Products { get; set; } = new List<Product>
        {
            new Product
            {
                Id = 1,
                CategoryId = 1,
                Title = "Lien Quan Mobile - Murad Play Guide",
                Description = "How to play pro Murad...",
                Image = "https://lienquan.garena.vn/files/skin/090d96a5955687155dc3e4c46d0e383f5b86850280f19.jpg",
                Price = 5M,
                OriginalPrice = 10.0M
            },
            new Product
            {
                Id = 2,
                CategoryId = 1,
                Title = "Lien Quan Mobile - Xeniel Play Guide",
                Description = "How to play pro Xeniel...",
                Image = "https://lienquan.garena.vn/files/skin/bd2414ce5bb59066b6815a233837857a5c2c715549ce3.jpg",
                Price = 7M,
                OriginalPrice = 10.0M
            },
            new Product
            {
                Id = 3,
                CategoryId = 1,
                Title = "Lien Quan Mobile - Nakroth Play Guide",
                Description = "How to play pro Nakroth...",
                Image = "https://lienquan.garena.vn/files/skin/b2dbfc69db9688c3295ec4f9880187125f0d1e4e449a7.jpg",
                Price = 9M,
                OriginalPrice = 10.0M
            },
            new Product
            {
                Id = 4,
                CategoryId = 1,
                Title = "Lien Quan Mobile - TRIỆU VÂN Play Guide",
                Description = "How to play pro TRIỆU VÂN...",
                Image = "https://lienquan.garena.vn/files/skin/d7342b00ec05faf09f815c74ce8306eb59d1ad95a449a.jpg",
                Price = 13M,
                OriginalPrice = 10.0M
            },
            new Product
            {
                Id = 5,
                CategoryId = 1,
                Title = "Lien Quan Mobile - Taara Play Guide",
                Description = "How to play pro Taara...",
                Image = "https://lienquan.garena.vn/files/skin/a25530a02bf4bc8f5b230b2a146928ae5ec912acedcc5.png",
                Price = 9M,
                OriginalPrice = 10.0M
            },
            new Product
            {
                Id = 6,
                CategoryId = 2,
                Title = "Lien Minh Huyen Thoai - Ahri Play Guide",
                Description = "How to play pro Ahri...",
                Image = "https://cdngarenanow-a.akamaihd.net/webmain/static/pss/lol/items_splash/ahri_2.jpg",
                Price = 45M,
                OriginalPrice = 10.0M
            },
            new Product
            {
                Id = 7,
                CategoryId = 2,
                Title = "Lien Minh Huyen Thoai - Caitlyn Play Guide",
                Description = "How to play pro Caitlyn...",
                Image = "https://cdngarenanow-a.akamaihd.net/webmain/static/pss/lol/items_splash/caitlyn_11.jpg",
                Price = 55M,
                OriginalPrice = 10.0M
            },
            new Product
            {
                Id = 8,
                CategoryId = 2,
                Title = "Lien Minh Huyen Thoai - Fiora Play Guide",
                Description = "How to play pro Fiora...",
                Image = "https://cdngarenanow-a.akamaihd.net/webmain/static/pss/lol/items_splash/fiora_4.jpg",
                Price = 65M,
                OriginalPrice = 10.0M
            },
            new Product
            {
                Id = 9,
                CategoryId = 2,
                Title = "Lien Minh Huyen Thoai - Irelia Play Guide",
                Description = "How to play pro Irelia...",
                Image = "https://cdngarenanow-a.akamaihd.net/webmain/static/pss/lol/items_splash/irelia_26.jpg",
                Price = 65M,
                OriginalPrice = 10.0M
            },
            new Product
            {
                Id = 10,
                CategoryId = 2,
                Title = "Lien Minh Huyen Thoai - Vi Play Guide",
                Description = "How to play pro Vi...",
                Image = "https://cdngarenanow-a.akamaihd.net/webmain/static/pss/lol/items_splash/vi_5.jpg",
                Price = 65M,
                OriginalPrice = 10.0M
            }
        };
    }
}
