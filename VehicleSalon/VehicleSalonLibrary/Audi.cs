using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleSalonLibrary
{
    public class Audi:Car
    {
        public string Color { get; set; }
        public Audi(string model, string manufacturer, int doorNumber, string fuel, double fuelConsumption, int price, string color)
           : base(model, manufacturer, doorNumber, fuel, fuelConsumption, price)
        {

            this.Color = color;
        }

        public override void Description()
        {
            base.Description();
            Console.WriteLine($"Color: {this.Color}");
        }
    }
}
