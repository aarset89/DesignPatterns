using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.Protorype
{
    public interface IComponent
    {
        IComponent Clone();

        void Show();
    }
}
