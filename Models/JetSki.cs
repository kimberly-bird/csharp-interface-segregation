using System;

namespace Garage
{
public class JetSki : ISwimmingVehicle
{
    public int Doors { get; set; }
    public int PassengerCapacity { get; set; }
    public string TransmissionType { get; set; }
    public double EngineVolume { get; set; }
    public double MaxWaterSpeed { get; set; }

    public void Start()
    {
        Console.WriteLine("Jetski engine is running!");
    }


    public void Drive()
    {
        Console.WriteLine("Houseboat engine is driving across the waves!");
    }
    
    public void Stop()
    {
        Console.WriteLine("Jetski engine is off!");
    }
}
}