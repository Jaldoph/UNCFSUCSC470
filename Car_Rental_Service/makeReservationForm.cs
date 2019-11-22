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
    public partial class makeReservationForm : Form
    {
        public makeReservationForm()
        {
            InitializeComponent();
        }


        private void viewCarsButton_Click(object sender, EventArgs e)
        {
            var vehicles_object_list = Vehicle.loadVehicles();
            foreach(Vehicle vehicle in vehicles_object_list)
            {
                ListViewItem item = new ListViewItem(vehicle.make);
                item.SubItems.Add(vehicle.model);
                item.SubItems.Add(vehicle.year.ToString());
                item.SubItems.Add(vehicle.mileage.ToString());
                vehicleListView.Items.Add(item);
               
            }
        }

        private void customerListButton_Click(object sender, EventArgs e)
        {
            var customer_object_list = Customer.loadCustomers();
            foreach (Customer customer in customer_object_list)
            {
                ListViewItem item = new ListViewItem(customer.lastName);
                item.SubItems.Add(customer.firstName);
                item.SubItems.Add(customer.address);
                item.SubItems.Add(customer.identificationNumber);
                customerListView.Items.Add(item);

            }
        }

        private void showReservationButton_Click(object sender, EventArgs e)
        {
            var startDate = monthCalendar1.SelectionRange.Start.ToShortDateString();
            var endDate = monthCalendar1.SelectionRange.End.ToShortDateString();
            var carMake = vehicleListView.SelectedItems[0].SubItems[0].Text;
            var carModel = vehicleListView.SelectedItems[0].SubItems[1].Text;
            var carYear = vehicleListView.SelectedItems[0].SubItems[2].Text;
            var carMileage = vehicleListView.SelectedItems[0].SubItems[3].Text;

            var lastName = customerListView.SelectedItems[0].Text;
            var firstName = customerListView.SelectedItems[0].SubItems[1].Text;
            var dates = "Dates Selected From : " + startDate + " to " + endDate;
            var carInformation = "Make: " + carMake + '\n' + "Car Model: " + carModel + '\n' + "Year: " + carYear + '\n' + "Car Mileage: " + carMileage;
            var customerInformation = "Customer Name: " + firstName + ' ' + lastName;
            reservationOutputLabel.Text = dates +'\n'+ carInformation + '\n' + customerInformation;



        }

        private void confirmReservationButton_Click(object sender, EventArgs e)
        {
            var startDate = monthCalendar1.SelectionRange.Start.ToShortDateString();
            var endDate = monthCalendar1.SelectionRange.End.ToShortDateString();
            string carMake = vehicleListView.SelectedItems[0].Text;
            var carModel = vehicleListView.SelectedItems[0].SubItems[1].Text;
            var carYear = vehicleListView.SelectedItems[0].SubItems[2].Text;
            var carMileage = vehicleListView.SelectedItems[0].SubItems[3].Text;

            var lastName = customerListView.SelectedItems[0].Text;
            var firstName = customerListView.SelectedItems[0].SubItems[1].Text;
            var dates = "Dates Selected From : " + startDate + " to " + endDate;
            var carInformation = "Make: " + carMake + '\n' + "Car Model: " + carModel + '\n' + "Year: " + carYear + '\n' + "Car Mileage: " + carMileage;
            var customerInformation = "Customer Name: " + firstName + ' ' + lastName;
            var present_text = dates + '\n' + carInformation + '\n' + customerInformation;
            MessageBox.Show(present_text);
            Reservation current = new Reservation(lastName, firstName, (carMake + ' ' + carModel + ' ' + carYear),startDate,endDate);
            var reservationsLocal = Reservation.loadReservations();
            reservationsLocal.Add(current);
            Form1.reservations = reservationsLocal;

            //open file for writing
            StreamWriter sw = new StreamWriter(@"C:\\Users\\J Aldo\\source\\Car_Rental_Service\\Car_Rental_Service\\reservations.txt");
            string outline;

            foreach (Reservation reservation in reservationsLocal)
            {
                outline = reservation.lastName + ',' + reservation.firstName + ',' + reservation.vehicleInformation + ',' + reservation.startDate + ',' + reservation.endDate;
                sw.WriteLine(outline);
            }
            sw.Close();
            MessageBox.Show("Reservation Added","Good");
        }

        private void vehicleListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
