using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.VisitorPattern
{
    public class WavFile
    {
        private List<Segment> _segments = new List<Segment>();

        public WavFile ReadFile(string name)
        {
            var wavFile = new WavFile();
            wavFile._segments.Add(new FormatSegment());
            wavFile._segments.Add(new FactSegment());
            wavFile._segments.Add(new FactSegment());
            wavFile._segments.Add(new FactSegment());

            return wavFile;

        }

        public void ApplyFilter(IOperation operation)
        {
            foreach (var segment in _segments)
                segment.ApplyFilter(operation);
        }
    }
}
