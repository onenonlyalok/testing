using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern
{
    public abstract class VehicleFactory
    {
        public abstract IFactory GetVehicle(string Vehicle);
    }
}