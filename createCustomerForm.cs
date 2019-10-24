using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Car_Rental_Service
{
    public partial class createCustomerForm : Form
    {
        public createCustomerForm()
        {
            InitializeComponent();
        }

        private void createCustomerButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string address = addressTextBox.Text;
            string idNumber = idNumberTextBox.Text;
            Customer newCustomer = new Customer(lastName, firstName, address, idNumber);

            Form1.customers = Customer.loadCustomers();
            var local_customers = Form1.customers;
            local_customers.Add(newCustomer);

            StreamWriter sw = new StreamWriter(@"C:\\Users\\Malbosia\\Desktop\\project_files\\customers.txt");
            string outline;

            foreach (Customer customer in local_customers)
            {
                outline = customer.lastName + ',' + customer.firstName + ',' + customer.address + ',' + customer.identificationNumber;
                sw.WriteLine(outline);
            }
            sw.Close();

        }
    }
}
