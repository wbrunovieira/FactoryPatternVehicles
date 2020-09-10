using System;
namespace FactoryPatternVehicles
{
    public class ThreeWheeler : IVehicle
    {
        public void Drive()
        {
            ConsolLogger.VehiculeStartUpDialogue();
            Console.WriteLine("The Three Wheeler is driving....");
        }
    }
}
