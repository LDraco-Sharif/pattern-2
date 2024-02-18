using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_2.Patterns.Facade
{
    internal class Crypto
    {
        bool connectionSettled = false;

        public float currentCryptoValue(string currency)
        {
            return new Random().Next(1000, 1200);
        }
        public void settleConnection () {
            connectionSettled = true;
        }

        public bool BuyCrypto(float amount)
        {
            if (connectionSettled)
            {
                return new Random().Next(1, 10) <= 9;
            }
            else
            {
                Console.WriteLine("Connection not settled.");
                return false;
            }
        }
    }
}
