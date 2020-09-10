using System;
using System.Threading;

namespace FactoryPatternVehicles
{
    public class ConsolLogger
    {
        public static void VehiculeStartUpDialogue()
        {
            Console.WriteLine("Put the key in the ignition.");
            Thread.Sleep(1000);
            Console.WriteLine("Turn key!");
            Thread.Sleep(1000);
        }
    }
}
