using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleSalonLibrary
{
   public class Bmw: Car
    {
        public bool HasSolarRoof { get; set; }
         

        public Bmw(string model, string manufacturer, int doorNumber, string fuel, double fuelConsumption, int price, bool hasSolarRoof)
            :base(model, manufacturer, doorNumber, fuel, fuelConsumption, price)
        {
            
            this.HasSolarRoof = hasSolarRoof;
        }
            
        public override void Description()
        {
            base.Description();
            Console.WriteLine($"Has solar roof: {this.HasSolarRoof}");
        }

        

    }
}
