using BlazingShop.Shared;
using System.Collections.Generic;

namespace BlazingShop.Client.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        public List<Category> Categories { get; set; } = new List<Category>();

        public void LoadCategories()
        {
            Categories = new List<Category>
            {
                new Category {
                    Id = 1,
                    Name = "Arena Of Valor",
                    Url = "aov",
                    Icon = "book"
                },
                new Category {
                    Id = 2,
                    Name = "Leagua Of Legends",
                    Url = "lol",
                    Icon = "aperture"
                }
            };
        }
    }
}
