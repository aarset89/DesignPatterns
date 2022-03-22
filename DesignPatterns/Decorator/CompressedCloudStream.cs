using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public class CompressedCloudStream : IStream
    {
        private IStream _stream;

        public CompressedCloudStream(IStream stream)
        {
            _stream = stream;
        }
        public void Write(string data)
        {
            var compressedData = CompressData(data);
            _stream.Write(compressedData);
        }

        private string CompressData(string data) => data.Substring(0,5);
    }
}
