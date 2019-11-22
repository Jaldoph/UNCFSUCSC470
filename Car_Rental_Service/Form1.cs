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
            if (passwordTextBox.Text == "pass" && userTextBox.Text == "user") //&& adminCheckBox_CheckedChanged.IsChecked)
            {
                employee_Form newForm = new employee_Form();

                //this allows us to hide our forms from one another when one has been accessed.
                this.Hide();
                newForm.ShowDialog();
                this.Show();
                userTextBox.Clear();
                passwordTextBox.Clear();
            }


            if (passwordTextBox.Text == "admin" && userTextBox.Text == "admin")
            {
                admin_Form newForm = new admin_Form();

                //this allows us to hide our forms from one another when one has been accessed.
                this.Hide();
                newForm.ShowDialog();
                this.Show();
                userTextBox.Clear();
                passwordTextBox.Clear();
            }

            else 
            {

                MessageBox.Show("Invalid User Name or Password", "BAD INPUT",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            MessageBox.Show("'pass' for employee, 'admin' for administrator", "Password Help",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("'user' for employee, 'admin' for administrator", "Name Help",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void userTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //private void adminCheckBox_CheckedChanged(object sender, EventArgs e)
        //{



    }//
    }


