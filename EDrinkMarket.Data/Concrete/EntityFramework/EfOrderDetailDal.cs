using System;
using System.Collections.Generic;
using System.Text;
using EDrinkMarket.Data.Abstract;
using EDrinkMarket.Data.Concrete.EntityFramework.Contexts;
using EDrinkMarket.Entity.Concrete;

namespace EDrinkMarket.Data.Concrete.EntityFramework
{
   public class EfOrderDetailDal:EfEntityRepositoryBase<OrderDetail,EDrinkMarketContext>,IOrderDetailDal
    {
        public EfOrderDetailDal(EDrinkMarketContext context):base(context)
        {
            
        }
    }
}
