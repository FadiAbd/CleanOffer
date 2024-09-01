using CleanOffer.Server.Models;
using CleanOffer.Server.Repositories;

namespace CleanOffer.Server.Services
{
    public class OfferService : IOfferService
    {
        private readonly IOfferRepository _offerRepository;

        public OfferService(IOfferRepository offerRepository)
        {
            _offerRepository = offerRepository;
        }

        public decimal GetOffer(Offer offer)
        {
            return _offerRepository.CalculateOffer(offer);
        }
    }
}
