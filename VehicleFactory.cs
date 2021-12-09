using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise1
{
    public class VehicleFactory
    {
        
        
        public IVehicle GetVehicle(int numTires)
        {
            
            

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
