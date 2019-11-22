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

            if (firstNameTextBox.Text == null || lastNameTextBox.Text == null | addressTextBox.Text == null || idNumberTextBox.Text == null || phoneNumTextBox == null) MessageBox.Show("Fill in All Values", "ERROR");
            else
            {
                
                string firstName = firstNameTextBox.Text;
                string lastName = lastNameTextBox.Text;
                string address = addressTextBox.Text;
                string idNumber = idNumberTextBox.Text;
                string phoneNum = phoneNumTextBox.Text;
                Customer newCustomer = new Customer(lastName, firstName, address, idNumber, phoneNum);

                Form1.customers = Customer.loadCustomers();
                var local_customers = Form1.customers;
                local_customers.Add(newCustomer);

                //System.IO.StreamReader file = new System.IO.StreamReader(@"C:\\Users\\J Aldo\\source\\Car_Rental_Service\\Car_Rental_Service\\customer.txt");

                StreamWriter sw = new StreamWriter(@"C:\\Users\\J Aldo\\source\\Car_Rental_Service\\Car_Rental_Service\\customer.txt");
                string outline;


                ////////////////////// Check /////////////////////////
                foreach (Customer customer in local_customers)
                {
                    bool refer = true;
                    outline = customer.lastName + ", " + customer.firstName + ", " + customer.address + ", " + customer.identificationNumber + ',' + customer.phoneNum;


                    if (refer == true)
                    {
                        sw.WriteLine(outline);
                    }
                    else MessageBox.Show("Invalid, Customer duplicate");

                }

                sw.Close();
                MessageBox.Show("Customer Added");
                firstNameTextBox.Clear();
                lastNameTextBox.Clear();
                addressTextBox.Clear();
                idNumberTextBox.Clear();
                phoneNumTextBox.Clear();
            }

        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void idNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void phoneNumTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
