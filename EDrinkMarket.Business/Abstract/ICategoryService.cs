using System;
using System.Collections.Generic;
using System.Text;
using EDrinkMarket.Entity.Concrete;

namespace EDrinkMarket.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
