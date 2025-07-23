
namespace OfferManager.Application.DTO
{
    public class OfferSearchResultDto
    {
        public List<OfferDto> Offers { get; set; } = [];
        public int TotalCount { get; set; }
    }
}
