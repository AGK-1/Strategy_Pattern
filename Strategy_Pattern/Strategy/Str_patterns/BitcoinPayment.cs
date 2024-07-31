using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Str_patterns
{
    public class BitcoinPayment : IPaymentStrategy, SvoyStrategy
    {
        private string _walletAddress;

        public BitcoinPayment(string walletAddress)
        {
            _walletAddress = walletAddress;
        }

        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paying {amount:C} using Bitcoin.");
        }

        public void Payt(decimal amount)
        {
            Console.WriteLine($"Paying {amount:C} using Bitcoin.");
        }
    }
}
