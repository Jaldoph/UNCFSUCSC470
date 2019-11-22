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
    public partial class admin_Form : Form
    {
        public admin_Form()
        {
            InitializeComponent();
        }

        private void makeReservationButton_Click(object sender, EventArgs e)
        {
            makeReservationForm newForm = new makeReservationForm();
            this.Hide();
            newForm.ShowDialog();
            this.Show();
        }

        private void cancelReservationButton_Click(object sender, EventArgs e)
        {
            var newForm = new cancelReservationForm();
            this.Hide();
            newForm.ShowDialog();
            this.Show();
        }

        private void checkOutVehicleButton_Click(object sender, EventArgs e)
        {

            var newForm = new CheckOut();
            this.Hide();
            newForm.ShowDialog();
            this.Show();


        }

        private void returnVehicleButton_Click(object sender, EventArgs e)
        {



        }

        private void createNewCustomerButton_Click(object sender, EventArgs e)
        {

            var newForm = new createCustomerForm();
            this.Hide();
            newForm.ShowDialog();
            this.Show();

        }

        private void customerInformationButton_Click(object sender, EventArgs e)
        {

            var newForm = new customerLookUpForm();
            this.Hide();
            newForm.ShowDialog();
            this.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {



        }

        private void label2_Click(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void admin_Form_Load(object sender, EventArgs e)
        {



        }

        private void addVehicles_Click(object sender, EventArgs e)
        {
            var disp = new createVehicles();
            this.Hide();
            disp.ShowDialog();
            this.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            var disp = new vehicleLookUp();
            this.Hide();
            disp.ShowDialog();
            this.Show();
        }
    }
}