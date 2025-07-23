using OfferManager.Application.DTO;
using OfferManager.Application.Interfaces;

namespace OfferManager.Application.Services
{
    public class SupplierService : ISupplierService
    {
        private readonly ISupplierRepository _supplierRepository;
        public SupplierService(ISupplierRepository supplierRepository)
        {
            _supplierRepository = supplierRepository;   
        }

        public async Task<List<PopularSupplierDto>> GetTopSuppliersAsync(int top)
        {
            return await _supplierRepository.GetTopSuppliersAsync(top);
        }
    }
}
