using Microsoft.AspNetCore.Mvc;
using OfferManager.Application.DTO;
using OfferManager.Application.Interfaces.Services;

namespace OfferManager.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OfferController : ControllerBase
    {
        private readonly IOfferService _offerService;

        public OfferController(IOfferService offerService)
        {
            _offerService = offerService;
        }

        [HttpGet]
        public async Task<OfferSearchResultDto> SearchAsync([FromQuery] string? query)
        {
            return await _offerService.SearchAsync(query);
        }

        [HttpPost]
        public async Task<OfferDto> Create(CreateOfferDto offer)
        {
            return await _offerService.CreateAsync(offer);
        }
    }
}
