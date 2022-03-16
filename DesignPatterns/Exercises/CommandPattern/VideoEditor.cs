using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DesignPatterns.Exercises.CommandPattern
{
    public class VideoEditor
    {
        private float _contrast = 0.5f;
        private string _text;

        public void SetText(string text) => _text = text;

        public void RemoveText() => _text = string.Empty;

        public float GetContrast() => _contrast;
        public void SetContrast(float contrast) => _contrast = contrast;

        public override string ToString()
        {
            return "VideoEditor{" +
                    "contrast=" + _contrast +
                    ", text='" + _text + '\'' +
                    '}';
        }
    }
}
