using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OfferManager.Domain.Models;

namespace OfferManager.Infrastructure.Data
{
    public class OfferConfiguration : IEntityTypeConfiguration<Offer>
    {
        public void Configure(EntityTypeBuilder<Offer> builder)
        {
            builder.HasKey(o => o.Id);

            builder.Property(o => o.Brand)
                .IsRequired()
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            builder.Property(o => o.Model)
                .IsRequired()
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            builder.HasOne(o => o.Supplier)
                .WithMany(s => s.Offers)
                .HasForeignKey(o => o.SupplierId);

            builder.Property(o => o.RegisteredAt)
                .IsRequired();
            var defaultRegisteredAt = new DateTime(2023, 1, 1, 12, 0, 0, DateTimeKind.Utc);
            builder.HasData(
                new Offer { Id = 1, Brand = "Samsung", Model = "Galaxy S21", SupplierId = 1, RegisteredAt = defaultRegisteredAt },
                new Offer { Id = 2, Brand = "Apple", Model = "iPhone 13", SupplierId = 2, RegisteredAt = defaultRegisteredAt },
                new Offer { Id = 3, Brand = "Xiaomi", Model = "Mi 11", SupplierId = 3, RegisteredAt = defaultRegisteredAt },
                new Offer { Id = 4, Brand = "OnePlus", Model = "9 Pro", SupplierId = 4, RegisteredAt = defaultRegisteredAt },
                new Offer { Id = 5, Brand = "Google", Model = "Pixel 6", SupplierId = 5, RegisteredAt = defaultRegisteredAt },
                new Offer { Id = 6, Brand = "Sony", Model = "Xperia 1", SupplierId = 1, RegisteredAt = defaultRegisteredAt },
                new Offer { Id = 7, Brand = "Huawei", Model = "P50", SupplierId = 2, RegisteredAt = defaultRegisteredAt },
                new Offer { Id = 8, Brand = "Motorola", Model = "Edge", SupplierId = 3, RegisteredAt = defaultRegisteredAt },
                new Offer { Id = 9, Brand = "Nokia", Model = "8.3", SupplierId = 4, RegisteredAt = defaultRegisteredAt },
                new Offer { Id = 10, Brand = "Realme", Model = "GT", SupplierId = 5, RegisteredAt = defaultRegisteredAt },
                new Offer { Id = 11, Brand = "Asus", Model = "ROG Phone 5", SupplierId = 1, RegisteredAt = defaultRegisteredAt },
                new Offer { Id = 12, Brand = "ZTE", Model = "Axon 30", SupplierId = 2, RegisteredAt = defaultRegisteredAt },
                new Offer { Id = 13, Brand = "LG", Model = "Wing", SupplierId = 3, RegisteredAt = defaultRegisteredAt },
                new Offer { Id = 14, Brand = "Vivo", Model = "X60", SupplierId = 4, RegisteredAt = defaultRegisteredAt },
                new Offer { Id = 15, Brand = "Oppo", Model = "Find X3", SupplierId = 5, RegisteredAt = defaultRegisteredAt }
            );
        }
    }
}
