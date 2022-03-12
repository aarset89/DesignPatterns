using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.Memento
{
    public class DocumentHistory
    {
        public List<DocumentState> States = new List<DocumentState>();

        public void Push(DocumentState state)
        {
            States.Add(state);
        }

        public DocumentState Pop()
        {
            var lastState = States.Last();
            States.Remove(lastState);

            return lastState;
        }

    }
}
