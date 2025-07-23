using AutoMapper;
using OfferManager.Application.DTO;
using OfferManager.Application.Interfaces;
using OfferManager.Application.Interfaces.Services;
using OfferManager.Domain.Models;

namespace OfferManager.Application.Services
{
    public class OfferService : IOfferService
    {
        private readonly IOfferRepository _offerRepository;
        private readonly IMapper _mapper;

        public OfferService(IOfferRepository offerRepository, IMapper mapper)
        {
            _offerRepository = offerRepository;
            _mapper = mapper;
        }

        public async Task<OfferDto> CreateAsync(CreateOfferDto dto)
        {
            var offer = _mapper.Map<Offer>(dto);
            offer.RegisteredAt = DateTime.Now;
            var saved = await _offerRepository.AddAsync(offer);

            return _mapper.Map<OfferDto>(saved);
        }

        public async Task<OfferSearchResultDto> SearchAsync(string? query)
        {
            var (offers, totalCount) = await _offerRepository.SearchAsync(query);
            var mappedOffers = _mapper.Map<List<OfferDto>>(offers);

            return new OfferSearchResultDto
            {
                Offers = mappedOffers,
                TotalCount = totalCount
            };
        }
    }
}
