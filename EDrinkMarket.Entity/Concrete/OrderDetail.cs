using System;
using System.Collections.Generic;
using System.Text;
using EDrinkMarket.Entity.Abstract;

namespace EDrinkMarket.Entity.Concrete
{
    public class OrderDetail:IEntity
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int DrinkId { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public virtual Drink Drink { get; set; }
        public virtual Order Order { get; set; }
    }
}
