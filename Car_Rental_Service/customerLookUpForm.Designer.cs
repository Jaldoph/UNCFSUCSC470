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
    partial class customerLookUpForm : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView2 = new System.Windows.Forms.ListView();
            this.lv2LName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv2FName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustomerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fillList = new System.Windows.Forms.Button();
            this.removeList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lv2LName,
            this.lv2FName,
            this.Address,
            this.CustomerID});
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(12, 28);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(650, 307);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // lv2LName
            // 
            this.lv2LName.Tag = "lvLName";
            this.lv2LName.Text = "Last Name";
            this.lv2LName.Width = 120;
            // 
            // lv2FName
            // 
            this.lv2FName.Tag = "lv2FName";
            this.lv2FName.Text = "First Name";
            this.lv2FName.Width = 120;
            // 
            // Address
            // 
            this.Address.Tag = "Address";
            this.Address.Text = "Address";
            this.Address.Width = 200;
            // 
            // CustomerID
            // 
            this.CustomerID.Tag = "CustomerID";
            this.CustomerID.Text = "CustomerID";
            this.CustomerID.Width = 200;
            // 
            // fillList
            // 
            this.fillList.Location = new System.Drawing.Point(12, 391);
            this.fillList.Name = "fillList";
            this.fillList.Size = new System.Drawing.Size(139, 32);
            this.fillList.TabIndex = 1;
            this.fillList.Tag = "fillList";
            this.fillList.Text = "Show Customers";
            this.fillList.UseVisualStyleBackColor = true;
            this.fillList.Click += new System.EventHandler(this.fillList_Click);
            // 
            // removeList
            // 
            this.removeList.Location = new System.Drawing.Point(523, 391);
            this.removeList.Name = "removeList";
            this.removeList.Size = new System.Drawing.Size(139, 32);
            this.removeList.TabIndex = 2;
            this.removeList.Tag = "RemoveCustomer";
            this.removeList.Text = "Remove Customer";
            this.removeList.UseVisualStyleBackColor = true;
            this.removeList.Click += new System.EventHandler(this.removeCustomer_Click);
            // 
            // customerLookUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 477);
            this.Controls.Add(this.removeList);
            this.Controls.Add(this.fillList);
            this.Controls.Add(this.listView2);
            this.Name = "customerLookUpForm";
            this.Text = "customerLookUpForm";
            this.Load += new System.EventHandler(this.customerLookUpForm_Load_1);
            this.ResumeLayout(false);

        }




        #endregion



        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader lv2FName;
        private System.Windows.Forms.ColumnHeader CustomerID;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader lv2LName;
        private System.Windows.Forms.Button fillList;
        private System.Windows.Forms.Button removeList;
    }
}