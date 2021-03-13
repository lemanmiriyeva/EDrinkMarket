using System;
using System.Collections.Generic;
using System.Text;
using EDrinkMarket.Entity.DomainModel;

namespace EDrinkMarket.Business.Abstract
{
    public interface IOrderDetailService
    {
        void CreateOrderDetails(int orderId,Cart cart);
    }
}
