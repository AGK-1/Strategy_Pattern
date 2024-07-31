using System;
using Strategy.Str_patterns;

namespace Strategy
{
   public  class Program
    {
        static void Main(string[] args)
        {
            // Create payment strategies
            SvoyStrategy creditCardPayment = new CreditCardPayment("1234-5678-9876-5432", "John Doe", "12/24", "123");
            // IPaymentStrategy creditCardPayment = new CreditCardPayment("1234-5678-9876-5432", "John Doe", "12/24", "123");
            SvoyStrategy payPalPayment = new PayPalPayment("john.doe@example.com", "password123");
            SvoyStrategy bitcoinPayment = new BitcoinPayment("1ABCD1234EFG5678HJKL9");

            // Create context and set strategy to CreditCardPayment
            PaymentContext paymentContext = new PaymentContext(creditCardPayment);
            paymentContext.Payt(100.00m);  // Output: Paying $100.00 using Credit Card.

            // Change strategy to PayPalPayment
            paymentContext.SetPaymentStrategy(payPalPayment);
            paymentContext.Payt(200.00m);  // Output: Paying $200.00 using PayPal.

            // Change strategy to BitcoinPayment
            paymentContext.SetPaymentStrategy(bitcoinPayment);
            paymentContext.Payt(300.00m);  // Output: Paying $300.00 using Bitcoin.

            Console.ReadKey();

        }
   
    }
}
