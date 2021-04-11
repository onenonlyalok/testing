using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace FactoryDesignPattern
{
    public class ConcreteVehicleFactory : VehicleFactory
    {
        public override IFactory GetVehicle(string Vehicle)
        {
            IFactory definstance = null;
            foreach (var type in typeof(ConcreteVehicleFactory).Assembly.GetTypes())
            {
                //Should be of IFactory type and the vehicle name match with the type name
                if (typeof(IFactory).IsAssignableFrom(type) && !type.IsInterface && type.Name == Vehicle)
                {
                    definstance = (IFactory)Activator.CreateInstance(type);
                    break;   
                }
            }
            return definstance;

            //switch (Vehicle)
            //{
            //    case "Scooter":
            //        return new Scooter();
            //    case "Bike":
            //        return new Bike();
            //    default:
            //        throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", Vehicle));

            //}
        }
    }
}
