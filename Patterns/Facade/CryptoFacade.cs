using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_2.Patterns.Facade
{
    public class CryptoFacade
    {
        public void BuyCrypto(User user, float amount, string currency)
        {
            Crypto crypto = new Crypto();
            float currentRate = crypto.currentCryptoValue(currency);
            float valueInCash = amount * currentRate;
            if (user.cashAmount() > valueInCash)
            {
                crypto.settleConnection();
                Console.WriteLine("Transaction at the rate of " + currentRate + " unit Cash per " + currency + "...");
                if (crypto.BuyCrypto(amount))
                {
                    Console.WriteLine("Previous Amount: " + user.cashAmount());
                    user.removeCash(valueInCash);
                    Console.WriteLine("Transaction successful");
                    Console.WriteLine("Current Amount: " + user.cashAmount());
                }
                else
                {
                    Console.WriteLine("Transaction failed");
                }
            }
            else
            {
                Console.WriteLine("Not enough amount in cash. Required Amount: " + valueInCash);
            }
            crypto.settleConnection();

        }
    }
}
