using factoryPattern.Cli.Model.Domain.Vehicle;
using System;

namespace factoryPattern.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("############ Vehicle Picker ############");

            var car = Factory.Create("OL Yeller", VehicleTypes.Automotive);
            var sailboat = Factory.Create("Misty", VehicleTypes.Boat);
            var plane = Factory.Create("Sasaz", VehicleTypes.Plane);

            Console.WriteLine("{0} is a {1}", car.Name, car.VehicleTypes);
            Console.WriteLine("{0} is a {1}", sailboat.Name, sailboat.VehicleTypes);
            Console.WriteLine("{0} is a {1}", plane.Name, plane.VehicleTypes);

            Console.ReadKey();
        }
    }
}
