using OfferManager.Application.DTO;

namespace OfferManager.Application.Interfaces
{
    public interface ISupplierRepository
    {
        /// <summary>
        /// Получить N поставщиков с наибольшим числом офферов
        /// </summary>
        /// <param name="top">Количество записей</param>
        Task<List<PopularSupplierDto>> GetTopSuppliersAsync(int top);
    }
}
