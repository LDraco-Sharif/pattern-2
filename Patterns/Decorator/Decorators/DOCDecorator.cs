using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_2.Patterns.Decorator.Decorators
{
    internal class DOCDecorator : BaseDecorator
    {
        private IWriter _wrapped;
        public DOCDecorator(IWriter wrapped) : base(wrapped)
        {
            _wrapped = wrapped;
        }

        override
        public void Write(string text)
        {
            _wrapped.Write(text);
            string userName = GetName();
            Console.WriteLine(userName + " wrote: " + text + " in DOC");
        }
    }
}
