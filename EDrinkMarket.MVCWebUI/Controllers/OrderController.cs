using Microsoft.AspNetCore.Mvc;
using EDrinkMarket.Business.Abstract;
using EDrinkMarket.Entity.Concrete;
using EDrinkMarket.Entity.DomainModel;
using EDrinkMarket.MVCWebUI.Helper.Abstract;
using Microsoft.AspNetCore.Authorization;

namespace EDrinkMarket.MVCWebUI.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly ICartSessionHelper _cartSessionHelper;
        public OrderController(IOrderService orderService, ICartSessionHelper cartSessionHelper)
        {
            _orderService = orderService;
            _cartSessionHelper = cartSessionHelper;
        }
        [Authorize]
        public IActionResult CheckOut()
        {
            return View();
        }
        [HttpPost]
        [Authorize]
        public IActionResult CheckOut(Order order)
        {
            var cart = _cartSessionHelper.GetCart(CartController.CartKey);
            if (ModelState.IsValid)
            {
                _orderService.TransactionalOperation(order, cart);
                _cartSessionHelper.Clear();
                return RedirectToAction("CheckoutComplete");
            }

            return View(order);
        }

        public IActionResult CheckoutComplete()
        {
            return View();
        }
    }
}
