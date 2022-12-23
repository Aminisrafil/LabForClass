using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LabTasksForClass
{
    internal class Car:Vehicle
    {
        public int CurrentFuel;
        public int FuelCapacity;
        public int FuelFor1KM;

        public Car(int currentFuel, int fuelcapacity, int fuelfor1km, string color, string brand, int millage) :base(color,brand,millage)
        {
            CurrentFuel= currentFuel;
            FuelCapacity= fuelcapacity;
            FuelFor1KM= fuelfor1km;
        }

        public void ShowInfo()
        {
             Console.WriteLine($"Brand-{Brand}, Color-{Color},Millage-{Millage},CurrentFuel-{CurrentFuel}" +
                 $"Fuel Capacity-{FuelCapacity}, Fuel For 1 km-{FuelFor1KM}");
        }

        public void Drive(int km)
        {
            if (CurrentFuel/FuelFor1KM>=km)
            {
                Millage += km;
                CurrentFuel -= km * FuelFor1KM;
            }
            else
            {
                Console.WriteLine("Gede bilmezsen imkan catmir.");
            }
        }


    }
}
