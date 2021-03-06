using System;
using System.Collections.Generic;
using System.Text;
using EDrinkMarket.Data.Abstract;
using EDrinkMarket.Data.Concrete.EntityFramework;
using EDrinkMarket.Data.Concrete.EntityFramework.Contexts;
using EDrinkMarket.Entity.Concrete;

namespace EDrinkMarket.Data.Concrete
{
   public class EfCategoryDal:EfEntityRepositoryBase<Category,EDrinkMarketContext>,ICategoryDal
    {
        public EfCategoryDal(EDrinkMarketContext context) : base(context)
        {
        }
    }
}
