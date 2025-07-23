using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OfferManager.Domain.Models;

namespace OfferManager.Infrastructure.Data
{
    public class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.HasKey(s => s.Id);

            builder.Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            builder.Property(s => s.CreatedAt)
                .IsRequired();

            builder.HasData(
                new Supplier { Id = 1, Name = "Supplier A", CreatedAt = DateTime.Parse("2023-01-01T10:00:00Z") },
                new Supplier { Id = 2, Name = "Supplier B", CreatedAt = DateTime.Parse("2023-02-01T10:00:00Z") },
                new Supplier { Id = 3, Name = "Supplier C", CreatedAt = DateTime.Parse("2023-03-01T10:00:00Z") },
                new Supplier { Id = 4, Name = "Supplier D", CreatedAt = DateTime.Parse("2023-04-01T10:00:00Z") },
                new Supplier { Id = 5, Name = "Supplier E", CreatedAt = DateTime.Parse("2023-05-01T10:00:00Z") }
            );
        }
    }
}
