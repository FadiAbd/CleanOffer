using CleanOffer.Server.Models;

namespace CleanOffer.Server.Repositories
{
    public interface IOfferRepository
    {
        Decimal CalculateOffer(Offer offer);
    }
}
