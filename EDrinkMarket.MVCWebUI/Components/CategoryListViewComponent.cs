using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EDrinkMarket.Business.Abstract;
using EDrinkMarket.Entity.Concrete;
using EDrinkMarket.MVCWebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace EDrinkMarket.MVCWebUI.Components
{
    public class CategoryListViewComponent:ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public CategoryListViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public ViewViewComponentResult Invoke()
        {
            var model = new CategoryListViewModel()
            {
                Categories = _categoryService.GetAll()
            };
            return View(model);
        }
    }
}
