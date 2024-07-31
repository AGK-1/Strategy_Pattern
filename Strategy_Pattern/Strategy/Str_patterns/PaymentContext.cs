
namespace Strategy.Str_patterns
{
    public class PaymentContext
    {
        private SvoyStrategy _paymentStrategy;

        // Constructor
        public PaymentContext(SvoyStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        // Method to set the strategy at runtime
        public void SetPaymentStrategy(SvoyStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        // Method to execute the payment strategy
        public void Payt(decimal amount)
        {
            _paymentStrategy.Payt(amount);
        }
    }
}
