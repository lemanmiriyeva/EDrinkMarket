using System;
using System.Collections.Generic;
using System.Text;
using EDrinkMarket.Business.Abstract;
using EDrinkMarket.Data.Abstract;
using EDrinkMarket.Entity.Concrete;

namespace EDrinkMarket.Business.Concrete
{
    
    public class CategoryManager:ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }
    }
}
