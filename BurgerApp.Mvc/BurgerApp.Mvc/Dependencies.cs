using BurgerApp.Data.Models;
using BurgerApp.Data.Repositories;
using BurgerApp.Services.Services;
using BurgerApp.Services.Services.Implementation;

namespace BurgerApp.Mvc
{
    public static class Dependencies
    {
        public static IServiceCollection AddDependencies (this IServiceCollection services)
        {
            services.AddScoped<IRepository<Order>, OrderRepository>();
            services.AddScoped<IRepository<Location>, LocationRepository>();
            services.AddScoped<IRepository<Burger>, BurgerRepository>();
            services.AddScoped<IBurgerServices , BurgerServices>();
            services.AddScoped<IOrderServices, OrderServices>();
            services.AddScoped<ILocationServices, LocationServices>();

            return services;
        }
        
    }
}
