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
        public Type Type { get; set; }
        public List<Car> Cars { get; set; }
       
        public Salon(string address, Type type)
        {
            this.Address = address;
            this.Type = type;
            this.Cars = new List<Car> ();
        }
        public void PriceRange(int a, int b)
        {
            try
            {
                foreach (var car in this.Cars)
                {
                    if (car.Price >= a && car.Price <= b)
                    {
                        car.Description();
                    }
                   
                }
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
    }
}
