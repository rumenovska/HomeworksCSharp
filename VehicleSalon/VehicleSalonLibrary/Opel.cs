using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleSalonLibrary
{
    public class Opel:Car
    {
        public string CountryOfOrigin { get; set; }
        public Opel(string model, string manufacturer, int doorNumber, string fuel, double fuelConsumption, int price, string countryOfOrigin, Type type)
           : base(model, manufacturer, doorNumber, fuel, fuelConsumption, price, type)
        {

            this.CountryOfOrigin = countryOfOrigin;
        }

        public override void Description()
        {
            base.Description();
            Console.WriteLine($"Country of origin: {this.CountryOfOrigin}");
        }
    }
}
