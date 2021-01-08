using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factoryPattern.Cli.Model.Domain.Vehicle
{
    public interface IVhehicle
    {
        string Name { get; set; }
        VehicleTypes VehicleTypes { get; }
    }
}
