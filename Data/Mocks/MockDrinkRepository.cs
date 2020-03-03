using DrinkAndGo.Data.interfaces;
using DrinkAndGo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkAndGo.Data.Mocks
{
    public class MockDrinkRepository : IDrinkRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();
        public IEnumerable<Drink> Drinks {
            get
            {
                return new List<Drink> {
                    new Drink
                    {
                        Name = "Nuoc cam 1 ne",
                        Price = 1000500,
                        ShortDescription = "Day la nuoc cam 1",
                        LongDescription = "Day la nuoc cam 1 ne ne",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl="https://ttol.vietnamnetjsc.vn//2017/01/24/10/23/ai-hay-uong-nuoc-ep-trai-cay-nhat-dinh-phai-biet-nhung-dieu-nay_2.jpg",
                        ImageThumbImg="https://ttol.vietnamnetjsc.vn//2017/01/24/10/23/ai-hay-uong-nuoc-ep-trai-cay-nhat-dinh-phai-biet-nhung-dieu-nay_2.jpg",
                        InStock= true,
                        IsPreferDrink = true
                    },
                    new Drink
                    {
                        Name = "Nuoc cam 1",
                        Price = 1000500,
                        ShortDescription = "Day la nuoc cam 1",
                        LongDescription = "Day la nuoc cam 1 ne",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl="https://healthplus.vn/Images/Uploaded/Share/2016/10/05/10-loai-nuoc-ep-danh-cho-10-loai-benh1475650432.jpg",
                        ImageThumbImg="https://healthplus.vn/Images/Uploaded/Share/2016/10/05/10-loai-nuoc-ep-danh-cho-10-loai-benh1475650432.jpg",
                        InStock= true,
                        IsPreferDrink = true
                    },
                    new Drink
                    {
                        Name = "Nuoc cam 1",
                        Price = 1000500,
                        ShortDescription = "Day la nuoc cam 1",
                        LongDescription = "Day la nuoc cam 1 ne",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl="https://cdn.tuoitre.vn/thumb_w/640/2018/6/4/nuoctraicay-3-15281023874081056881708.jpg",
                        ImageThumbImg="https://cdn.tuoitre.vn/thumb_w/640/2018/6/4/nuoctraicay-3-15281023874081056881708.jpg",
                        InStock= true,
                        IsPreferDrink = true
                    },
                    new Drink
                    {
                        Name = "Nuoc cam 1",
                        Price = 1000500,
                        ShortDescription = "Day la nuoc cam 1",
                        LongDescription = "Day la nuoc cam 1 ne",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl="https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcS0yqf1JTwkg5XMT-nVvvQWS2QQZlkzzrT5ve4xHjwVLLmTulqK",
                        ImageThumbImg="https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcS0yqf1JTwkg5XMT-nVvvQWS2QQZlkzzrT5ve4xHjwVLLmTulqK",
                        InStock= true,
                        IsPreferDrink = true
                    },
                    new Drink
                    {
                        Name = "Nuoc cam 1",
                        Price = 1000500,
                        ShortDescription = "Day la nuoc cam 1",
                        LongDescription = "Day la nuoc cam 1 ne",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl="https://thietkemenu.vn/wp-content/uploads/2018/08/chup-anh-tra-sua-6.jpg",
                        ImageThumbImg="https://thietkemenu.vn/wp-content/uploads/2018/08/chup-anh-tra-sua-6.jpg",
                        InStock= true,
                        IsPreferDrink = true
                    },
                    new Drink
                    {
                        Name = "Nuoc cam 1",
                        Price = 1000500,
                        ShortDescription = "Day la nuoc cam 1",
                        LongDescription = "Day la nuoc cam 1 ne",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl="https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcR28HxEp_ftN3jvV6J9wNa45bL_PiEARQf2qMALsD36fO41r18C",
                        ImageThumbImg="https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcR28HxEp_ftN3jvV6J9wNa45bL_PiEARQf2qMALsD36fO41r18C",
                        InStock= true,
                        IsPreferDrink = true
                    },
                };
            }
        }
        public IEnumerable<Drink> PreferDrinks { get; }

        public Drink GetDrink(int drinkId)
        {
            throw new NotImplementedException();
        }
    }
}
