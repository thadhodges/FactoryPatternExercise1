using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise1
{
    internal class NoVehicle : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Sorry, your answer did not compute...");
        }
    }
}
