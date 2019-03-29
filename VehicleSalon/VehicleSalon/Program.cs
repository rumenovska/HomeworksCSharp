using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleSalonLibrary;

namespace VehicleSalon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------BMW SALON-----------");

            Bmw b = new Bmw("x5", "BMW", 4, "Diesel", 4.4, 75750, true, VehicleSalonLibrary.Type.Traveling);
            Bmw b1 = new Bmw("x7", "BMW", 4, "Diesel", 7.4, 92600, false, VehicleSalonLibrary.Type.Traveling);
            Bmw b2 = new Bmw("x3", "BMW", 4, "Diesel", 7.5, 41000, true, VehicleSalonLibrary.Type.Traveling);
            Salon bmwSalon = new Salon("Skopje");
            List<Car> bmwCars = new List<Car>() { b, b1, b2 };
            bmwSalon.Cars = bmwCars;
            bmwSalon.PriceRange(50000, 80000);
            

            Console.WriteLine("---------AUDI SALON-----------");

            Audi a = new Audi("A3", "Audi", 4, "Petrol", 4.4, 32500, "Silver", VehicleSalonLibrary.Type.Traveling);
            Audi a1 = new Audi("A6", "Audi", 4, "Diesel", 5.4, 52500, "Black", VehicleSalonLibrary.Type.Traveling);
            Audi a2 = new Audi("A4", "Audi", 4, "Petrol", 7.4, 42500, "Red", VehicleSalonLibrary.Type.Traveling);
            Salon audiSalon = new Salon("UK");
            List<Car> audiCars = new List<Car>() { a, a1, a2 };
            audiSalon.Cars = audiCars;
            audiSalon.PriceRange(30000,45000);

            Console.WriteLine("---------OPEL SALON-----------");

            Opel o = new Opel("Astra", "Opel", 3, "Petrol", 4.4, 25000, "Germany", VehicleSalonLibrary.Type.Traveling);
            Opel o1 = new Opel("Vectra", "Opel", 3, "Petrol", 5.4, 15000, "Germany", VehicleSalonLibrary.Type.Traveling);
            Opel o2 = new Opel("Corsa", "Opel", 3, "Petrol", 6.3, 17800, "Germany", VehicleSalonLibrary.Type.Traveling);
            Salon opelSalon = new Salon("Polska");
            List<Car> opelCars = new List<Car>() { o, o1, o2 };
            opelSalon.Cars = opelCars;
            opelSalon.PriceRange(25000, 45000);
            Console.WriteLine("Min");
            opelSalon.PriceRange(20000);
            
            Console.ReadLine();
        }
    }
}
