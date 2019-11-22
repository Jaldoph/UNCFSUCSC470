namespace Car_Rental_Service
{
    partial class CheckOut
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
            this.nameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.firstNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vehicleInfoCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.startCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.endColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.showReservationButton = new System.Windows.Forms.Button();
            this.deleteReservationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameCol,
            this.firstNameColumn,
            this.vehicleInfoCol,
            this.startCol,
            this.endColumn});
            this.listView2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(30, 23);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(805, 347);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // nameCol
            // 
            this.nameCol.Text = "Last Name";
            this.nameCol.Width = 120;
            // 
            // firstNameColumn
            // 
            this.firstNameColumn.Text = "First Name";
            this.firstNameColumn.Width = 117;
            // 
            // vehicleInfoCol
            // 
            this.vehicleInfoCol.Text = "Vehicle Info.";
            this.vehicleInfoCol.Width = 200;
            // 
            // startCol
            // 
            this.startCol.Text = "Start Date";
            this.startCol.Width = 135;
            // 
            // endColumn
            // 
            this.endColumn.Text = "End Date";
            this.endColumn.Width = 192;
            // 
            // showReservationButton
            // 
            this.showReservationButton.Location = new System.Drawing.Point(30, 387);
            this.showReservationButton.Name = "showReservationButton";
            this.showReservationButton.Size = new System.Drawing.Size(125, 37);
            this.showReservationButton.TabIndex = 1;
            this.showReservationButton.Text = "Show Reservations";
            this.showReservationButton.UseVisualStyleBackColor = true;
            this.showReservationButton.Click += new System.EventHandler(this.showReservationButton_Click);
            // 
            // deleteReservationButton
            // 
            this.deleteReservationButton.Location = new System.Drawing.Point(710, 387);
            this.deleteReservationButton.Name = "deleteReservationButton";
            this.deleteReservationButton.Size = new System.Drawing.Size(125, 37);
            this.deleteReservationButton.TabIndex = 2;
            this.deleteReservationButton.Text = "Delete Reservation";
            this.deleteReservationButton.UseVisualStyleBackColor = true;
            this.deleteReservationButton.Click += new System.EventHandler(this.checkOutButton_Click);
            // 
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView2);
            this.Name = "CheckOut";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.CheckOut_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button showReservationButton;
        private System.Windows.Forms.Button deleteReservationButton;
        private System.Windows.Forms.ColumnHeader nameCol;
        private System.Windows.Forms.ColumnHeader firstNameColumn;
        private System.Windows.Forms.ColumnHeader vehicleInfoCol;
        private System.Windows.Forms.ColumnHeader startCol;
        private System.Windows.Forms.ColumnHeader endColumn;
        
    }

}

       