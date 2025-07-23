using Microsoft.EntityFrameworkCore;
using OfferManager.Domain.Models;

namespace OfferManager.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Offer> Offers => Set<Offer>();
        public DbSet<Supplier> Suppliers => Set<Supplier>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
    }
}
