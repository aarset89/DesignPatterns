using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.Decorator
{
    public class Artefact : IStream
    {
        public string Name { get; set; }
        //public bool HasError { get; set; }
        //public bool IsMain { get; set; }

        public Artefact(string name)
        {
            Name = name;
        }

        public string Render()
        {
            //var errorIcon = HasError ? "[Error]" : string.Empty;
            //var mainIcon = IsMain ? "[Main]" : string.Empty;

            return Name;
        }
    }
}
