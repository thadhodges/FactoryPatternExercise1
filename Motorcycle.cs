using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise1
{
    internal class Motorcycle : IVehicle
    {
        public Motorcycle()
        {
            Console.WriteLine("You are riding on Motorcyle.");
        }
        public void GetVehicle()
        {
            Console.WriteLine("You are riding on Motorcyle.");
        }




    }
}
