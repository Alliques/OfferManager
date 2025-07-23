using AutoMapper;
using OfferManager.Application.DTO;
using OfferManager.Domain.Models;

namespace OfferManager.Application.Mappings
{
    public class OfferProfile : Profile
    {
        public OfferProfile()
        {
            CreateMap<Offer, OfferDto>()
                .ForMember(dest => dest.SupplierName, opt => opt.MapFrom(src => src.Supplier.Name));

            CreateMap<CreateOfferDto, Offer>();

            CreateMap<(string Name, int OfferCount), PopularSupplierDto>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.OfferCount, opt => opt.MapFrom(src => src.OfferCount));
        }
    }
}
