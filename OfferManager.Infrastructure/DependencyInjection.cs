using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OfferManager.Application.Interfaces;
using OfferManager.Infrastructure.Data;

namespace OfferManager.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IOfferRepository, OfferRepository>();
            services.AddScoped<ISupplierRepository, SupplierRepository>();

            return services;
        }
    }
}
