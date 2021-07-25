
namespace Coast_Busters
{
    partial class CustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.customerInfoDataGrid = new System.Windows.Forms.DataGridView();
            this.subscriptionDataGrid = new System.Windows.Forms.DataGridView();
            this.rentedCarsDataGrid = new System.Windows.Forms.DataGridView();
            this.rentedBikesDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.rentCarLabel = new System.Windows.Forms.Label();
            this.rentBikeLabel = new System.Windows.Forms.Label();
            this.returnCarLabel = new System.Windows.Forms.Label();
            this.returnBikeLabel = new System.Windows.Forms.Label();
            this.reportAccidentLabel = new System.Windows.Forms.Label();
            this.exitLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customerInfoDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscriptionDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentedCarsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentedBikesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // customerInfoDataGrid
            // 
            this.customerInfoDataGrid.AllowUserToAddRows = false;
            this.customerInfoDataGrid.AllowUserToDeleteRows = false;
            this.customerInfoDataGrid.AllowUserToResizeColumns = false;
            this.customerInfoDataGrid.AllowUserToResizeRows = false;
            this.customerInfoDataGrid.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.customerInfoDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.customerInfoDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerInfoDataGrid.Location = new System.Drawing.Point(2, 2);
            this.customerInfoDataGrid.Name = "customerInfoDataGrid";
            this.customerInfoDataGrid.Size = new System.Drawing.Size(696, 76);
            this.customerInfoDataGrid.TabIndex = 5;
            this.customerInfoDataGrid.Visible = false;
            this.customerInfoDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerInfoDataGrid_CellContentClick);
            // 
            // subscriptionDataGrid
            // 
            this.subscriptionDataGrid.AllowUserToAddRows = false;
            this.subscriptionDataGrid.AllowUserToDeleteRows = false;
            this.subscriptionDataGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.subscriptionDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subscriptionDataGrid.Location = new System.Drawing.Point(2, 84);
            this.subscriptionDataGrid.Name = "subscriptionDataGrid";
            this.subscriptionDataGrid.ReadOnly = true;
            this.subscriptionDataGrid.Size = new System.Drawing.Size(1283, 83);
            this.subscriptionDataGrid.TabIndex = 6;
            // 
            // rentedCarsDataGrid
            // 
            this.rentedCarsDataGrid.AllowUserToAddRows = false;
            this.rentedCarsDataGrid.AllowUserToDeleteRows = false;
            this.rentedCarsDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rentedCarsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentedCarsDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rentedCarsDataGrid.Location = new System.Drawing.Point(39, 579);
            this.rentedCarsDataGrid.Name = "rentedCarsDataGrid";
            this.rentedCarsDataGrid.Size = new System.Drawing.Size(550, 126);
            this.rentedCarsDataGrid.TabIndex = 7;
            // 
            // rentedBikesDataGrid
            // 
            this.rentedBikesDataGrid.AllowUserToAddRows = false;
            this.rentedBikesDataGrid.AllowUserToDeleteRows = false;
            this.rentedBikesDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rentedBikesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentedBikesDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rentedBikesDataGrid.Location = new System.Drawing.Point(675, 579);
            this.rentedBikesDataGrid.Name = "rentedBikesDataGrid";
            this.rentedBikesDataGrid.ReadOnly = true;
            this.rentedBikesDataGrid.Size = new System.Drawing.Size(575, 126);
            this.rentedBikesDataGrid.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(33, 526);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Your Currently Rented Vehicles:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(528, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Welcome Dear Customer";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(633, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 26);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rentCarLabel
            // 
            this.rentCarLabel.AutoSize = true;
            this.rentCarLabel.BackColor = System.Drawing.Color.Transparent;
            this.rentCarLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rentCarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentCarLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.rentCarLabel.Location = new System.Drawing.Point(240, 283);
            this.rentCarLabel.Name = "rentCarLabel";
            this.rentCarLabel.Size = new System.Drawing.Size(89, 25);
            this.rentCarLabel.TabIndex = 13;
            this.rentCarLabel.Text = "Rent Car";
            this.rentCarLabel.Click += new System.EventHandler(this.rentCarLabel_Click);
            // 
            // rentBikeLabel
            // 
            this.rentBikeLabel.AutoSize = true;
            this.rentBikeLabel.BackColor = System.Drawing.Color.Transparent;
            this.rentBikeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rentBikeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentBikeLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.rentBikeLabel.Location = new System.Drawing.Point(1037, 283);
            this.rentBikeLabel.Name = "rentBikeLabel";
            this.rentBikeLabel.Size = new System.Drawing.Size(95, 25);
            this.rentBikeLabel.TabIndex = 14;
            this.rentBikeLabel.Text = "Rent Bike";
            this.rentBikeLabel.Click += new System.EventHandler(this.rentBikeLabel_Click);
            // 
            // returnCarLabel
            // 
            this.returnCarLabel.AutoSize = true;
            this.returnCarLabel.BackColor = System.Drawing.Color.Transparent;
            this.returnCarLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnCarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnCarLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.returnCarLabel.Location = new System.Drawing.Point(260, 344);
            this.returnCarLabel.Name = "returnCarLabel";
            this.returnCarLabel.Size = new System.Drawing.Size(106, 25);
            this.returnCarLabel.TabIndex = 18;
            this.returnCarLabel.Text = "Return Car";
            this.returnCarLabel.Click += new System.EventHandler(this.returnCarLabel_Click);
            // 
            // returnBikeLabel
            // 
            this.returnBikeLabel.AutoSize = true;
            this.returnBikeLabel.BackColor = System.Drawing.Color.Transparent;
            this.returnBikeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnBikeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBikeLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.returnBikeLabel.Location = new System.Drawing.Point(996, 344);
            this.returnBikeLabel.Name = "returnBikeLabel";
            this.returnBikeLabel.Size = new System.Drawing.Size(112, 25);
            this.returnBikeLabel.TabIndex = 19;
            this.returnBikeLabel.Text = "Return Bike";
            this.returnBikeLabel.Click += new System.EventHandler(this.returnBikeLabel_Click);
            // 
            // reportAccidentLabel
            // 
            this.reportAccidentLabel.AutoSize = true;
            this.reportAccidentLabel.BackColor = System.Drawing.Color.Transparent;
            this.reportAccidentLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reportAccidentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportAccidentLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.reportAccidentLabel.Location = new System.Drawing.Point(285, 418);
            this.reportAccidentLabel.Name = "reportAccidentLabel";
            this.reportAccidentLabel.Size = new System.Drawing.Size(113, 18);
            this.reportAccidentLabel.TabIndex = 20;
            this.reportAccidentLabel.Text = "Report Accident";
            this.reportAccidentLabel.Click += new System.EventHandler(this.reportAccidentLabel_Click);
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.BackColor = System.Drawing.Color.Transparent;
            this.exitLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.exitLabel.Location = new System.Drawing.Point(996, 418);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(44, 25);
            this.exitLabel.TabIndex = 21;
            this.exitLabel.Text = "Exit";
            this.exitLabel.Click += new System.EventHandler(this.exitLabel_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Coast_Busters.Properties.Resources._5356237;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.exitLabel);
            this.Controls.Add(this.reportAccidentLabel);
            this.Controls.Add(this.returnBikeLabel);
            this.Controls.Add(this.returnCarLabel);
            this.Controls.Add(this.rentBikeLabel);
            this.Controls.Add(this.rentCarLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rentedBikesDataGrid);
            this.Controls.Add(this.rentedCarsDataGrid);
            this.Controls.Add(this.subscriptionDataGrid);
            this.Controls.Add(this.customerInfoDataGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CustomerForm";
            this.Text = "Customer Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerInfoDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscriptionDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentedCarsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentedBikesDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView customerInfoDataGrid;
        private System.Windows.Forms.DataGridView subscriptionDataGrid;
        private System.Windows.Forms.DataGridView rentedCarsDataGrid;
        private System.Windows.Forms.DataGridView rentedBikesDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label rentCarLabel;
        private System.Windows.Forms.Label rentBikeLabel;
        private System.Windows.Forms.Label returnCarLabel;
        private System.Windows.Forms.Label returnBikeLabel;
        private System.Windows.Forms.Label reportAccidentLabel;
        private System.Windows.Forms.Label exitLabel;
    }
}