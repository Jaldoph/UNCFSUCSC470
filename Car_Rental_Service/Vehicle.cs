using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Car_Rental_Service
{
    public class Vehicle
    {
        public string make;
        public string model;
        public string year;
        public string mileage;
        public bool reserved = false;
        public string type;

        public Vehicle(string make, string model, string year, string mileage, string type)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.mileage = mileage;
            this.reserved = false;
            this.type = type;

        }


            public void set_status()
        {
            if (this.reserved == true)
            {
                this.reserved = false;
            }
            else
            {
                this.reserved = true;
            }
        }
        public static List<Vehicle> loadVehicles ()
        {
            string[] lines = File.ReadAllLines(@"C:\Users\J Aldo\source\Car_Rental_Service\Car_Rental_Service\\vehicles.txt");
            var cars_list = new List<Vehicle>();
            foreach (string line in lines)
            {
                var item = line.Split(',');
                Vehicle tempCar = new Vehicle(item[0], item[1], item[2], item[3], item[4]);
                cars_list.Add(tempCar);
                
            }
            return cars_list;
        }
    }
}
