namespace EBizChargeChallenge.Data.Models
{
    public class CreditCard
    {
        public int Id { get; set; }
        public string LastFourDigits { get; set; }
        public string CardType { get; set; }
        public string ImageUrl { get; set; }
        public string Preference { get; set; }
        
    }
}
