using CleanOffer.Server.Models;

namespace CleanOffer.Server.Services
{
    public interface IOfferService
    {
        decimal GetOffer(Offer offer);
    }
}
