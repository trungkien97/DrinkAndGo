using DrinkAndGo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkAndGo.Data.interfaces
{
    public interface IDrinkRepository
    {
        IEnumerable<Drink> Drinks { get; }
        IEnumerable<Drink> PreferDrinks { get; }
        Drink GetDrink(int drinkId);
    }
}
