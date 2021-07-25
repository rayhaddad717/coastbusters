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
    public partial class CustomerForm : Form
    {
        public int PersonID;
        private SqlConnection conn;
        private SqlCommand command;
        private DataSet ds;
        private SqlDataAdapter dataAdapter;
        private SqlDataReader dataReader;

        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {

            rentedBikesDataGrid.Visible = false;
            rentedCarsDataGrid.Visible = false;
            label1.Visible = false;

            Connection Conn = new Connection();
            conn = Conn.GetSqlConnection();
            ds = new DataSet();
            PersonDB personDB = new PersonDB();
            int subscriptionID = personDB.getSubscriptionID(PersonID);
            try
            {
                conn.Open();

                string commandText = "select p.PersonID,p.FirstName,p.LastName,p.DateOfBirth,p.Address,p.AccidentsMade,p.NbOfRentedCars,p.SubscriptionID,st.Name, st.NbAllowedRentedCars, st.Cost,s.Status from Subscriptions s inner join SubscriptionTypes st"
                +" on s.SubscriptionTypeID = st.SubscriptionTypeID inner join People p on p.SubscriptionID = s.SubscriptionID where s.SubscriptionID = " + subscriptionID ;
                command = new SqlCommand(commandText, conn);
                SqlDataAdapter dataAdapter2 = new SqlDataAdapter(command);
                DataSet ds2 = new DataSet();
                dataAdapter2.Fill(ds2);
                subscriptionDataGrid.DataSource = ds2.Tables[0];


                commandText = "select ac.CarID ,ac.Color,ac.Condition,ac.NeedsRepair, cm.Name from AvailableCars as ac inner join CarModels cm on ac.CarModelID=cm.CarModelID where ac.RentedByPersonID= " + PersonID+
                    "select ab.BikeID ,ab.Color,ab.Condition,ab.NeedsRepair, bm.Name from AvailableBikes as ab inner join BikeModels bm on ab.BikeModelID = bm.BikeModelID where ab.RentedByPersonID = "+PersonID;
                command.CommandText = commandText;
                SqlDataAdapter dataAdapter3 = new SqlDataAdapter(command);
                DataSet ds3 = new DataSet();
                dataAdapter2.Fill(ds3);
                rentedCarsDataGrid.DataSource = ds3.Tables[0];
                rentedBikesDataGrid.DataSource=ds3.Tables[1];
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                
            }
            finally
            {
                conn.Close();
            }
        }

        private void reportAccidentButton_Click(object sender, EventArgs e)
        {
            PersonDB personDB = new PersonDB();

            ReturnAVehicle reportDamagedVehicle = new ReturnAVehicle();
            reportDamagedVehicle.personID = PersonID;

            DialogResult result = MessageBox.Show("Is your damaged vehicle a Car? (Select no if it's a Bike)", "Choose Damaged Vehicle", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) reportDamagedVehicle.returnCar = true;
            else
            {
                reportDamagedVehicle.returnCar = false;
            }
            reportDamagedVehicle.reportDamage = true;
            if (reportDamagedVehicle.ShowDialog() == DialogResult.OK)
            {

                personDB.reportAccident(PersonID);
            }
            else
            {
                MessageBox.Show("Accident not reported!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

                CustomerForm_Load(sender, e);
        }

        private void rentCarButton_Click(object sender, EventArgs e)
        {

            RentAVehicle rentACar = new RentAVehicle();
            rentACar.PersonID = PersonID;
            rentACar.rentCar = true;
            rentACar.ShowDialog();
            CustomerForm_Load(sender, e);
        }
        private void rentBike_Click(object sender, EventArgs e)
            {

                RentAVehicle rentACar = new RentAVehicle();
                rentACar.PersonID = PersonID;
                rentACar.rentCar = false;
                rentACar.ShowDialog();
                CustomerForm_Load(sender, e);
            }
        private void returnCarButton_Click(object sender, EventArgs e)
                {
                    ReturnAVehicle returnCar = new ReturnAVehicle();
                    returnCar.returnCar = true;
                    returnCar.personID = PersonID;
                    returnCar.reportDamage = false;
                    returnCar.ShowDialog();
                    CustomerForm_Load(sender, e);
                }

        private void returnBikeButton_Click(object sender, EventArgs e)
        {
            ReturnAVehicle returnBike = new ReturnAVehicle();
            returnBike.returnCar = false;
            returnBike.reportDamage = false;
            returnBike.personID = PersonID;
            returnBike.ShowDialog();
            CustomerForm_Load(sender, e);
        }

        private void customerInfoDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rentedCarsDataGrid.Visible || rentedBikesDataGrid.Visible||label1.Visible)
            {

                rentedBikesDataGrid.Visible = false;
                rentedCarsDataGrid.Visible = false;
                label1.Visible = false;

            }
            else
            {

                rentedBikesDataGrid.Visible = true;
                rentedCarsDataGrid.Visible = true;
                label1.Visible = true;
            }
        }

        private void rentCarLabel_Click(object sender, EventArgs e)
        {

            RentAVehicle rentACar = new RentAVehicle();
            rentACar.PersonID = PersonID;
            rentACar.rentCar = true;
            rentACar.ShowDialog();
            CustomerForm_Load(sender, e);

        }

        private void rentBikeLabel_Click(object sender, EventArgs e)
        {

            RentAVehicle rentACar = new RentAVehicle();
            rentACar.PersonID = PersonID;
            rentACar.rentCar = false;
            rentACar.ShowDialog();
            CustomerForm_Load(sender, e);
        }

        private void returnCarLabel_Click(object sender, EventArgs e)
        {

            ReturnAVehicle returnCar = new ReturnAVehicle();
            returnCar.returnCar = true;
            returnCar.personID = PersonID;
            returnCar.reportDamage = false;
            returnCar.ShowDialog();
            CustomerForm_Load(sender, e);
        }

        private void returnBikeLabel_Click(object sender, EventArgs e)
        {

            ReturnAVehicle returnBike = new ReturnAVehicle();
            returnBike.returnCar = false;
            returnBike.reportDamage = false;
            returnBike.personID = PersonID;
            returnBike.ShowDialog();
            CustomerForm_Load(sender, e);
        }

        private void reportAccidentLabel_Click(object sender, EventArgs e)
        {

            PersonDB personDB = new PersonDB();

            ReturnAVehicle reportDamagedVehicle = new ReturnAVehicle();
            reportDamagedVehicle.personID = PersonID;

            DialogResult result = MessageBox.Show("Is your damaged vehicle a Car? (Select no if it's a Bike)", "Choose Damaged Vehicle", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) reportDamagedVehicle.returnCar = true;
            else
            {
                reportDamagedVehicle.returnCar = false;
            }
            reportDamagedVehicle.reportDamage = true;
            if (reportDamagedVehicle.ShowDialog() == DialogResult.OK)
            {

                personDB.reportAccident(PersonID);
            }
            else
            {
                MessageBox.Show("Accident not reported!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            CustomerForm_Load(sender, e);
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
