using System;

namespace factoryPattern.Cli.Model.Domain.Vehicle
{
    public class Factory
    {
        public static IVhehicle Create( string name, VehicleTypes vehicleType) 
        {
            switch (vehicleType) 
            {
                case VehicleTypes.Automotive:
                    //TO DO:
                    return new Automotive(name);
                case VehicleTypes.Plane:
                    //TO DO:
                    return new Plane(name);
                case VehicleTypes.Boat:
                    //TO DO:
                    return new Boat(name);
                default:
                    throw new NotImplementedException("Sorry. This type is not supported");
                        
            }
        }
    }
}
