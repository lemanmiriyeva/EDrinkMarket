using System;
using System.Collections.Generic;
using System.Text;
using EDrinkMarket.Business.Abstract;
using EDrinkMarket.Data.Abstract;
using EDrinkMarket.Entity.Concrete;

namespace EDrinkMarket.Business.Concrete
{
    public class DrinkManager:IDrinkService
    {
        private readonly IDrinkDal _drinkDal;

        public DrinkManager(IDrinkDal drinkDal)
        {
            _drinkDal = drinkDal;
        }

        public List<Drink> GetAll()
        {
            return _drinkDal.GetAll();
        }

        public List<Drink> GetPreferredDrinks()
        {
            return _drinkDal.GetAll(d => d.IsPreferredDrink);
        }

        public List<Drink> GetByCategoryName(string categoryName)
        {
            return _drinkDal.GetAll(d => d.Category.CategoryName == categoryName);
        }

        public Drink GetDrinkById(int drinkId)
        {
            return _drinkDal.Get(d => d.DrinkId == drinkId);
        }
    }
}
