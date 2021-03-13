using System;
using System.Collections.Generic;
using System.Text;
using EDrinkMarket.Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EDrinkMarket.Data.Concrete.EntityFramework.Contexts
{
    public class EDrinkMarketContext:IdentityDbContext<IdentityUser>
    {
        public EDrinkMarketContext(DbContextOptions<EDrinkMarketContext> options):base(options)
        {
            
        }

        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order>Orders { get; set; }
        public DbSet<OrderDetail>OrderDetails { get; set; }
    }
}
