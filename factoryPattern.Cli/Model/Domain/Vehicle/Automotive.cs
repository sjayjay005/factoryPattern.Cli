using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factoryPattern.Cli.Model.Domain.Vehicle
{
    public class Automotive : IVhehicle
    {
        public Automotive(string name) 
        {
            Name = name;
        }
        public string Name { get; set; }

        public VehicleTypes VehicleTypes{ get { return VehicleTypes.Automotive; } }
    }
}
