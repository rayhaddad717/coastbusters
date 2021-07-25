
namespace Coast_Busters
{
    partial class EmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            this.updateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.editTableTab = new System.Windows.Forms.TabControl();
            this.AvailableCars = new System.Windows.Forms.TabPage();
            this.BikeModels = new System.Windows.Forms.TabPage();
            this.CarModels = new System.Windows.Forms.TabPage();
            this.LoginCredentials = new System.Windows.Forms.TabPage();
            this.People = new System.Windows.Forms.TabPage();
            this.SubscriptionTypes = new System.Windows.Forms.TabPage();
            this.Subscriptions = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.editTableTab.SuspendLayout();
            this.AvailableCars.SuspendLayout();
            this.SuspendLayout();
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(250, 500);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(132, 70);
            this.updateButton.TabIndex = 0;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(1000, 500);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(132, 70);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView.Location = new System.Drawing.Point(3, 3);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(1336, 362);
            this.dataGridView.TabIndex = 2;
            // 
            // editTableTab
            // 
            this.editTableTab.Controls.Add(this.AvailableCars);
            this.editTableTab.Controls.Add(this.BikeModels);
            this.editTableTab.Controls.Add(this.CarModels);
            this.editTableTab.Controls.Add(this.LoginCredentials);
            this.editTableTab.Controls.Add(this.People);
            this.editTableTab.Controls.Add(this.SubscriptionTypes);
            this.editTableTab.Controls.Add(this.Subscriptions);
            this.editTableTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editTableTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editTableTab.ItemSize = new System.Drawing.Size(167, 28);
            this.editTableTab.Location = new System.Drawing.Point(0, 0);
            this.editTableTab.Name = "editTableTab";
            this.editTableTab.SelectedIndex = 0;
            this.editTableTab.Size = new System.Drawing.Size(1350, 729);
            this.editTableTab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.editTableTab.TabIndex = 5;
            this.editTableTab.SelectedIndexChanged += new System.EventHandler(this.editTableTab_SelectedIndexChanged);
            // 
            // AvailableCars
            // 
            this.AvailableCars.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AvailableCars.BackgroundImage")));
            this.AvailableCars.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AvailableCars.Controls.Add(this.dataGridView);
            this.AvailableCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailableCars.Location = new System.Drawing.Point(4, 32);
            this.AvailableCars.Name = "AvailableCars";
            this.AvailableCars.Padding = new System.Windows.Forms.Padding(3);
            this.AvailableCars.Size = new System.Drawing.Size(1342, 693);
            this.AvailableCars.TabIndex = 1;
            this.AvailableCars.Text = "Available Cars";
            this.AvailableCars.UseVisualStyleBackColor = true;
            // 
            // BikeModels
            // 
            this.BikeModels.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BikeModels.BackgroundImage")));
            this.BikeModels.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BikeModels.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BikeModels.Location = new System.Drawing.Point(4, 32);
            this.BikeModels.Name = "BikeModels";
            this.BikeModels.Size = new System.Drawing.Size(1342, 693);
            this.BikeModels.TabIndex = 2;
            this.BikeModels.Text = "Bike Models";
            this.BikeModels.UseVisualStyleBackColor = true;
            // 
            // CarModels
            // 
            this.CarModels.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CarModels.BackgroundImage")));
            this.CarModels.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CarModels.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarModels.Location = new System.Drawing.Point(4, 32);
            this.CarModels.Name = "CarModels";
            this.CarModels.Size = new System.Drawing.Size(1342, 693);
            this.CarModels.TabIndex = 3;
            this.CarModels.Text = "Car Models";
            this.CarModels.UseVisualStyleBackColor = true;
            // 
            // LoginCredentials
            // 
            this.LoginCredentials.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginCredentials.BackgroundImage")));
            this.LoginCredentials.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoginCredentials.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginCredentials.Location = new System.Drawing.Point(4, 32);
            this.LoginCredentials.Name = "LoginCredentials";
            this.LoginCredentials.Size = new System.Drawing.Size(1342, 693);
            this.LoginCredentials.TabIndex = 4;
            this.LoginCredentials.Text = "Login Credentials";
            this.LoginCredentials.UseVisualStyleBackColor = true;
            // 
            // People
            // 
            this.People.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("People.BackgroundImage")));
            this.People.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.People.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.People.Location = new System.Drawing.Point(4, 32);
            this.People.Name = "People";
            this.People.Size = new System.Drawing.Size(1342, 693);
            this.People.TabIndex = 5;
            this.People.Text = "People";
            this.People.UseVisualStyleBackColor = true;
            // 
            // SubscriptionTypes
            // 
            this.SubscriptionTypes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SubscriptionTypes.BackgroundImage")));
            this.SubscriptionTypes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SubscriptionTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubscriptionTypes.Location = new System.Drawing.Point(4, 32);
            this.SubscriptionTypes.Name = "SubscriptionTypes";
            this.SubscriptionTypes.Size = new System.Drawing.Size(1342, 693);
            this.SubscriptionTypes.TabIndex = 6;
            this.SubscriptionTypes.Text = "Subscription Types";
            this.SubscriptionTypes.UseVisualStyleBackColor = true;
            // 
            // Subscriptions
            // 
            this.Subscriptions.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Subscriptions.BackgroundImage")));
            this.Subscriptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Subscriptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subscriptions.Location = new System.Drawing.Point(4, 32);
            this.Subscriptions.Name = "Subscriptions";
            this.Subscriptions.Size = new System.Drawing.Size(1342, 693);
            this.Subscriptions.TabIndex = 7;
            this.Subscriptions.Text = "Subscriptions";
            this.Subscriptions.UseVisualStyleBackColor = true;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.editTableTab);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.updateButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeeForm";
            this.Text = "Employee Form";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.editTableTab.ResumeLayout(false);
            this.AvailableCars.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TabControl editTableTab;
        private System.Windows.Forms.TabPage AvailableCars;
        private System.Windows.Forms.TabPage BikeModels;
        private System.Windows.Forms.TabPage CarModels;
        private System.Windows.Forms.TabPage LoginCredentials;
        private System.Windows.Forms.TabPage People;
        private System.Windows.Forms.TabPage SubscriptionTypes;
        private System.Windows.Forms.TabPage Subscriptions;
    }
}