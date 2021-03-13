using System.Collections.Generic;
using System.Linq;
using EDrinkMarket.Business.Abstract;
using EDrinkMarket.Entity.Concrete;
using EDrinkMarket.Entity.DomainModel;

namespace EDrinkMarket.Business.Concrete
{
    public class CartManager:ICartService
    {
        public List<CartItem> GetAllCartItems(Cart cart)
        {
            return cart.CartItems;
        }

        public void AddToCart(Cart cart, Drink drink, int amount)
        {
            var cartItem = cart.CartItems.FirstOrDefault(c => c.Drink.DrinkId == drink.DrinkId);
            if (cartItem!=null)
            {
                cartItem.Amount += amount;
            }
            else
            {
                 cartItem=new CartItem(){Drink = drink,Amount = amount};
                 cart.CartItems.Add(cartItem);
            }
        }

        public void RemoveFromCart(Cart cart, Drink drink)
        {
            var cartItem = cart.CartItems.FirstOrDefault(c => c.Drink.DrinkId == drink.DrinkId);
            if (cartItem==null) return;
            if (cartItem.Amount > 1)
            {
                cartItem.Amount--;
            }
            else
            {
                cart.CartItems.Remove(cartItem);
            }
        }
    }
}
