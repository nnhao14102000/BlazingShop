using BlazingShop.Shared;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingShop.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        public List<Category> Categories { get; set; } = new List<Category>
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
