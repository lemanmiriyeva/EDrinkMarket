using EDrinkMarket.Entity.Abstract;
using EDrinkMarket.Entity.Concrete;

namespace EDrinkMarket.Entity.DomainModel
{
    public class CartItem:IEntity
    {
        public Drink Drink { get; set; }
        public int Amount { get; set; }
    }
}
