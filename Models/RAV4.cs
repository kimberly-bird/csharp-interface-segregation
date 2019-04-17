using System;

namespace Garage
{
    public class RAV4 : IDrivingVehicle
    {
        public int Wheels { get; set; } = 2;
        public int Doors { get; set; } = 0;
        public int PassengerCapacity { get; set; }
        public string TransmissionType { get; set; } = "Manual";
        public double EngineVolume { get; set; } = 1.3;
        public double MaxLandSpeed { get; set; } = 160.4;
        public double MaxAirSpeed { get; set; }

        public void Drive()
        {
            Console.WriteLine("The RAV4 is driving");
        }

        public void Start()
        {
            Console.WriteLine("The RAV4 engine is running!");
        }

        public void Stop()
        {
            Console.WriteLine("The RAV4 has stopped!");
        }
    }
}