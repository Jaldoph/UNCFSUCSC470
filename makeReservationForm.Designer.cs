namespace Car_Rental_Service
{
    partial class makeReservationForm
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
            this.viewCarsButton = new System.Windows.Forms.Button();
            this.vehicleListView = new System.Windows.Forms.ListView();
            this.customerListView = new System.Windows.Forms.ListView();
            this.customerListButton = new System.Windows.Forms.Button();
            this.makeCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.modelCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.yearCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mileageCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.firstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dateSelectionButton = new System.Windows.Forms.Button();
            this.reservationLabel = new System.Windows.Forms.Label();
            this.reservationOutputLabel = new System.Windows.Forms.Label();
            this.confirmReservationButton = new System.Windows.Forms.Button();
            this.showReservationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // viewCarsButton
            // 
            this.viewCarsButton.Location = new System.Drawing.Point(30, 359);
            this.viewCarsButton.Name = "viewCarsButton";
            this.viewCarsButton.Size = new System.Drawing.Size(128, 32);
            this.viewCarsButton.TabIndex = 4;
            this.viewCarsButton.Text = "View Cars";
            this.viewCarsButton.UseVisualStyleBackColor = true;
            this.viewCarsButton.Click += new System.EventHandler(this.viewCarsButton_Click);
            // 
            // vehicleListView
            // 
            this.vehicleListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.makeCol,
            this.modelCol,
            this.yearCol,
            this.mileageCol});
            this.vehicleListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleListView.FullRowSelect = true;
            this.vehicleListView.GridLines = true;
            this.vehicleListView.HideSelection = false;
            this.vehicleListView.Location = new System.Drawing.Point(30, 62);
            this.vehicleListView.Name = "vehicleListView";
            this.vehicleListView.Size = new System.Drawing.Size(358, 291);
            this.vehicleListView.TabIndex = 5;
            this.vehicleListView.UseCompatibleStateImageBehavior = false;
            this.vehicleListView.View = System.Windows.Forms.View.Details;
            this.vehicleListView.SelectedIndexChanged += new System.EventHandler(this.vehicleListView_SelectedIndexChanged);
            // 
            // customerListView
            // 
            this.customerListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lastName,
            this.firstName,
            this.address,
            this.idNumber});
            this.customerListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerListView.FullRowSelect = true;
            this.customerListView.GridLines = true;
            this.customerListView.HideSelection = false;
            this.customerListView.Location = new System.Drawing.Point(431, 62);
            this.customerListView.Name = "customerListView";
            this.customerListView.Size = new System.Drawing.Size(358, 291);
            this.customerListView.TabIndex = 6;
            this.customerListView.UseCompatibleStateImageBehavior = false;
            this.customerListView.View = System.Windows.Forms.View.Details;
            // 
            // customerListButton
            // 
            this.customerListButton.Location = new System.Drawing.Point(431, 359);
            this.customerListButton.Name = "customerListButton";
            this.customerListButton.Size = new System.Drawing.Size(120, 32);
            this.customerListButton.TabIndex = 7;
            this.customerListButton.Text = "View Customers";
            this.customerListButton.UseVisualStyleBackColor = true;
            this.customerListButton.Click += new System.EventHandler(this.customerListButton_Click);
            // 
            // makeCol
            // 
            this.makeCol.Text = "Make";
            // 
            // modelCol
            // 
            this.modelCol.Text = "Model";
            // 
            // yearCol
            // 
            this.yearCol.Text = "Year";
            // 
            // mileageCol
            // 
            this.mileageCol.Text = "Mileage";
            // 
            // lastName
            // 
            this.lastName.Text = "Last Name";
            this.lastName.Width = 92;
            // 
            // firstName
            // 
            this.firstName.Text = "First Name";
            this.firstName.Width = 93;
            // 
            // address
            // 
            this.address.Text = "Address";
            // 
            // idNumber
            // 
            this.idNumber.Text = "ID Number";
            this.idNumber.Width = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "CAR LIST";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(434, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "CUSTOMER LIST";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 402);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 10;
            // 
            // dateSelectionButton
            // 
            this.dateSelectionButton.Location = new System.Drawing.Point(129, 576);
            this.dateSelectionButton.Name = "dateSelectionButton";
            this.dateSelectionButton.Size = new System.Drawing.Size(116, 31);
            this.dateSelectionButton.TabIndex = 11;
            this.dateSelectionButton.Text = "Select Dates";
            this.dateSelectionButton.UseVisualStyleBackColor = true;
            // 
            // reservationLabel
            // 
            this.reservationLabel.AutoSize = true;
            this.reservationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationLabel.Location = new System.Drawing.Point(282, 402);
            this.reservationLabel.Name = "reservationLabel";
            this.reservationLabel.Size = new System.Drawing.Size(105, 13);
            this.reservationLabel.TabIndex = 12;
            this.reservationLabel.Text = "Reservation Info:";
            // 
            // reservationOutputLabel
            // 
            this.reservationOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reservationOutputLabel.Location = new System.Drawing.Point(285, 415);
            this.reservationOutputLabel.Name = "reservationOutputLabel";
            this.reservationOutputLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.reservationOutputLabel.Size = new System.Drawing.Size(504, 149);
            this.reservationOutputLabel.TabIndex = 13;
            // 
            // confirmReservationButton
            // 
            this.confirmReservationButton.Location = new System.Drawing.Point(669, 571);
            this.confirmReservationButton.Name = "confirmReservationButton";
            this.confirmReservationButton.Size = new System.Drawing.Size(120, 36);
            this.confirmReservationButton.TabIndex = 14;
            this.confirmReservationButton.Text = "Confirm Reservation";
            this.confirmReservationButton.UseVisualStyleBackColor = true;
            this.confirmReservationButton.Click += new System.EventHandler(this.confirmReservationButton_Click);
            // 
            // showReservationButton
            // 
            this.showReservationButton.Location = new System.Drawing.Point(543, 571);
            this.showReservationButton.Name = "showReservationButton";
            this.showReservationButton.Size = new System.Drawing.Size(120, 36);
            this.showReservationButton.TabIndex = 15;
            this.showReservationButton.Text = "Show Reservation";
            this.showReservationButton.UseVisualStyleBackColor = true;
            this.showReservationButton.Click += new System.EventHandler(this.showReservationButton_Click);
            // 
            // makeReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 632);
            this.Controls.Add(this.showReservationButton);
            this.Controls.Add(this.confirmReservationButton);
            this.Controls.Add(this.reservationOutputLabel);
            this.Controls.Add(this.reservationLabel);
            this.Controls.Add(this.dateSelectionButton);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerListButton);
            this.Controls.Add(this.customerListView);
            this.Controls.Add(this.vehicleListView);
            this.Controls.Add(this.viewCarsButton);
            this.Name = "makeReservationForm";
            this.Text = "Make Reservation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button viewCarsButton;
        private System.Windows.Forms.ListView vehicleListView;
        private System.Windows.Forms.ColumnHeader makeCol;
        private System.Windows.Forms.ColumnHeader modelCol;
        private System.Windows.Forms.ColumnHeader yearCol;
        private System.Windows.Forms.ColumnHeader mileageCol;
        private System.Windows.Forms.ListView customerListView;
        private System.Windows.Forms.Button customerListButton;
        private System.Windows.Forms.ColumnHeader lastName;
        private System.Windows.Forms.ColumnHeader firstName;
        private System.Windows.Forms.ColumnHeader address;
        private System.Windows.Forms.ColumnHeader idNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button dateSelectionButton;
        private System.Windows.Forms.Label reservationLabel;
        private System.Windows.Forms.Label reservationOutputLabel;
        private System.Windows.Forms.Button confirmReservationButton;
        private System.Windows.Forms.Button showReservationButton;
    }
}