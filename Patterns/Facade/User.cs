using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_2.Patterns.Facade
{
    public class User
    {
        private float cash { get; set; } = 1000;

        public float cashAmount ()
        {
            return cash;
        }
        public void addCash(float amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Negative amount not allowed");
            }
            else
            {
                cash += amount;
            }
        }

        public void removeCash(float amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Negative amount not allowed");
            }
            else
            {
                cash -= amount;
            }
        }
    }
}
