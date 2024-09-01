namespace CleanOffer.Server.Models
{
    public class Offer
    {
        public int Id { get; set; }
        public string? City { get; set; }
        public int SquareMeters { get; set; }
        public bool WindowCleaning { get; set; }
        public bool BalconyCleaning { get; set; }
        public bool TrashRemoval { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
