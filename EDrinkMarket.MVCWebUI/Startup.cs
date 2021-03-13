using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using EDrinkMarket.Business.Abstract;
using EDrinkMarket.Business.Concrete;
using EDrinkMarket.Business.ValidationRules.FluentValidation;
using EDrinkMarket.Data.Abstract;
using EDrinkMarket.Data.Concrete;
using EDrinkMarket.Data.Concrete.DbInitializer;
using EDrinkMarket.Data.Concrete.EntityFramework;
using EDrinkMarket.Data.Concrete.EntityFramework.Contexts;
using EDrinkMarket.Entity.Concrete;
using EDrinkMarket.MVCWebUI.Helper.Abstract;
using EDrinkMarket.MVCWebUI.Helper.Concrete;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace EDrinkMarket.MVCWebUI
{
    public class Startup
    {
        private readonly IConfigurationRoot _configurationRoot;
        public Startup(IWebHostEnvironment environment)
        {
            _configurationRoot = new ConfigurationBuilder().SetBasePath(environment.ContentRootPath).
                AddJsonFile("appsettings.json").Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<EDrinkMarketContext>(options=>options.UseSqlServer(_configurationRoot.GetConnectionString("DefaultConnection"),
                b=>b.MigrationsAssembly("EDrinkMarket.MVCWebUI")));
            services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<EDrinkMarketContext>();
            services.AddScoped<IDrinkDal, EfDrinkDal>();
            services.AddScoped<ICategoryDal, EfCategoryDal>();
            services.AddScoped<ICartService, CartManager>();
            services.AddScoped<IDrinkService, DrinkManager>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICartSessionHelper, CartSessionHelper>();
            services.AddScoped<IOrderDal,EfOrderDal>();
            services.AddScoped<IOrderService, OrderManager>();
            services.AddScoped<IOrderDetailDal, EfOrderDetailDal>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSingleton<IValidator<Order>, OrderValidator>();
            services.AddScoped<IOrderDetailService, OrderDetailManager>();
            services.AddSession();
            services.AddControllersWithViews().AddFluentValidation();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,IServiceProvider serviceProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseSession();
            
            app.UseEndpoints(endpoints =>
            {
                 endpoints.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            DbInitializer.Seed(serviceProvider);
        }
    }
}
