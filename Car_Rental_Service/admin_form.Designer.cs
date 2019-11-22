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
    partial class admin_Form
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.reserveLabel = new System.Windows.Forms.Label();
            this.makeReservationButton = new System.Windows.Forms.Button();
            this.cancelReservationButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.vehiclesLabel = new System.Windows.Forms.Label();
            this.checkOutVehicleButton = new System.Windows.Forms.Button();
            this.returnVehicleButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.customerLabel = new System.Windows.Forms.Label();
            this.createNewCustomerButton = new System.Windows.Forms.Button();
            this.customerInformationButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.addVehicles = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.reports = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.reserveLabel);
            this.flowLayoutPanel1.Controls.Add(this.makeReservationButton);
            this.flowLayoutPanel1.Controls.Add(this.cancelReservationButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(32, 72);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(232, 125);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // reserveLabel
            // 
            this.reserveLabel.AutoSize = true;
            this.reserveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserveLabel.Location = new System.Drawing.Point(3, 0);
            this.reserveLabel.Name = "reserveLabel";
            this.reserveLabel.Size = new System.Drawing.Size(105, 20);
            this.reserveLabel.TabIndex = 2;
            this.reserveLabel.Text = "Reservation";
            // 
            // makeReservationButton
            // 
            this.makeReservationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeReservationButton.Location = new System.Drawing.Point(3, 23);
            this.makeReservationButton.Name = "makeReservationButton";
            this.makeReservationButton.Size = new System.Drawing.Size(229, 23);
            this.makeReservationButton.TabIndex = 0;
            this.makeReservationButton.Text = "Make Reservation";
            this.makeReservationButton.UseVisualStyleBackColor = true;
            this.makeReservationButton.Click += new System.EventHandler(this.makeReservationButton_Click);
            // 
            // cancelReservationButton
            // 
            this.cancelReservationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelReservationButton.Location = new System.Drawing.Point(3, 52);
            this.cancelReservationButton.Name = "cancelReservationButton";
            this.cancelReservationButton.Size = new System.Drawing.Size(229, 23);
            this.cancelReservationButton.TabIndex = 1;
            this.cancelReservationButton.Text = "Cancel Reservation";
            this.cancelReservationButton.UseVisualStyleBackColor = true;
            this.cancelReservationButton.Click += new System.EventHandler(this.cancelReservationButton_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.vehiclesLabel);
            this.flowLayoutPanel2.Controls.Add(this.checkOutVehicleButton);
            this.flowLayoutPanel2.Controls.Add(this.returnVehicleButton);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(271, 72);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(234, 125);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // vehiclesLabel
            // 
            this.vehiclesLabel.AutoSize = true;
            this.vehiclesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehiclesLabel.Location = new System.Drawing.Point(3, 0);
            this.vehiclesLabel.Name = "vehiclesLabel";
            this.vehiclesLabel.Size = new System.Drawing.Size(114, 20);
            this.vehiclesLabel.TabIndex = 3;
            this.vehiclesLabel.Text = "Check In/Out";
            // 
            // checkOutVehicleButton
            // 
            this.checkOutVehicleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOutVehicleButton.Location = new System.Drawing.Point(3, 23);
            this.checkOutVehicleButton.Name = "checkOutVehicleButton";
            this.checkOutVehicleButton.Size = new System.Drawing.Size(229, 23);
            this.checkOutVehicleButton.TabIndex = 5;
            this.checkOutVehicleButton.Text = "CheckOut Customer";
            this.checkOutVehicleButton.UseVisualStyleBackColor = true;
            this.checkOutVehicleButton.Click += new System.EventHandler(this.checkOutVehicleButton_Click);
            // 
            // returnVehicleButton
            // 
            this.returnVehicleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnVehicleButton.Location = new System.Drawing.Point(3, 52);
            this.returnVehicleButton.Name = "returnVehicleButton";
            this.returnVehicleButton.Size = new System.Drawing.Size(229, 23);
            this.returnVehicleButton.TabIndex = 4;
            this.returnVehicleButton.Text = "CheckIn Customer";
            this.returnVehicleButton.UseVisualStyleBackColor = true;
            this.returnVehicleButton.Click += new System.EventHandler(this.returnVehicleButton_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.customerLabel);
            this.flowLayoutPanel3.Controls.Add(this.createNewCustomerButton);
            this.flowLayoutPanel3.Controls.Add(this.customerInformationButton);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(32, 205);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(232, 166);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLabel.Location = new System.Drawing.Point(3, 0);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(86, 20);
            this.customerLabel.TabIndex = 4;
            this.customerLabel.Text = "Customer";
            // 
            // createNewCustomerButton
            // 
            this.createNewCustomerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNewCustomerButton.Location = new System.Drawing.Point(3, 23);
            this.createNewCustomerButton.Name = "createNewCustomerButton";
            this.createNewCustomerButton.Size = new System.Drawing.Size(229, 23);
            this.createNewCustomerButton.TabIndex = 5;
            this.createNewCustomerButton.Text = "Create Customer";
            this.createNewCustomerButton.UseVisualStyleBackColor = true;
            this.createNewCustomerButton.Click += new System.EventHandler(this.createNewCustomerButton_Click);
            // 
            // customerInformationButton
            // 
            this.customerInformationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerInformationButton.Location = new System.Drawing.Point(3, 52);
            this.customerInformationButton.Name = "customerInformationButton";
            this.customerInformationButton.Size = new System.Drawing.Size(229, 23);
            this.customerInformationButton.TabIndex = 6;
            this.customerInformationButton.Text = "LookUp Customer";
            this.customerInformationButton.UseVisualStyleBackColor = true;
            this.customerInformationButton.Click += new System.EventHandler(this.customerInformationButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(507, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Admin Portal";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.label2);
            this.flowLayoutPanel4.Controls.Add(this.addVehicles);
            this.flowLayoutPanel4.Controls.Add(this.button3);
            this.flowLayoutPanel4.Controls.Add(this.reports);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(271, 205);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(234, 201);
            this.flowLayoutPanel4.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Admin";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // addVehicles
            // 
            this.addVehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addVehicles.Location = new System.Drawing.Point(3, 23);
            this.addVehicles.Name = "addVehicles";
            this.addVehicles.Size = new System.Drawing.Size(229, 23);
            this.addVehicles.TabIndex = 7;
            this.addVehicles.Text = "Add Vehicles";
            this.addVehicles.UseVisualStyleBackColor = true;
            this.addVehicles.Click += new System.EventHandler(this.addVehicles_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(3, 52);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(229, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Maintain Vehicles";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // reports
            // 
            this.reports.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reports.Location = new System.Drawing.Point(3, 81);
            this.reports.Name = "reports";
            this.reports.Size = new System.Drawing.Size(229, 23);
            this.reports.TabIndex = 8;
            this.reports.Text = "Reports";
            this.reports.UseVisualStyleBackColor = true;
            // 
            // admin_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 450);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "admin_Form";
            this.Text = "Administrator\'s Portal";
            this.Load += new System.EventHandler(this.admin_Form_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label reserveLabel;
        private System.Windows.Forms.Button makeReservationButton;
        private System.Windows.Forms.Button cancelReservationButton;
        private System.Windows.Forms.Label vehiclesLabel;
        private System.Windows.Forms.Button checkOutVehicleButton;
        private System.Windows.Forms.Button returnVehicleButton;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.Button createNewCustomerButton;
        private System.Windows.Forms.Button customerInformationButton;
        private FlowLayoutPanel flowLayoutPanel4;
        private Label label2;
        private Button addVehicles;
        private Button button3;
        private Button reports;
    }
}