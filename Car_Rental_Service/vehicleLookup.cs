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
    partial class vehicleLookUp : Form
    {
        
        public vehicleLookUp()
        {
            InitializeComponent();
        }

           
        private void removeVehicle_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }



        private void vehicleLookUp_Load(object sender, EventArgs e)
        {
            InitializeComponent();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {


            listView2.Items[0].Selected = true;
            listView2.Select();
            Console.WriteLine("Select");

        }


        private void fillList_Click(object sender, EventArgs e)
        {
            var currentList = Vehicle.loadVehicles();

            Console.WriteLine(currentList.Count);
            Console.WriteLine(currentList[0]);
            Console.WriteLine(currentList[1]);
            Console.WriteLine(currentList[2]);
            Console.WriteLine(currentList[3]); 
            Console.WriteLine(currentList[4]);


            foreach (Vehicle vehicle in currentList)
            {
                System.Windows.Forms.ListViewItem item = new System.Windows.Forms.ListViewItem(vehicle.model);
                item.SubItems.Add(vehicle.make);
                item.SubItems.Add(vehicle.year);
                item.SubItems.Add(vehicle.mileage);
                item.SubItems.Add(vehicle.type);
                item.SubItems.Add(vehicle.reserved.ToString());
                listView2.Items.Add(item);
            }
        }
    }

    }
