using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;

namespace GraphicsAbstractionExercise
{
    internal class Animal
    {
        public virtual void MakeNoise()
        {
            WriteLine("Default animal sound");
        }
    }
}
