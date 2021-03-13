using System;
using System.Collections.Generic;
using System.Text;
using EDrinkMarket.Entity.Concrete;
using EDrinkMarket.Entity.DomainModel;

namespace EDrinkMarket.Business.Abstract
{
   public interface IOrderService
   {
       void CreateOrder(Order order);
       void TransactionalOperation(Order order, Cart cart);
   }
}
