using System.Collections.Generic;
using EDrinkMarket.Entity.Concrete;

namespace EDrinkMarket.Business.Abstract
{
    public interface IDrinkService
    {
        List<Drink> GetAll();
        List<Drink> GetPreferredDrinks();
        List<Drink> GetByCategoryName(string categoryName);
        Drink GetDrinkById(int drinkId);

    }
}
