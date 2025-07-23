using OfferManager.Application.DTO;

namespace OfferManager.Application.Interfaces
{
    public interface ISupplierService
    {
        Task<List<PopularSupplierDto>> GetTopSuppliersAsync(int top);
    }
}
