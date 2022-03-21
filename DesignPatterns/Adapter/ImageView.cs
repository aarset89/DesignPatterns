using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    public class ImageView
    {
        private Image _image;

        public ImageView(Image image)
        {
            _image = image;
        }

        public void Apply(IFilter filter)
        {
            filter.Apply(_image);
        }
    }
}
