using Microsoft.EntityFrameworkCore;
using OfferManager.Application.DTO;
using OfferManager.Application.Interfaces;
using OfferManager.Domain.Models;

namespace OfferManager.Infrastructure.Data
{
    public class OfferRepository : IOfferRepository
    {
        private readonly AppDbContext _context;

        public OfferRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Offer> AddAsync(Offer offer)
        {
            _context.Offers.Add(offer);
            await _context.SaveChangesAsync();
            return offer;
        }

        public async Task<(List<Offer> Offers, int TotalCount)> SearchAsync(string? query)
        {
            IQueryable<Offer> queryable = _context.Offers.Include(o => o.Supplier);

            if (!string.IsNullOrWhiteSpace(query))
            {
                queryable = queryable.Where(o =>
                    o.Brand.Contains(query) ||
                    o.Model.Contains(query) ||
                    o.Supplier.Name.Contains(query));
            }

            var offers = await queryable.ToListAsync();
            var totalCount = await queryable.CountAsync();

            return (offers, totalCount);
        }
    }
}
