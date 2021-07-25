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
    public partial class LoginForm : Form
    {

        private Connection connection; 
        private SqlConnection sqlConnection; 
        public LoginForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

            connection = new Connection();
            sqlConnection = connection.GetSqlConnection();
            try
            {
                sqlConnection.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void createNewLoginButton_Click(object sender, EventArgs e)
        {
            AddAccount addAcc = new AddAccount();
            DialogResult result =addAcc.ShowDialog();
            if (result == DialogResult.OK&&addAcc.addAcc)
            {
                userNameTextBox.Text = addAcc.Tag.ToString();
                passwordTextBox.Text = "";
            }
            else { }

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            int LoginID;
            string password;
            try
            {
               LoginID = Convert.ToInt32(userNameTextBox.Text);
               password = passwordTextBox.Text.ToString();
            }
            catch(FormatException formex)
            {
                MessageBox.Show("Please make sure of your inputs","Incorrect input syntax",MessageBoxButtons.OK);
                return;
            }
            catch (Exception ex)
            {
                if(ex.Message== "Invalid attempt to read when no data is present.")
                {
                    MessageBox.Show("This username does not exist.", "Error", MessageBoxButtons.OK);
                }
                else
                {

                    MessageBox.Show("Password is incorrect", "Error", MessageBoxButtons.OK);
                }
                return;
            }
            finally
            {
            }
            Login login = new Login();
            login.LoginID = LoginID;
            login.password = password;
            LoginDB loginDB = new LoginDB();
            bool isCorrectLogin = loginDB.isCorrectLogin(LoginID, password);

            PersonDB personDB = new PersonDB();
            if (isCorrectLogin)
            {
                MessageBox.Show("Logged in","Success",MessageBoxButtons.OK);
                login.PersonID = loginDB.getPersonID(login);
                int personIDTest= loginDB.getPersonID(login);

                Boolean isCustomer = personDB.isCustomer(personIDTest);
                if (isCustomer)
                {
                    CustomerForm customerForm = new CustomerForm();
                    if (personIDTest > 0)
                        customerForm.PersonID = personIDTest;
                    customerForm.ShowDialog();

                }
                else
                {
                    EmployeeForm empForm = new EmployeeForm();
                    empForm.ShowDialog();
                }


            }
            else
                MessageBox.Show("Did not Logged in");

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

            int LoginID = Convert.ToInt32(userNameTextBox.Text);
            string password = passwordTextBox.Text.ToString();
            Login login = new Login();
            login.LoginID = LoginID;
            login.password = password;
            LoginDB loginDB = new LoginDB();
            bool isCorrectLogin = loginDB.isCorrectLogin(LoginID, password);

            PersonDB personDB = new PersonDB();

            if (isCorrectLogin)
            {
                login.PersonID = loginDB.getPersonID(login);
                int personIDTest = loginDB.getPersonID(login);

                Boolean isCustomer = personDB.isCustomer(personIDTest);
                if (isCustomer)
                {
                    int nbRentedCarsbyCustomer=personDB.getNbRentedCars(personIDTest);
                    if (nbRentedCarsbyCustomer != 0)
                    {

                        MessageBox.Show("You must return all your vehicles before you can delete your account!\nAccount Not Deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return;
                    }
                    else { }

                    SubscriptionDB subscriptionDB = new SubscriptionDB();
                    int subsID = personDB.getSubscriptionID(personIDTest);
                    if (subscriptionDB.deleteSubscription(subsID)) //when i delete subscription id the cascaded will delete person which will in turn delete login
                    {

                        MessageBox.Show("Deleted Account", "Success", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Deleted Failed", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (!personDB.deletePeople(personIDTest)) //no need since deleted a person will automatically delete a login since deleterule is cascading for database
                                                              //!loginDB.deleteLogin(LoginID)){
                    {
                        MessageBox.Show("Delete Failed", "Delete", MessageBoxButtons.OK);

                    }
                    else
                    {
                        MessageBox.Show("Deleted Account", "Success", MessageBoxButtons.OK);
                    }
                }

            }
                           
            
            else
                MessageBox.Show("Did not delete Account.\nDid not login ","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }
}
