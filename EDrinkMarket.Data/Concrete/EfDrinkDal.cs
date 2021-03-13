using System;
using System.Collections.Generic;
using System.Text;
using EDrinkMarket.Data.Abstract;
using EDrinkMarket.Data.Concrete.EntityFramework;
using EDrinkMarket.Data.Concrete.EntityFramework.Contexts;
using EDrinkMarket.Entity.Concrete;

namespace EDrinkMarket.Data.Concrete
{
    public class EfDrinkDal:EfEntityRepositoryBase<Drink,EDrinkMarketContext>,IDrinkDal
    {
        public EfDrinkDal(EDrinkMarketContext context):base(context)
        {
            
        } 
    }
}
