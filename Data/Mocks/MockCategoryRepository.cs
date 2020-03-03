using DrinkAndGo.Data.interfaces;
using DrinkAndGo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkAndGo.Data.Mocks
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                {
                    new Category
                    {
                        CategoryName = "Nuoc cam",
                        Description = "Day la nuoc cam"
                    },
                    new Category
                    {
                        CategoryName = "Nuoc chanh",
                        Description = "Day la nuoc chanh"
                    },

                };
            }
        }
    }
}
