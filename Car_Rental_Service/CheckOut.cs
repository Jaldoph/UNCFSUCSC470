using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_Service
{
    public partial class CheckOut : Form
    {
        public CheckOut()
        {
            InitializeComponent();
        }

        private void showReservationButton_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            //Use member function to load in all the data.
            var currentList = Reservation.loadReservations();
            foreach (Reservation reservation in currentList)
            {
                ListViewItem item = new ListViewItem(reservation.lastName);
                item.SubItems.Add(reservation.firstName);
                item.SubItems.Add(reservation.vehicleInformation);
                item.SubItems.Add(reservation.startDate);
                item.SubItems.Add(reservation.endDate);
                listView2.Items.Add(item);

            }

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void checkOutButton_Click(object Sender, System.EventArgs e)
        {

        }

        private void CheckOut_Load(object sender, EventArgs e)
        {

        }
    }
}
