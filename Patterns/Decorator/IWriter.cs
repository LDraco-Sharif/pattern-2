using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_2.Patterns.Decorator
{
    public interface IWriter
    {
        string GetName();
        void Write(string text);
    }
}
