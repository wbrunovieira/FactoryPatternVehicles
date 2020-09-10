using System;
namespace FactoryPatternVehicles
{
    public class Motorcycle : IVehicle
    {
        public Motorcycle()
        {
        }

        public void Drive()
        {
            ConsolLogger.VehiculeStartUpDialogue();
            Console.WriteLine("The motorcycle is driving....");
            Console.WriteLine("vrommmmmmm");
        }
    }
}
