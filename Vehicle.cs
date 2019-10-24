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
        public int year;
        public int mileage;
        public bool reserved = false;

        public Vehicle(string make, string model, string year, string mileage)
        {
            this.make = make;
            this.model = model;
            this.year = Int32.Parse(year);
            this.mileage = Int32.Parse(mileage);
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
        public static List<Vehicle> CarTest ()
        {
            string[] lines = File.ReadAllLines(@"C:\\Users\\Malbosia\\Desktop\\project_files\\vehicles.txt");
            var cars_list = new List<Vehicle>();
            foreach (string line in lines)
            {
                var item = line.Split(',');
                Vehicle tempCar = new Vehicle(item[0], item[1], item[2], item[3]);
                cars_list.Add(tempCar);
                
            }
            return cars_list;
        }
    }
}
