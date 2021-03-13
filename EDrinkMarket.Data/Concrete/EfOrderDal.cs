using EDrinkMarket.Data.Abstract;
using EDrinkMarket.Data.Concrete.EntityFramework;
using EDrinkMarket.Data.Concrete.EntityFramework.Contexts;
using EDrinkMarket.Entity.Concrete;

namespace EDrinkMarket.Data.Concrete
{
    public class EfOrderDal: EfEntityRepositoryBase<Order, EDrinkMarketContext>, IOrderDal
    {
        public EfOrderDal(EDrinkMarketContext context):base(context)
        {
            
        }

    }
}
