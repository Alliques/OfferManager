﻿namespace OfferManager.Application.DTO
{
    public class OfferDto
    {
        public int Id { get; set; }
        public string Brand { get; set; } = null!;
        public string Model { get; set; } = null!;
        public string SupplierName { get; set; } = null!;
        public DateTime RegisteredAt { get; set; }
    }
}
