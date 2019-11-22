using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Car_Rental_Service
{
    public class Reservation
    {
        public string lastName;
        public string firstName;
        public string vehicleInformation;
        public string startDate, endDate;
        public string checkOut;

        public Reservation(string lastName, string firstName, string vehicleInformation, string startDate, string endDate)
        {


            this.lastName = lastName;
            this.firstName = firstName;
            this.vehicleInformation = vehicleInformation;
            this.startDate = startDate;
            this.endDate = endDate;
            this.checkOut = "No";

        }


        public static List<Reservation> loadReservations()
        {
            string[] lines = File.ReadAllLines(@"C:\\Users\\J Aldo\source\\Car_Rental_Service\\Car_Rental_Service\\reservations.txt");
            var reservationList = new List<Reservation>();
            foreach (string line in lines)
            {
                var item = line.Split(',');
                Reservation tempReg = new Reservation(item[0], item[1], item[2], item[3],item[4]);
                reservationList.Add(tempReg);

            }
            Form1.reservations = reservationList;
            return reservationList;
        }
    }
}
