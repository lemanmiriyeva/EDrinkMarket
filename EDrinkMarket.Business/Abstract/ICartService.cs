using System;
using System.Collections.Generic;
using System.Text;
using EDrinkMarket.Entity.Concrete;
using EDrinkMarket.Entity.DomainModel;

namespace EDrinkMarket.Business.Abstract
{
    public interface ICartService
    {
        List<CartItem> GetAllCartItems(Cart cart);
        void AddToCart(Cart cart, Drink drink, int amount);
        void RemoveFromCart(Cart cart, Drink drink);
      
    }
}
