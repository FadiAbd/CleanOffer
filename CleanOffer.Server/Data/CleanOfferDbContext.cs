using CleanOffer.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace CleanOffer.Server.Data
{
    public class CleanOfferDbContext : DbContext
    {
        public CleanOfferDbContext(DbContextOptions<CleanOfferDbContext> options) : base(options)
        {
        }

        public DbSet<Offer> Offers { get; set; }
    }
}
