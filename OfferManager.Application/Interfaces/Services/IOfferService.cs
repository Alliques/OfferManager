using OfferManager.Application.DTO;
using OfferManager.Domain.Models;

namespace OfferManager.Application.Interfaces.Services
{
    public interface IOfferService
    {
        Task<OfferSearchResultDto> SearchAsync(string? query);
        Task<OfferDto> CreateAsync(CreateOfferDto dto);
    }
}
