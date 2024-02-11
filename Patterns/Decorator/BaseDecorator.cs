using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_2.Patterns.Decorator
{
    public class BaseDecorator : IWriter
    {
        private IWriter _wrapped;
        
        public BaseDecorator(IWriter wrapped)
        {
            _wrapped = wrapped;
        }

        public string GetName()
        {
            return _wrapped.GetName();
        }

        public virtual void Write(string text)
        {
            _wrapped.Write(text);
        }
        
    }
}
