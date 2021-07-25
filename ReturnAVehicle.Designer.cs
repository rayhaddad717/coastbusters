
namespace Coast_Busters
{
    partial class ReturnAVehicle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnAVehicle));
            this.conditionGroupBox = new System.Windows.Forms.GroupBox();
            this.wearedOutRadioButton = new System.Windows.Forms.RadioButton();
            this.brandNewRadioButton = new System.Windows.Forms.RadioButton();
            this.averageRadioButton = new System.Windows.Forms.RadioButton();
            this.goodRadioButton = new System.Windows.Forms.RadioButton();
            this.rentedVehicleDataGrid = new System.Windows.Forms.DataGridView();
            this.vehicleIDComboBox = new System.Windows.Forms.ComboBox();
            this.vehicleIDLabel = new System.Windows.Forms.Label();
            this.returnVehicleButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.conditionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentedVehicleDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // conditionGroupBox
            // 
            this.conditionGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.conditionGroupBox.Controls.Add(this.wearedOutRadioButton);
            this.conditionGroupBox.Controls.Add(this.brandNewRadioButton);
            this.conditionGroupBox.Controls.Add(this.averageRadioButton);
            this.conditionGroupBox.Controls.Add(this.goodRadioButton);
            this.conditionGroupBox.ForeColor = System.Drawing.SystemColors.Control;
            this.conditionGroupBox.Location = new System.Drawing.Point(12, 147);
            this.conditionGroupBox.Name = "conditionGroupBox";
            this.conditionGroupBox.Size = new System.Drawing.Size(203, 150);
            this.conditionGroupBox.TabIndex = 0;
            this.conditionGroupBox.TabStop = false;
            this.conditionGroupBox.Text = "Condition";
            // 
            // wearedOutRadioButton
            // 
            this.wearedOutRadioButton.AutoSize = true;
            this.wearedOutRadioButton.ForeColor = System.Drawing.SystemColors.Control;
            this.wearedOutRadioButton.Location = new System.Drawing.Point(11, 100);
            this.wearedOutRadioButton.Name = "wearedOutRadioButton";
            this.wearedOutRadioButton.Size = new System.Drawing.Size(83, 17);
            this.wearedOutRadioButton.TabIndex = 3;
            this.wearedOutRadioButton.Text = "Weared Out";
            this.wearedOutRadioButton.UseVisualStyleBackColor = true;
            this.wearedOutRadioButton.CheckedChanged += new System.EventHandler(this.averageRadioButton_CheckedChanged);
            // 
            // brandNewRadioButton
            // 
            this.brandNewRadioButton.AutoSize = true;
            this.brandNewRadioButton.ForeColor = System.Drawing.SystemColors.Control;
            this.brandNewRadioButton.Location = new System.Drawing.Point(11, 77);
            this.brandNewRadioButton.Name = "brandNewRadioButton";
            this.brandNewRadioButton.Size = new System.Drawing.Size(78, 17);
            this.brandNewRadioButton.TabIndex = 2;
            this.brandNewRadioButton.Text = "Brand New";
            this.brandNewRadioButton.UseVisualStyleBackColor = true;
            this.brandNewRadioButton.CheckedChanged += new System.EventHandler(this.averageRadioButton_CheckedChanged);
            // 
            // averageRadioButton
            // 
            this.averageRadioButton.AutoSize = true;
            this.averageRadioButton.ForeColor = System.Drawing.SystemColors.Control;
            this.averageRadioButton.Location = new System.Drawing.Point(11, 31);
            this.averageRadioButton.Name = "averageRadioButton";
            this.averageRadioButton.Size = new System.Drawing.Size(65, 17);
            this.averageRadioButton.TabIndex = 1;
            this.averageRadioButton.Text = "Average";
            this.averageRadioButton.UseVisualStyleBackColor = true;
            this.averageRadioButton.CheckedChanged += new System.EventHandler(this.averageRadioButton_CheckedChanged);
            // 
            // goodRadioButton
            // 
            this.goodRadioButton.AutoSize = true;
            this.goodRadioButton.Checked = true;
            this.goodRadioButton.ForeColor = System.Drawing.SystemColors.Control;
            this.goodRadioButton.Location = new System.Drawing.Point(11, 54);
            this.goodRadioButton.Name = "goodRadioButton";
            this.goodRadioButton.Size = new System.Drawing.Size(51, 17);
            this.goodRadioButton.TabIndex = 0;
            this.goodRadioButton.TabStop = true;
            this.goodRadioButton.Text = "Good";
            this.goodRadioButton.UseVisualStyleBackColor = true;
            this.goodRadioButton.CheckedChanged += new System.EventHandler(this.averageRadioButton_CheckedChanged);
            // 
            // rentedVehicleDataGrid
            // 
            this.rentedVehicleDataGrid.AllowUserToAddRows = false;
            this.rentedVehicleDataGrid.AllowUserToDeleteRows = false;
            this.rentedVehicleDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentedVehicleDataGrid.Location = new System.Drawing.Point(12, 12);
            this.rentedVehicleDataGrid.Name = "rentedVehicleDataGrid";
            this.rentedVehicleDataGrid.ReadOnly = true;
            this.rentedVehicleDataGrid.Size = new System.Drawing.Size(776, 102);
            this.rentedVehicleDataGrid.TabIndex = 1;
            // 
            // vehicleIDComboBox
            // 
            this.vehicleIDComboBox.FormattingEnabled = true;
            this.vehicleIDComboBox.Location = new System.Drawing.Point(625, 174);
            this.vehicleIDComboBox.Name = "vehicleIDComboBox";
            this.vehicleIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.vehicleIDComboBox.TabIndex = 2;
            // 
            // vehicleIDLabel
            // 
            this.vehicleIDLabel.AutoSize = true;
            this.vehicleIDLabel.BackColor = System.Drawing.Color.Black;
            this.vehicleIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleIDLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.vehicleIDLabel.Location = new System.Drawing.Point(537, 174);
            this.vehicleIDLabel.Name = "vehicleIDLabel";
            this.vehicleIDLabel.Size = new System.Drawing.Size(69, 26);
            this.vehicleIDLabel.TabIndex = 3;
            this.vehicleIDLabel.Text = "CarID";
            // 
            // returnVehicleButton
            // 
            this.returnVehicleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.returnVehicleButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.returnVehicleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnVehicleButton.Location = new System.Drawing.Point(66, 332);
            this.returnVehicleButton.Name = "returnVehicleButton";
            this.returnVehicleButton.Size = new System.Drawing.Size(166, 59);
            this.returnVehicleButton.TabIndex = 4;
            this.returnVehicleButton.Text = "Return Vehicle";
            this.returnVehicleButton.UseVisualStyleBackColor = true;
            this.returnVehicleButton.Click += new System.EventHandler(this.returnVehicleButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(553, 332);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(154, 59);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // ReturnAVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Coast_Busters.Properties.Resources._5356237;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.returnVehicleButton);
            this.Controls.Add(this.vehicleIDLabel);
            this.Controls.Add(this.vehicleIDComboBox);
            this.Controls.Add(this.rentedVehicleDataGrid);
            this.Controls.Add(this.conditionGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReturnAVehicle";
            this.Text = "Return A Vehicle";
            this.Load += new System.EventHandler(this.ReturnAVehicle_Load);
            this.conditionGroupBox.ResumeLayout(false);
            this.conditionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentedVehicleDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox conditionGroupBox;
        private System.Windows.Forms.RadioButton wearedOutRadioButton;
        private System.Windows.Forms.RadioButton brandNewRadioButton;
        private System.Windows.Forms.RadioButton averageRadioButton;
        private System.Windows.Forms.RadioButton goodRadioButton;
        private System.Windows.Forms.DataGridView rentedVehicleDataGrid;
        private System.Windows.Forms.ComboBox vehicleIDComboBox;
        private System.Windows.Forms.Label vehicleIDLabel;
        private System.Windows.Forms.Button returnVehicleButton;
        private System.Windows.Forms.Button exitButton;
    }
}