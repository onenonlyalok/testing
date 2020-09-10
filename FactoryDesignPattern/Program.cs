using System;

namespace FactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Changed");
        }

        //static void Main(string[] args)
        //{
        //    VehicleFactory factory = new ConcreteVehicleFactory();

        //    IFactory scooter = factory.GetVehicle("Scooter");
        //    scooter.Drive(10);

        //    IFactory bike = factory.GetVehicle("Bike");
        //    bike.Drive(10);

        //    Console.ReadKey();
        //}
    }
}
