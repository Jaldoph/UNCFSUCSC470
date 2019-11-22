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
    public partial class customerLookUpForm : Form
    {
        public customerLookUpForm()
        {
            InitializeComponent();
        }

        private void customerLookUpForm_Load(object sender, EventArgs e)
        {


        }

        private void removeCustomer_Click(object sender, EventArgs e)
        {

            var localCustomerList = Form1.customers;
            int itemChecked = listView2.Items.IndexOf(listView2.SelectedItems[0]);
            MessageBox.Show(" you have chosen to delete item " + itemChecked);

            //now we can go and delete the actual item itself.
            localCustomerList.RemoveAt(itemChecked);
            StreamWriter sw = new StreamWriter(@"C:\Users\J Aldo\source\Car_Rental_Service\Car_Rental_Service\customer.txt");
            string outline;

            foreach (Customer customer in localCustomerList)
            {
                outline = customer.lastName + ',' + customer.firstName + ',' + customer.address + ',' + customer.identificationNumber;
                sw.WriteLine(outline);
            }
            sw.Close();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

            
                listView2.Items[0].Selected = true;
                listView2.Select();
                Console.WriteLine("Select");



        }

        private void fillList_Click(object sender, EventArgs e)
        {
            var currentList = Customer.loadCustomers();

           /* Console.WriteLine(currentList.Count);
            Console.WriteLine(currentList[0]);
            Console.WriteLine(currentList[1]);
            Console.WriteLine(currentList[2]);
            Console.WriteLine(currentList[3]); */
            //Console.WriteLine(currentList[4]);


            foreach (Customer customer in currentList)
            {
                System.Windows.Forms.ListViewItem item = new System.Windows.Forms.ListViewItem(customer.lastName);
                item.SubItems.Add(customer.firstName);
                item.SubItems.Add(customer.address);
                item.SubItems.Add(customer.identificationNumber);
                listView2.Items.Add(item);
            }
        }

        private void customerLookUpForm_Load_1(object sender, EventArgs e)
        {

                

        }
    }
}
