
namespace Coast_Busters
{
    partial class AddAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAccount));
            this.personIdLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.subscriptionIDLabel = new System.Windows.Forms.Label();
            this.DOBLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.employeeRadioButton = new System.Windows.Forms.RadioButton();
            this.CustomerRadioButton = new System.Windows.Forms.RadioButton();
            this.createAccountButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.subscriptionIDValueLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.subsComboBox = new System.Windows.Forms.ComboBox();
            this.subsTypeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.allowedCarsLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // personIdLabel
            // 
            this.personIdLabel.AutoSize = true;
            this.personIdLabel.Location = new System.Drawing.Point(49, 53);
            this.personIdLabel.Name = "personIdLabel";
            this.personIdLabel.Size = new System.Drawing.Size(18, 13);
            this.personIdLabel.TabIndex = 0;
            this.personIdLabel.Text = "ID";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(49, 84);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(49, 117);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(49, 148);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(45, 13);
            this.addressLabel.TabIndex = 3;
            this.addressLabel.Text = "Address";
            // 
            // subscriptionIDLabel
            // 
            this.subscriptionIDLabel.AutoSize = true;
            this.subscriptionIDLabel.Location = new System.Drawing.Point(238, 418);
            this.subscriptionIDLabel.Name = "subscriptionIDLabel";
            this.subscriptionIDLabel.Size = new System.Drawing.Size(79, 13);
            this.subscriptionIDLabel.TabIndex = 5;
            this.subscriptionIDLabel.Text = "Subscription ID";
            this.subscriptionIDLabel.Visible = false;
            // 
            // DOBLabel
            // 
            this.DOBLabel.AutoSize = true;
            this.DOBLabel.Location = new System.Drawing.Point(49, 182);
            this.DOBLabel.Name = "DOBLabel";
            this.DOBLabel.Size = new System.Drawing.Size(68, 13);
            this.DOBLabel.TabIndex = 6;
            this.DOBLabel.Text = "Date Of Birth";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.employeeRadioButton);
            this.panel1.Controls.Add(this.CustomerRadioButton);
            this.panel1.Location = new System.Drawing.Point(60, 251);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(90, 46);
            this.panel1.TabIndex = 9;
            // 
            // employeeRadioButton
            // 
            this.employeeRadioButton.AutoSize = true;
            this.employeeRadioButton.Checked = true;
            this.employeeRadioButton.Location = new System.Drawing.Point(3, 26);
            this.employeeRadioButton.Name = "employeeRadioButton";
            this.employeeRadioButton.Size = new System.Drawing.Size(71, 17);
            this.employeeRadioButton.TabIndex = 1;
            this.employeeRadioButton.TabStop = true;
            this.employeeRadioButton.Text = "Employee";
            this.employeeRadioButton.UseVisualStyleBackColor = true;
            // 
            // CustomerRadioButton
            // 
            this.CustomerRadioButton.AutoSize = true;
            this.CustomerRadioButton.Location = new System.Drawing.Point(3, 3);
            this.CustomerRadioButton.Name = "CustomerRadioButton";
            this.CustomerRadioButton.Size = new System.Drawing.Size(69, 17);
            this.CustomerRadioButton.TabIndex = 0;
            this.CustomerRadioButton.Text = "Customer";
            this.CustomerRadioButton.UseVisualStyleBackColor = true;
            this.CustomerRadioButton.CheckedChanged += new System.EventHandler(this.CustomerRadioButton_CheckedChanged);
            // 
            // createAccountButton
            // 
            this.createAccountButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.createAccountButton.Location = new System.Drawing.Point(60, 444);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(131, 23);
            this.createAccountButton.TabIndex = 10;
            this.createAccountButton.Text = "Create Account";
            this.createAccountButton.UseVisualStyleBackColor = true;
            this.createAccountButton.Click += new System.EventHandler(this.createAccountButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(218, 444);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(147, 55);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 12;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(147, 81);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.firstNameTextBox.TabIndex = 13;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(147, 117);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.lastNameTextBox.TabIndex = 14;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(147, 145);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(200, 20);
            this.addressTextBox.TabIndex = 15;
            // 
            // subscriptionIDValueLabel
            // 
            this.subscriptionIDValueLabel.AutoSize = true;
            this.subscriptionIDValueLabel.Location = new System.Drawing.Point(370, 421);
            this.subscriptionIDValueLabel.Name = "subscriptionIDValueLabel";
            this.subscriptionIDValueLabel.Size = new System.Drawing.Size(55, 13);
            this.subscriptionIDValueLabel.TabIndex = 17;
            this.subscriptionIDValueLabel.Text = "................";
            this.subscriptionIDValueLabel.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(147, 182);
            this.dateTimePicker1.MaxDate = new System.DateTime(2090, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 18;
            this.dateTimePicker1.Value = new System.DateTime(2003, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // subsComboBox
            // 
            this.subsComboBox.FormattingEnabled = true;
            this.subsComboBox.Items.AddRange(new object[] {
            "Silver",
            "Gold",
            "Platinum"});
            this.subsComboBox.Location = new System.Drawing.Point(172, 353);
            this.subsComboBox.Name = "subsComboBox";
            this.subsComboBox.Size = new System.Drawing.Size(121, 21);
            this.subsComboBox.TabIndex = 20;
            this.subsComboBox.Visible = false;
            this.subsComboBox.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // subsTypeLabel
            // 
            this.subsTypeLabel.AutoSize = true;
            this.subsTypeLabel.Location = new System.Drawing.Point(72, 356);
            this.subsTypeLabel.Name = "subsTypeLabel";
            this.subsTypeLabel.Size = new System.Drawing.Size(92, 13);
            this.subsTypeLabel.TabIndex = 21;
            this.subsTypeLabel.Text = "Subscription Type";
            this.subsTypeLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Allows Cars At A Time";
            this.label1.Visible = false;
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(197, 418);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(0, 13);
            this.costLabel.TabIndex = 23;
            this.costLabel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Cost";
            this.label3.Visible = false;
            // 
            // allowedCarsLabel
            // 
            this.allowedCarsLabel.AutoSize = true;
            this.allowedCarsLabel.Location = new System.Drawing.Point(197, 405);
            this.allowedCarsLabel.Name = "allowedCarsLabel";
            this.allowedCarsLabel.Size = new System.Drawing.Size(0, 13);
            this.allowedCarsLabel.TabIndex = 25;
            this.allowedCarsLabel.Visible = false;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(75, 316);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 26;
            this.passwordLabel.Text = "Password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(172, 308);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 27;
            // 
            // AddViewAccount
            // 
            this.AcceptButton = this.createAccountButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(503, 508);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.allowedCarsLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.subsTypeLabel);
            this.Controls.Add(this.subsComboBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.subscriptionIDValueLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.createAccountButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DOBLabel);
            this.Controls.Add(this.subscriptionIDLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.personIdLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddViewAccount";
            this.Text = "Create Account";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label personIdLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label subscriptionIDLabel;
        private System.Windows.Forms.Label DOBLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton employeeRadioButton;
        private System.Windows.Forms.RadioButton CustomerRadioButton;
        private System.Windows.Forms.Button createAccountButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label subscriptionIDValueLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox subsComboBox;
        private System.Windows.Forms.Label subsTypeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label allowedCarsLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
    }
}