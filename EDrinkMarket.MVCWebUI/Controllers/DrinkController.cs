using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using EDrinkMarket.Business.Abstract;
using EDrinkMarket.Entity.Concrete;
using EDrinkMarket.MVCWebUI.Models;

namespace EDrinkMarket.MVCWebUI.Controllers
{
    public class DrinkController : Controller
    {
        private readonly IDrinkService _drinkService;

        public DrinkController(IDrinkService drinkService)
        {
            _drinkService = drinkService;
        }

        public IActionResult List()
        {
            var categoryName = Request.Query["categoryName"];
            var currentCategory = string.IsNullOrEmpty(categoryName) ? "All Drinks" : $"{categoryName} drinks";
            var drinks = string.IsNullOrEmpty(categoryName) ? _drinkService.GetAll() : _drinkService.GetByCategoryName(categoryName);
            var model=new DrinkListViewModel()
            {
                Drinks = drinks,
                CurrentCategory = currentCategory
            };
            return View(model);
        }
    }
}
