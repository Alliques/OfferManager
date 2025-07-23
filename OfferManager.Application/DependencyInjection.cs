using Microsoft.Extensions.DependencyInjection;
using OfferManager.Application.Interfaces.Services;
using OfferManager.Application.Interfaces;
using OfferManager.Application.Services;

namespace OfferManager.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IOfferService, OfferService>();
            services.AddScoped<ISupplierService, SupplierService>();
            return services;
        }
    }
}
