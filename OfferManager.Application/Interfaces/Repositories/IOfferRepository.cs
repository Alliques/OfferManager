using OfferManager.Application.DTO;
using OfferManager.Domain.Models;

namespace OfferManager.Application.Interfaces
{
    public interface IOfferRepository
    {
        /// <summary>
        /// Добавить новый оффер
        /// </summary>
        Task<Offer> AddAsync(Offer offer);

        /// <summary>
        /// Поиск офферов по строке (марка, модель, поставщик). Возвращает список и общее количество найденных записей
        /// </summary>
        Task<(List<Offer> Offers, int TotalCount)> SearchAsync(string? query);
    }
}
