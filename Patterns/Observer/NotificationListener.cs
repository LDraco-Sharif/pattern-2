using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_2.Patterns.Observer
{
    public class NotificationListener
    {
        private string _name;
        public NotificationListener(string name)
        {
            _name = name;
        }

        public void notify(string message)
        {
            Console.WriteLine("Hey, " + _name + ", we have news for you.\n" + message);
        }
    }
}
