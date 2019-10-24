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
    public partial class cancelReservationForm : Form
    {
        public cancelReservationForm()
        {
            InitializeComponent();
        }

        private void showReservationButton_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            //Use member function to load in all the data.
            var currentList = Reservation.loadReservations();
            foreach (Reservation reservation in currentList)
            {
                ListViewItem item = new ListViewItem(reservation.lastName);
                item.SubItems.Add(reservation.firstName);
                item.SubItems.Add(reservation.vehicleInformation);
                item.SubItems.Add(reservation.startDate);
                item.SubItems.Add(reservation.endDate);
                listView1.Items.Add(item);

            }

        }

        private void deleteReservationButton_Click(object sender, EventArgs e)
        {
            var localReservationList = Form1.reservations;
            int itemChecked = listView1.Items.IndexOf(listView1.SelectedItems[0]);
            MessageBox.Show(" you have chosen to delete item " + itemChecked);

            //now we can go and delete the actual item itself.
            localReservationList.RemoveAt(itemChecked);
            StreamWriter sw = new StreamWriter(@"C:\\Users\\Malbosia\\Desktop\\project_files\\reservations.txt");
            string outline;

            foreach (Reservation reservation in localReservationList)
            {
                outline = reservation.lastName + ',' + reservation.firstName + ',' + reservation.vehicleInformation + ',' + reservation.startDate + ',' + reservation.endDate;
                sw.WriteLine(outline);
            }
            sw.Close();
        }
    }
}
