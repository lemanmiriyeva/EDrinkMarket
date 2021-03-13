using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EDrinkMarket.Business.Abstract;
using EDrinkMarket.MVCWebUI.Models;

namespace EDrinkMarket.MVCWebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDrinkService _drinkService;

        public HomeController(IDrinkService drinkService)
        {
            _drinkService = drinkService;
        }

        public IActionResult Index()
        {
            var preferredDrinks = _drinkService.GetPreferredDrinks();
            var model=new HomeViewModel()
            {
                PreferredDrinks = preferredDrinks
            };
            return View(model);
        }
    }
}
