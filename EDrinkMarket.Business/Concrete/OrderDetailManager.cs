using EDrinkMarket.Business.Abstract;
using EDrinkMarket.Data.Abstract;
using EDrinkMarket.Entity.Concrete;
using EDrinkMarket.Entity.DomainModel;

namespace EDrinkMarket.Business.Concrete
{
    public class OrderDetailManager:IOrderDetailService
    {
        private readonly IOrderDetailDal _orderDetailDal;

        public OrderDetailManager(IOrderDetailDal orderDetailDal)
        {
            _orderDetailDal = orderDetailDal;
        }

        public void CreateOrderDetails(int orderId,Cart cart)
        {
            foreach (var cartItem in cart.CartItems)
            {
                var orderDetail=new OrderDetail()
                {
                    DrinkId = cartItem.Drink.DrinkId,
                    Amount = cartItem.Amount,
                    OrderId = orderId,
                    Price = cartItem.Drink.Price

                };
                _orderDetailDal.Add(orderDetail);
            }
        }
    }
}
