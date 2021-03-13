using EDrinkMarket.Entity.DomainModel;
using EDrinkMarket.MVCWebUI.Extension;
using EDrinkMarket.MVCWebUI.Helper.Abstract;
using Microsoft.AspNetCore.Http;

namespace EDrinkMarket.MVCWebUI.Helper.Concrete
{
    public class CartSessionHelper:ICartSessionHelper
    {
        private IHttpContextAccessor _contextAccessor;

        public CartSessionHelper(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }

        public Cart GetCart(string key)
        {
            var cart = _contextAccessor.HttpContext.Session.GetObject<Cart>(key);
            if (cart==null)
            {
                SetCart(key,new Cart());
                cart = _contextAccessor.HttpContext.Session.GetObject<Cart>(key);
            }
            return cart;
        }

        public void SetCart(string key, Cart cart)
        {
            _contextAccessor.HttpContext.Session.SetCart(key,cart);
        }

        public void Clear()
        {
            _contextAccessor.HttpContext.Session.Clear();
        }
    }
}
