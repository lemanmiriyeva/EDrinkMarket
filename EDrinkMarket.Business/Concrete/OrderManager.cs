using System;
using EDrinkMarket.Business.Abstract;
using EDrinkMarket.Business.Utilities;
using EDrinkMarket.Business.ValidationRules.FluentValidation;
using EDrinkMarket.Data.Abstract;
using EDrinkMarket.Entity.Concrete;
using EDrinkMarket.Entity.DomainModel;

namespace EDrinkMarket.Business.Concrete
{
   public class OrderManager:IOrderService
   {
       private readonly IOrderDal _orderDal;
       private readonly IOrderDetailDal _detailDal;
       private readonly IOrderDetailService _orderDetailService;

       public OrderManager(IOrderDal orderDal, IOrderDetailDal detailDal, IOrderDetailService orderDetailService)
       {
           _orderDal = orderDal;
           _detailDal = detailDal;
           _orderDetailService = orderDetailService;
       }

       public void CreateOrder(Order order)
       {
          ValidationTools.FluentValidate(new OrderValidator(), order);
          order.OrderPlaced=DateTime.Now;
          _orderDal.Add(order);
           
       }

       public void TransactionalOperation(Order order,Cart cart)
       {
            CreateOrder(order);
            _orderDetailService.CreateOrderDetails(order.OrderId,cart);
       }

   }
}
