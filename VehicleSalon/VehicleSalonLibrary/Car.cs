using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleSalonLibrary
{
    public abstract class Car
    {
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public int DoorNumber { get; set; }
        public string Fuel { get; set; }
        public double FuelConsumption { get; set; }
        public int Price { get; set; }


        public Car(string model, string manufacturer, int doorNumber, string fuel, double fuelConsumption, int price)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.DoorNumber = doorNumber;
            this.Fuel = fuel;
            this.FuelConsumption = fuelConsumption;
            this.Price = price;
            
        }
        public virtual void Description()
        {
            Console.WriteLine($"Model: {this.Model}, Manufacturer: {this.Manufacturer}, Number of doors: {this.DoorNumber} ," +
                $"Fuel consumption: {this.FuelConsumption}l /100 km, Price: {this.Price}$");
        }

        
    }
}
