using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAbstractionExercise
{
    class Dog : Animal
    {
        public void ProtectsOwner()
        {

        }
        public override void MakeNoise()
        {
            Console.WriteLine("Barks");
        }
    }
}
