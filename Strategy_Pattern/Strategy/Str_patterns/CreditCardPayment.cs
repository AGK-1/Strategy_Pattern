using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Str_patterns
{
    public class CreditCardPayment : IPaymentStrategy, SvoyStrategy
    {
        private string _cardNumber;
        private string _cardHolder;
        private string _expiryDate;
        private string _cvv;

        public CreditCardPayment(string cardNumber, string cardHolder, string expiryDate, string cvv)
        {
            _cardNumber = cardNumber;
            _cardHolder = cardHolder;
            _expiryDate = expiryDate;
            _cvv = cvv;
        }

        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paying {amount:C} using Credit Card.");
        }

        public void Payt(decimal amount)
        {
            Console.WriteLine($"Paying {amount:C} using Credit Card.");
        }
    }
}
