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
        public int identificationNumber;

        public Customer(string lastName,string firstName,string address, string identificationNumberString)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.address = address;
            this.identificationNumber = Int32.Parse(identificationNumberString);
        }
        public static List<Customer> loadCustomers()
        {
            string[] lines = File.ReadAllLines(@"C:\\Users\\Malbosia\\Desktop\\project_files\\customers.txt");
            var cust_list = new List<Customer>();
            foreach (string line in lines)
            {
                var item = line.Split(',');
                var tempCustomer = new Customer(item[0], item[1], item[2], item[3]);
                cust_list.Add(tempCustomer);

            }
            return cust_list;
        }
    }
}
