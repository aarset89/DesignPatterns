using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.Decorator
{
    public class Editor
    {
        public void OpenProject()
        {
            IStream[] artefacts =
            {
                new Artefact("Main"),
                new Artefact("Demo"),
                new Artefact("EmailClient"),
                new Artefact("EmailProvider"),
            };

            artefacts[0] = new IsMain(artefacts[0]);
            artefacts[2] = new HasError(new IsMain(artefacts[2]));

            foreach (var artefact in artefacts)
                Console.WriteLine(artefact.Render());
        }
    }
}
