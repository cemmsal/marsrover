using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Rover
{
    class Program
    {
        static void Main(string[] args)
        {

            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

            SpaceCar car1 = new SpaceCar(1, 2, new N());
            car1.Move("LMLMLMLMM");
            car1.GetCarLocation();

            Console.WriteLine("***********");

            SpaceCar car2 = new SpaceCar(3, 3, new E());
            car2.Move("MMRMMRMRRM");
            car2.GetCarLocation(); 

            Console.ReadKey();

        }
    }
}
