
namespace Coast_Busters
{
    partial class RentAVehicle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentAVehicle));
            this.carsDataGrid = new System.Windows.Forms.DataGridView();
            this.availableLabel = new System.Windows.Forms.Label();
            this.carIDComboBox = new System.Windows.Forms.ComboBox();
            this.rentCarButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.carIDLabel = new System.Windows.Forms.Label();
            this.carModelIDLabel = new System.Windows.Forms.Label();
            this.carModelIDComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.carsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // carsDataGrid
            // 
            this.carsDataGrid.AllowUserToAddRows = false;
            this.carsDataGrid.AllowUserToDeleteRows = false;
            this.carsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carsDataGrid.Location = new System.Drawing.Point(36, 50);
            this.carsDataGrid.Name = "carsDataGrid";
            this.carsDataGrid.ReadOnly = true;
            this.carsDataGrid.Size = new System.Drawing.Size(702, 150);
            this.carsDataGrid.TabIndex = 0;
            // 
            // availableLabel
            // 
            this.availableLabel.AutoSize = true;
            this.availableLabel.Cursor = System.Windows.Forms.Cursors.PanSouth;
            this.availableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableLabel.Location = new System.Drawing.Point(310, 9);
            this.availableLabel.Name = "availableLabel";
            this.availableLabel.Size = new System.Drawing.Size(153, 26);
            this.availableLabel.TabIndex = 1;
            this.availableLabel.Text = "Available Cars";
            // 
            // carIDComboBox
            // 
            this.carIDComboBox.FormattingEnabled = true;
            this.carIDComboBox.Location = new System.Drawing.Point(539, 286);
            this.carIDComboBox.Name = "carIDComboBox";
            this.carIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.carIDComboBox.TabIndex = 2;
            // 
            // rentCarButton
            // 
            this.rentCarButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.rentCarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentCarButton.Location = new System.Drawing.Point(133, 339);
            this.rentCarButton.Name = "rentCarButton";
            this.rentCarButton.Size = new System.Drawing.Size(114, 46);
            this.rentCarButton.TabIndex = 3;
            this.rentCarButton.Text = "Rent Car";
            this.rentCarButton.UseVisualStyleBackColor = true;
            this.rentCarButton.Click += new System.EventHandler(this.rentCarButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(401, 339);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(96, 46);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // carIDLabel
            // 
            this.carIDLabel.AutoSize = true;
            this.carIDLabel.BackColor = System.Drawing.Color.Transparent;
            this.carIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carIDLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.carIDLabel.Location = new System.Drawing.Point(449, 283);
            this.carIDLabel.Name = "carIDLabel";
            this.carIDLabel.Size = new System.Drawing.Size(69, 26);
            this.carIDLabel.TabIndex = 5;
            this.carIDLabel.Text = "CarID";
            // 
            // carModelIDLabel
            // 
            this.carModelIDLabel.AutoSize = true;
            this.carModelIDLabel.BackColor = System.Drawing.Color.Transparent;
            this.carModelIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carModelIDLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.carModelIDLabel.Location = new System.Drawing.Point(14, 283);
            this.carModelIDLabel.Name = "carModelIDLabel";
            this.carModelIDLabel.Size = new System.Drawing.Size(154, 24);
            this.carModelIDLabel.TabIndex = 6;
            this.carModelIDLabel.Text = "Vehicle Model ID";
            // 
            // carModelIDComboBox
            // 
            this.carModelIDComboBox.FormattingEnabled = true;
            this.carModelIDComboBox.Location = new System.Drawing.Point(187, 283);
            this.carModelIDComboBox.Name = "carModelIDComboBox";
            this.carModelIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.carModelIDComboBox.TabIndex = 7;
            this.carModelIDComboBox.SelectedIndexChanged += new System.EventHandler(this.carModelIDComboBox_SelectedIndexChanged);
            // 
            // RentAVehicle
            // 
            this.AcceptButton = this.rentCarButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Coast_Busters.Properties.Resources._5356237;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.carModelIDComboBox);
            this.Controls.Add(this.carModelIDLabel);
            this.Controls.Add(this.carIDLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.rentCarButton);
            this.Controls.Add(this.carIDComboBox);
            this.Controls.Add(this.availableLabel);
            this.Controls.Add(this.carsDataGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RentAVehicle";
            this.Text = "Take A Vehicle";
            this.Load += new System.EventHandler(this.TakeACar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView carsDataGrid;
        private System.Windows.Forms.Label availableLabel;
        private System.Windows.Forms.ComboBox carIDComboBox;
        private System.Windows.Forms.Button rentCarButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label carIDLabel;
        private System.Windows.Forms.Label carModelIDLabel;
        private System.Windows.Forms.ComboBox carModelIDComboBox;
    }
}