using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EDrinkMarket.Entity.DomainModel;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace EDrinkMarket.MVCWebUI.Extension
{
    public static class SessionExtension
    {
        public static void SetCart(this ISession session,string key,object cart)
        {
            var stringObject = JsonConvert.SerializeObject(cart);
            session.SetString(key,stringObject);
        }

        public static T GetObject<T>(this ISession session, string key) where T : class
        {
            var stringObject = session.GetString(key);
            if (stringObject==null)
            {
                return null;
            }

            var value = JsonConvert.DeserializeObject<T>(stringObject);
            return value;
        }
    }
}
