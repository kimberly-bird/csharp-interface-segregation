using System;

namespace Garage
{
    public class Boeing : IFlyingVehicle
    {
        public int Wheels { get; set; } = 3;
        public int Doors { get; set; } = 3;
        public int PassengerCapacity { get; set; } = 113;
        public bool Winged { get; set; } = true;
        public string TransmissionType { get; set; } = "None";
        public double EngineVolume { get; set; } = 31.1;
        public double MaxLandSpeed { get; set; } = 50;
        public double MaxAirSpeed { get; set; } = 309.0;

        public void Drive()
        {
            Console.WriteLine("The Boeing is ready for takeoff!");
        }

        public void Fly()
        {
            Console.WriteLine("The Boeing effortlessly glides through the clouds like a gleaming god of the Sun");
        }

        public void Start()
        {
            Console.WriteLine("The Boeing engine is running!");
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}