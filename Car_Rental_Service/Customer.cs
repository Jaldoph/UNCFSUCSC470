using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Car_Rental_Service
{
    public class Customer
    {
        public string lastName;
        public string firstName;
        public string address;
        public string identificationNumber;
        public string phoneNum;

        public Customer(string lastName,string firstName,string address, string identificationNumberString, string phoneNum)
        {

            this.lastName = lastName;
            this.firstName = firstName;
            this.address = address;
            this.phoneNum = phoneNum;
            this.identificationNumber = identificationNumberString;
        }
        public static List<Customer> loadCustomers()
        {
            string[] lines = File.ReadAllLines(@"C:\Users\J Aldo\source\Car_Rental_Service\Car_Rental_Service\customer.txt");
            var cust_list = new List<Customer>();

            foreach (string line in lines)
            {
                var item = line.Split(',');
                var tempCustomer = new Customer(item[0], item[1], item[2], item[3], item[4]);
                cust_list.Add(tempCustomer);
                //Console.WriteLine(line);
            }
            return cust_list;
            
        }
    }
}
