namespace OfferManager.Application.DTO
{
    public class CreateOfferDto
    {
        public string Brand { get; set; } = null!;
        public string Model { get; set; } = null!;
        public int SupplierId { get; set; }
    }
}
