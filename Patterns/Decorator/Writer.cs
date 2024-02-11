using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_2.Patterns.Decorator
{
    public class Writer: IWriter 
    {
        private string _userName;
        public Writer(string userName) 
        {
            _userName = userName;
        }

        public string GetName()
        {
            return _userName;
        }

        public void Write(string text)
        {
            Console.WriteLine(_userName + " wrote: " + text);
        }
    }
}
