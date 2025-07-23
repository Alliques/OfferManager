namespace OfferManager.Domain.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public ICollection<Offer> Offers { get; set; } = [];
    }
}
