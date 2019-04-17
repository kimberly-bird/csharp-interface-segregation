namespace Garage
{
    public interface ISwimmingVehicle
    {
        int Doors { get; set; }
        int PassengerCapacity { get; set; }
        string TransmissionType { get; set; }
        double EngineVolume { get; set; }
        double MaxWaterSpeed { get; set; }
        void Drive();
        void Start();
        void Stop();
    }

}