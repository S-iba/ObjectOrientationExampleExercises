using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsAbstractionExercise
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /* Application.EnableVisualStyles();
             Application.SetCompatibleTextRenderingDefault(false);
             Application.Run(new ShapesForm());*/

            Animal dog = new Dog();
            dog.MakeNoise();

            Dog bob = (Dog)dog;

            bob.ProtectsOwner();
            Animal cat = new Wildcat();
            cat.MakeNoise();

            Animal bird = new Eagle();
            bird.MakeNoise();

            List<Animal> zoo = new List<Animal>();
            zoo.Add(dog);
            zoo.Add(cat);
            zoo.Add(bird);

            foreach (Animal ani in zoo)
            {
                ani.MakeNoise();
            }

            
        }
    }
}
