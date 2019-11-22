namespace Car_Rental_Service
{
    partial class createVehicles
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
            this.components = new System.ComponentModel.Container();
            this.MakeLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.MakeTextBox = new System.Windows.Forms.TextBox();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.mileageLabel = new System.Windows.Forms.Label();
            this.mileageTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.createVehicleButton = new System.Windows.Forms.Button();
            this.phoneNumLabel = new System.Windows.Forms.Label();
            this.phoneNumTextBox = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // MakeLabel
            // 
            this.MakeLabel.AutoSize = true;
            this.MakeLabel.Location = new System.Drawing.Point(22, 28);
            this.MakeLabel.Name = "MakeLabel";
            this.MakeLabel.Size = new System.Drawing.Size(40, 13);
            this.MakeLabel.TabIndex = 0;
            this.MakeLabel.Text = "Make: ";
            this.MakeLabel.Click += new System.EventHandler(this.MakeLabel_Click);
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(22, 55);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(39, 13);
            this.ModelLabel.TabIndex = 1;
            this.ModelLabel.Text = "Model:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(22, 81);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(32, 13);
            this.yearLabel.TabIndex = 3;
            this.yearLabel.Text = "Year:";
            // 
            // MakeTextBox
            // 
            this.MakeTextBox.Location = new System.Drawing.Point(103, 25);
            this.MakeTextBox.Name = "MakeTextBox";
            this.MakeTextBox.Size = new System.Drawing.Size(222, 20);
            this.MakeTextBox.TabIndex = 4;
            this.MakeTextBox.TextChanged += new System.EventHandler(this.makeTextBox_TextChanged);
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Location = new System.Drawing.Point(103, 52);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(222, 20);
            this.ModelTextBox.TabIndex = 5;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(103, 78);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(222, 20);
            this.yearTextBox.TabIndex = 6;
            // 
            // mileageLabel
            // 
            this.mileageLabel.AutoSize = true;
            this.mileageLabel.Location = new System.Drawing.Point(22, 107);
            this.mileageLabel.Name = "mileageLabel";
            this.mileageLabel.Size = new System.Drawing.Size(47, 13);
            this.mileageLabel.TabIndex = 7;
            this.mileageLabel.Text = "Mileage:";
            // 
            // mileageTextBox
            // 
            this.mileageTextBox.Location = new System.Drawing.Point(103, 104);
            this.mileageTextBox.Name = "mileageTextBox";
            this.mileageTextBox.Size = new System.Drawing.Size(222, 20);
            this.mileageTextBox.TabIndex = 8;
            this.mileageTextBox.TextChanged += new System.EventHandler(this.mileageTextBox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.createVehicleButton);
            this.groupBox1.Controls.Add(this.MakeTextBox);
            this.groupBox1.Controls.Add(this.mileageLabel);
            this.groupBox1.Controls.Add(this.mileageTextBox);
            this.groupBox1.Controls.Add(this.MakeLabel);
            this.groupBox1.Controls.Add(this.ModelTextBox);
            this.groupBox1.Controls.Add(this.yearLabel);
            this.groupBox1.Controls.Add(this.yearTextBox);
            this.groupBox1.Controls.Add(this.ModelLabel);
            this.groupBox1.Location = new System.Drawing.Point(37, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 254);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Vehicle";
            // 
            // createVehicleButton
            // 
            this.createVehicleButton.Location = new System.Drawing.Point(150, 180);
            this.createVehicleButton.Name = "createVehicleButton";
            this.createVehicleButton.Size = new System.Drawing.Size(145, 27);
            this.createVehicleButton.TabIndex = 9;
            this.createVehicleButton.Text = "Create ";
            this.createVehicleButton.UseVisualStyleBackColor = true;
            this.createVehicleButton.Click += new System.EventHandler(this.createVehicleButton_Click);
            // 
            // phoneNumLabel
            // 
            this.phoneNumLabel.AutoSize = true;
            this.phoneNumLabel.Location = new System.Drawing.Point(22, 133);
            this.phoneNumLabel.Name = "phoneNumLabel";
            this.phoneNumLabel.Size = new System.Drawing.Size(81, 13);
            this.phoneNumLabel.TabIndex = 11;
            this.phoneNumLabel.Text = "Phone Number:";
            // 
            // phoneNumTextBox
            // 
            this.phoneNumTextBox.Location = new System.Drawing.Point(103, 130);
            this.phoneNumTextBox.MaxLength = 10;
            this.phoneNumTextBox.Name = "phoneNumTextBox";
            this.phoneNumTextBox.Size = new System.Drawing.Size(222, 20);
            this.phoneNumTextBox.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Sedan",
            "Sport",
            "Van",
            "BoxTruck",
            "Pickup"});
            this.comboBox1.Location = new System.Drawing.Point(103, 130);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(222, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Class";
            // 
            // createVehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 355);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Name = "createVehicles";
            this.Text = "createVehicle";
            this.Load += new System.EventHandler(this.createVehicles_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MakeLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox MakeTextBox;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Label mileageLabel;
        private System.Windows.Forms.TextBox mileageTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button createVehicleButton;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label phoneNumLabel;
        private System.Windows.Forms.TextBox phoneNumTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
