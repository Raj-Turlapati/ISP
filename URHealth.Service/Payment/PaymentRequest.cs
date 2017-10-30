namespace URHealth.Service
{
    public class PaymentRequest
    {
        public MealCardType CardType { get; set; }
        public string PaymentTransactionId { get; set; }
        public decimal Amount { get; set; }
    }
}