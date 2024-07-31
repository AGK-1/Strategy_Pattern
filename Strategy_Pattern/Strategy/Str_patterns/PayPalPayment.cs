using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Str_patterns
{
    public class PayPalPayment : IPaymentStrategy, SvoyStrategy
    {
        private string _email;
        private string _password;

        public PayPalPayment(string email, string password)
        {
            _email = email;
            _password = password;
        }

        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paying {amount:C} using PayPal.");
        }

        public void Payt(decimal amount)
        {
            Console.WriteLine($"Paying {amount:C} using PayPal.");
        }
    }
}
