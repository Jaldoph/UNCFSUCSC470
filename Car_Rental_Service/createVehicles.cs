using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_Service
{
    public partial class createVehicles : Form
    {
        public createVehicles()
        {
            InitializeComponent();
        }
        
        private void createVehicleButton_Click(object sender, EventArgs e)
        {

            if (MakeTextBox.Text == null || ModelTextBox.Text == null || yearTextBox.Text == null || mileageTextBox.Text == null || comboBox1.Text == null) MessageBox.Show("Fill in All Values","ERROR") ;

            else
            {


                string Make = MakeTextBox.Text;
                string Model = ModelTextBox.Text;
                string year = yearTextBox.Text;
                string mileage = mileageTextBox.Text;
                string type = comboBox1.Text;
                Vehicle newvehicle = new Vehicle(Model, Make, year, mileage, type);

                Form1.vehicles = Vehicle.loadVehicles();
                var local_vehicles = Form1.vehicles;
                local_vehicles.Add(newvehicle);

                //System.IO.StreamReader file = new System.IO.StreamReader(@"C:\\Users\\J Aldo\\source\\Car_Rental_Service\\Car_Rental_Service\\vehicle.txt");

                StreamWriter sw = new StreamWriter(@"C:\\Users\\J Aldo\\source\\Car_Rental_Service\\Car_Rental_Service\\vehicles.txt");
                string outline;


                ////////////////////// Check /////////////////////////
                foreach (Vehicle vehicle in local_vehicles)
                {
                    bool refer = true;
                    outline = vehicle.make + ", " + vehicle.model + ", " + vehicle.year + ", " + vehicle.mileage + ", " + vehicle.type ;


                    if (refer == true)
                    {
                        sw.WriteLine(outline);
                    }
                    else MessageBox.Show("Invalid, vehicle duplicate");

                }



                sw.Close();
                MessageBox.Show("vehicle Added");
                MakeTextBox.Clear();
                ModelTextBox.Clear();
                yearTextBox.Clear();
                mileageTextBox.Clear();


            }

        }

        private void makeTextBox_TextChanged(object sender, EventArgs e)
        { 
        }

        private void mileageTextBox_TextChanged(object sender, EventArgs e)
        { 
        }

        private void createVehicles_Load(object sender, EventArgs e)
        {

        }

        private void MakeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
