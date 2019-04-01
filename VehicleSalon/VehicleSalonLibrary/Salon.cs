using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleSalonLibrary
{
    public class Salon
    {
        
        public string Address { get; set; }
        public List<Car> Cars { get; set; }
       
        public Salon(string address)
        {
            this.Address = address;
            this.Cars = new List<Car> ();
        }
        public void PriceRange(int from, int to )
        {
            try
            {
                var listRange = this.Cars
                    .Where(x => x.Price >= from && x.Price <= to)
                    .ToList();

                listRange.GetInfo();
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
        }
        public void PriceRange(int minValue)
        {
            var MinList = this.Cars
                .Where(x => x.Price >= minValue)
                .ToList();
            MinList.GetInfo();

        }
        public void PriceRange(float maxValue)
        {
            var maxList = this.Cars
                .Where(x => x.Price <= maxValue)
                .ToList();
            maxList.GetInfo();

        }


    }
}
