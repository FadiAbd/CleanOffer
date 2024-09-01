using CleanOffer.Server.Models;
using CleanOffer.Server.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanOffer.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfferController : ControllerBase
    {
        private readonly IOfferService _offerService;

        public OfferController(IOfferService offerService)
        {
            _offerService = offerService;
        }

        [HttpPost]
        public IActionResult Calculate(Offer offer)
        {
            offer.TotalPrice = _offerService.GetOffer(offer);
            return Ok(offer);
        }
    }
}
