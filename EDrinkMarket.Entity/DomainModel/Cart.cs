using System.Collections.Generic;
using System.Linq;
using EDrinkMarket.Entity.Abstract;
using EDrinkMarket.Entity.Concrete;

namespace EDrinkMarket.Entity.DomainModel
{
    public class Cart:IDomainModel
    {
        public Cart()
        {
            CartItems=new List<CartItem>();
        }
        public List<CartItem> CartItems { get; set; }

        public decimal TotalPrice
        {
            get
            {
                return CartItems.Sum(c => c.Amount * c.Drink.Price);
            }
        }
    }
}
