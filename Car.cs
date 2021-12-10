using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise1
{
    public class Car : IVehicle
    {
        public Car()
        {
            Console.WriteLine("You are driving a Car!");
        }

        public void GetVehicle()
        {
            Console.WriteLine("You are driving a Car!");
        }
    }
}
