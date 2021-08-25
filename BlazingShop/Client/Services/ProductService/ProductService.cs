using BlazingShop.Shared;
using System.Collections.Generic;

namespace BlazingShop.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        public List<Product> Products { get; set; } = new List<Product>();

        public void LoadProduct()
        {
            Products = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    CategoryId = 1,
                    Title = "Lien Quan Mobile - Murad Play Guide",
                    Description = "How to play pro Murad...",
                    Image = "https://lienquan.garena.vn/files/skin/e3db6ff94f1becebd8f742e611ed285f5983e66438880.jpg",
                    Price = 5M,
                    OriginalPrice = 10.0M
                },
                new Product
                {
                    Id = 2,
                    CategoryId = 1,
                    Title = "Lien Quan Mobile - Astrid Play Guide",
                    Description = "How to play pro Astrid...",
                    Image = "https://lienquan.garena.vn/files/skin/15b20fb97ed730bbcffba74eec32be4659e0233890e45.jpg",
                    Price = 6M,
                    OriginalPrice = 10.0M
                },
                new Product
                {
                    Id = 3,
                    CategoryId = 1,
                    Title = "Lien Quan Mobile - Xeniel Play Guide",
                    Description = "How to play pro Xeniel...",
                    Image = "https://lienquan.garena.vn/files/skin/81f4a6d7c3f6bce399233e13f984bfe45a17a07e712b1.jpg",
                    Price = 7M,
                    OriginalPrice = 10.0M
                },
                new Product
                {
                    Id = 4,
                    CategoryId = 1,
                    Title = "Lien Quan Mobile - Thane Play Guide",
                    Description = "How to play pro Thane...",
                    Image = "https://lienquan.garena.vn/files/skin/fd622bcdb9db848f9487f4c599adec97583ff08deb238.jpg",
                    Price = 8M,
                    OriginalPrice = 10.0M
                },
                new Product
                {
                    Id = 5,
                    CategoryId = 1,
                    Title = "Lien Quan Mobile - Nakroth Play Guide",
                    Description = "How to play pro Nakroth...",
                    Image = "https://lienquan.garena.vn/files/skin/50a88477e44151ee8ef4cfb354c22fdc5ec64ff164ffc.jpg",
                    Price = 9M,
                    OriginalPrice = 10.0M
                },
                new Product
                {
                    Id = 6,
                    CategoryId = 1,
                    Title = "Lien Quan Mobile - Mina Play Guide",
                    Description = "How to play pro Mina...",
                    Image = "https://lienquan.garena.vn/files/skin/bb5c20dee5d6cd3a3c849064b9cfef405b345b1ac2e1e.jpg",
                    Price = 10M,
                    OriginalPrice = 10.0M
                },
                new Product
                {
                    Id = 7,
                    CategoryId = 1,
                    Title = "Lien Quan Mobile - Krixi Play Guide",
                    Description = "How to play pro Krixi...",
                    Image = "https://lienquan.garena.vn/files/skin/3fa6fb1c1695570e79df259229e7a6c9583ff18bcefb9.jpg",
                    Price = 11M,
                    OriginalPrice = 10.0M
                },
                new Product
                {
                    Id = 8,
                    CategoryId = 1,
                    Title = "Lien Quan Mobile - Toro Play Guide",
                    Description = "How to play pro Toro...",
                    Image = "https://lienquan.garena.vn/files/skin/b7b9e1d6feade741ed789349815ddabc5ef592310c861.jpg",
                    Price = 12M,
                    OriginalPrice = 10.0M
                },
                new Product
                {
                    Id = 9,
                    CategoryId = 1,
                    Title = "Lien Quan Mobile - TRIỆU VÂN Play Guide",
                    Description = "How to play pro TRIỆU VÂN...",
                    Image = "https://lienquan.garena.vn/files/skin/6ee0ca6c7839effd7b244bbe29f50a9e5d256414a590a.jpg",
                    Price = 13M,
                    OriginalPrice = 10.0M
                },
                new Product
                {
                    Id = 10,
                    CategoryId = 1,
                    Title = "Lien Quan Mobile - Taara Play Guide",
                    Description = "How to play pro Taara...",
                    Image = "https://lienquan.garena.vn/files/skin/f277ef736ed11c5cafa8c9a03624d15d5e4531fb5cc2d.jpg",
                    Price = 9M,
                    OriginalPrice = 10.0M
                },
                new Product
                {
                    Id = 11,
                    CategoryId = 1,
                    Title = "Lien Quan Mobile - Skud Play Guide",
                    Description = "How to play pro Skud...",
                    Image = "https://lienquan.garena.vn/files/skin/33ff4bfdda333cb5b7af2f2cbb4256a95ee5e25898874.jpg",
                    Price = 14M,
                    OriginalPrice = 10.0M
                },
                new Product
                {
                    Id = 12,
                    CategoryId = 1,
                    Title = "Lien Quan Mobile - Arduin Play Guide",
                    Description = "How to play pro Arduin...",
                    Image = "https://lienquan.garena.vn/files/skin/d2fbd3a426cf020c1e2e6ad564e50e8c59bb7ee404746.jpg",
                    Price = 15M,
                    OriginalPrice = 10.0M
                },
                new Product
                {
                    Id = 13,
                    CategoryId = 2,
                    Title = "Lien Minh Huyen Thoai - Ahri Play Guide",
                    Description = "How to play pro Ahri...",
                    Image = "https://cdngarenanow-a.akamaihd.net/webmain/static/pss/lol/items_splash/ahri_2.jpg",
                    Price = 45M,
                    OriginalPrice = 10.0M
                },
                new Product
                {
                    Id = 14,
                    CategoryId = 2,
                    Title = "Lien Minh Huyen Thoai - Caitlyn Play Guide",
                    Description = "How to play pro Caitlyn...",
                    Image = "https://cdngarenanow-a.akamaihd.net/webmain/static/pss/lol/items_splash/caitlyn_11.jpg",
                    Price = 55M,
                    OriginalPrice = 10.0M
                },
                new Product
                {
                    Id = 15,
                    CategoryId = 2,
                    Title = "Lien Minh Huyen Thoai - Fiora Play Guide",
                    Description = "How to play pro Fiora...",
                    Image = "https://cdngarenanow-a.akamaihd.net/webmain/static/pss/lol/items_splash/fiora_4.jpg",
                    Price = 65M,
                    OriginalPrice = 10.0M
                }
            };
        }
    }
}
