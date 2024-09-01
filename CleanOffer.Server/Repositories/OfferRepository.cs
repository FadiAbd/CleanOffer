using CleanOffer.Server.Models;

namespace CleanOffer.Server.Repositories
{
    public class OfferRepository : IOfferRepository
    {
        public decimal CalculateOffer(Offer offer)
        {
            decimal pricePerSquareMeter = offer.City == "Stockholm" ? 65 : 55;
            decimal totalPrice = offer.SquareMeters * pricePerSquareMeter;

            if (offer.WindowCleaning)
                totalPrice += 300;

            if (offer.BalconyCleaning)
                totalPrice += 150;

            if (offer.City == "Uppsala" && offer.TrashRemoval)
                totalPrice += 400;

            return totalPrice;

        }
    }
}
