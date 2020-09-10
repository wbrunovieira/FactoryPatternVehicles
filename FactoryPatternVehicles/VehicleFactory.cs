using System;
namespace FactoryPatternVehicles
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int whellCount)
        {
            switch (whellCount)
            {
                case 2: return new Motorcycle();
                case 3: return new ThreeWheeler();
                case 4: return new Car();
                default: return new Car();
            }

        }
    }
}
