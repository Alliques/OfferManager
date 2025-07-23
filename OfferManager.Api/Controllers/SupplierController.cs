using Microsoft.AspNetCore.Mvc;
using OfferManager.Application.DTO;
using OfferManager.Application.Interfaces;

namespace OfferManager.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SupplierController : ControllerBase
    {
        private readonly ISupplierService _supplierService;

        public SupplierController(ISupplierService supplierService)
        {
            _supplierService = supplierService;
        }

        [HttpGet]
        public async Task<List<PopularSupplierDto>> SearchAsync(int top)
        {
            return await _supplierService.GetTopSuppliersAsync(top);
        }
    }
}
