namespace Raktdaan.Models
{
    public class Payment

    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string DonorId { get; set; }
        public decimal Amount { get; set; } // Ensure this is decimal
        public string Status { get; set; }
    }
}
