namespace OfferManager.Domain.Models
{
    public class Offer
    {
        public int Id { get; set; }
        public string Brand { get; set; } = null!;
        public string Model { get; set; } = null!;
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; } = null!;
        public DateTime RegisteredAt { get; set; }
    }
}
