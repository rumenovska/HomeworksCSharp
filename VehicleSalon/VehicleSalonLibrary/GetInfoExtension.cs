using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleSalonLibrary
{
    public static class GetInfoExtension
    {
        public static void GetInfo (this List<Car> cars)
        {
            foreach(var car in cars)
            {
                car.Description();
            }
        }

    }
}
