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
    public partial class Form1 : Form
    {
        public static List<Reservation> reservations = new List<Reservation>();
        public static List<Customer> customers = new List<Customer>();
        public static List<Vehicle> vehicles = new List<Vehicle>();

        public Form1()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "pass" && userTextBox.Text == "pass")
            {
                employee_Form newForm = new employee_Form();
                //this allows us to hide our forms from one another when one has been accessed.
                this.Hide();
                newForm.ShowDialog();
                this.Show();
                userTextBox.Clear();
                passwordTextBox.Clear();
            } 
           
        }
    }  
}
