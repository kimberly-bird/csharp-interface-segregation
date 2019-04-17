namespace Garage
{
    public interface IDrivingVehicle
    {
        int Wheels { get; set; }
        int Doors { get; set; }
        int PassengerCapacity { get; set; }
        string TransmissionType { get; set; }
        double EngineVolume { get; set; }
        double MaxLandSpeed { get; set; }
        void Start();
        void Stop();
        void Drive();
    }

}