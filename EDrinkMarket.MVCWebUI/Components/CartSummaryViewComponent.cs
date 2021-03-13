using System.Collections.Generic;
using EDrinkMarket.Business.Abstract;
using EDrinkMarket.Entity.Concrete;
using EDrinkMarket.Entity.DomainModel;
using EDrinkMarket.MVCWebUI.Controllers;
using EDrinkMarket.MVCWebUI.Helper.Abstract;
using EDrinkMarket.MVCWebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace EDrinkMarket.MVCWebUI.Components
{
    public class CartSummaryViewComponent:ViewComponent
    {
        private readonly ICartSessionHelper _cartSessionHelper;

        public CartSummaryViewComponent(ICartSessionHelper cartSessionHelper)
        {
            _cartSessionHelper = cartSessionHelper;
        }


        public ViewViewComponentResult Invoke()
        {
            
            var model=new CartListViewModel()
            {
                Cart = _cartSessionHelper.GetCart(CartController.CartKey)
            };
            return View(model);
        }
    }
}
