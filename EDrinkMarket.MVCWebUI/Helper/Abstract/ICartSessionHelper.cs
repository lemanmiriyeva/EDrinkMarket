using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EDrinkMarket.Entity.DomainModel;

namespace EDrinkMarket.MVCWebUI.Helper.Abstract
{
    public interface ICartSessionHelper
    {
        Cart GetCart(string key);
        void SetCart(string key, Cart cart);
        void Clear();
    }
}
