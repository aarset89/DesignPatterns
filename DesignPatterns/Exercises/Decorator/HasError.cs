using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.Decorator
{
    public class HasError : IStream
    {
        private IStream _stream;

        public HasError(IStream stream)
        {
            _stream = stream;
        }
        public string Render()
        {
            var a = _stream.Render();

            return a + "[Error]";
        }
    }
}
