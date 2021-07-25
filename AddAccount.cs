using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Coast_Busters
{
    public partial class AddAccount : Form
    {
        private static Person person;
        private static Subscription subscription;
        public Boolean addAcc;
        public AddAccount()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            person = new Person();
            subscription = new Subscription();
            try
            {
                person.firstName = firstNameTextBox.Text.ToString();
                person.lastName = lastNameTextBox.Text.ToString();
                person.DOB = dateTimePicker1.Value.ToString();
                person.address = addressTextBox.Text.ToString();
                person.accidentsMade = 0;
                person.nbRentedCars = 0;
                if (person.firstName == "" || person.lastName==""||person.DOB==""||person.address=="")
                {
                    
                        MessageBox.Show("You left empy fields.\nAccount Not Created", "Format error", MessageBoxButtons.OK);
                        addAcc = false;
                        return;
                    
                }
                else if (CustomerRadioButton.Checked && subsComboBox.SelectedIndex == -1)
                {

                    MessageBox.Show("You left empy fields", "Format error", MessageBoxButtons.OK);
                    addAcc = false;
                    return;
                }
                if (CustomerRadioButton.Checked == true)
                {
                    person.isCustomer = true;
                subscription.Status = true;
                subscription.SubscriptionTypeID = subsComboBox.SelectedIndex + 1;
                SubscriptionDB subsDb = new SubscriptionDB();
                person.subscriptionID = subsDb.addSubscription(subscription);
                }
                else
                {
                    person.isCustomer = false;
                    subscription.Status = true;
                    subscription.SubscriptionTypeID = 4;
                    SubscriptionDB subsDb = new SubscriptionDB();
                    person.subscriptionID = subsDb.addSubscription(subscription);
                }

                int ID = PersonDB.addPerson(person);
                Login login = new Login();
                login.password = passwordTextBox.Text.ToString();
                login.isCustomer = CustomerRadioButton.Checked;
                login.PersonID = ID;

                LoginDB loginDB = new LoginDB();
                ID = loginDB.addLogin(login);

                this.idTextBox.Text = ID.ToString();
                this.Tag = ID;
                if (ID<0)
                {
                    MessageBox.Show("Failure ");
                }
                addAcc = true;
                MessageBox.Show("Your login id is= " + ID);

                this.Close();

            }
            catch (FormatException ex) {
                MessageBox.Show(ex.Message, "Format Error has Occured");
            }




        }

        private void CustomerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (CustomerRadioButton.Checked)
            {
                subsTypeLabel.Visible = true;
                subsComboBox.Visible = true;
                label1.Visible = true;
                label3.Visible = true;
                costLabel.Visible = true;
                allowedCarsLabel.Visible = true;

            }
            else
            {
                
                subsTypeLabel.Visible = false;
                subsComboBox.Visible = false;
                label1.Visible = false;
                label3.Visible = false;
                costLabel.Visible = false;
                allowedCarsLabel.Visible = false;
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (subsComboBox.SelectedIndex==0)
            {
                costLabel.Text = "300";
                allowedCarsLabel.Text = "1";
            }
            else if (subsComboBox.SelectedIndex==1)
            {
                costLabel.Text = "750";
                allowedCarsLabel.Text = "3";
            }
            else if (subsComboBox.SelectedIndex==2)
            {
                costLabel.Text = "2000";
                allowedCarsLabel.Text = "9";
            }
        }
    }
}
