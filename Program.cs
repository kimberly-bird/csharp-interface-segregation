using System;
using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
        Boeing boeing = new Boeing();
        Cessna cessna = new Cessna();
        
        // Build a collection of all vehicles that fly
        List<IFlyingVehicle> flyingVehicles = new List<IFlyingVehicle>(){
            boeing,
            cessna
        };

        // With a single `foreach`, have each vehicle Fly()
        flyingVehicles.ForEach(vehicle => vehicle.Fly());


        HouseBoat houseboat = new HouseBoat();
        JetSki jetski = new JetSki();
        // Build a collection of all vehicles that operate on water
        List<ISwimmingVehicle> swimmingVehicles = new List<ISwimmingVehicle>() {
            houseboat,
            jetski
        };

        // With a single `foreach`, have each water vehicle Drive()
        swimmingVehicles.ForEach(vehicle => vehicle.Drive());

        Motorcycle motorcycle = new Motorcycle();
        RAV4 rav4 = new RAV4();
        // Build a collection of all vehicles that operate on roads
        List<IDrivingVehicle> drivingVehicles = new List<IDrivingVehicle>() {
            motorcycle,
            rav4
        };

        // With a single `foreach`, have each road vehicle Drive()
        drivingVehicles.ForEach(vehicle => vehicle.Drive());

        }
    }
}
