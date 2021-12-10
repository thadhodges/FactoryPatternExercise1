using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise1
{
    public class VehicleFactory
    {
        
        
        public static IVehicle GetVehicle()
        {

            Console.WriteLine("How many tires are on your Vehicle?");
            int numTires = int.Parse(Console.ReadLine());

            switch ( numTires )
            {
                case 2:
                    return new Motorcycle();
                
                case 4:
                    return new Car();
                

                default:
                    return new NoVehicle();
                    
            }



        }



    }
}
