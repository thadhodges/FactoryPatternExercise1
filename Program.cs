// See https://aka.ms/new-console-template for more information



Console.WriteLine("How many Tires does your Vehicle have???");
int userTires = int.Parse(Console.ReadLine());




IVehicle tires = VehicleFactory.GetVehicle();