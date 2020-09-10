using System;
namespace FactoryPatternVehicles
{
    public class Car : IVehicle
    {
        public void Drive()
        {
            ConsolLogger.VehiculeStartUpDialogue();
            Console.WriteLine("The car is driving....");
        }
    }
}
