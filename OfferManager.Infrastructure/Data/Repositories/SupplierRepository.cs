using Microsoft.EntityFrameworkCore;
using OfferManager.Application.DTO;
using OfferManager.Application.Interfaces;

namespace OfferManager.Infrastructure.Data
{
    public class SupplierRepository : ISupplierRepository
    {
        private readonly AppDbContext _context;
        public SupplierRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<PopularSupplierDto>> GetTopSuppliersAsync(int top)
        {
            return await _context.Suppliers
                .OrderByDescending(s => s.Offers.Count)
                .Take(top)
                .Select(s => new PopularSupplierDto
                {
                    Name = s.Name,
                    OfferCount = s.Offers.Count
                })
                .ToListAsync();
        }
    }
}
