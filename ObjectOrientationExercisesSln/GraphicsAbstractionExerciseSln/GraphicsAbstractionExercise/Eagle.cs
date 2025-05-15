using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace GraphicsAbstractionExercise
{
    class Eagle : Animal
    {
        public override void MakeNoise()
        {
            WriteLine("Screech");
        }
    }
}
