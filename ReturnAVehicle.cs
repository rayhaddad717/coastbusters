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
    public partial class ReturnAVehicle : Form
    {

        public Boolean returnCar;
        public int personID;
        public Boolean reportDamage;

        private SqlConnection conn;
        private SqlCommand command;
        private SqlDataAdapter dataAdapter;
        private DataSet ds;
        private SqlDataReader dataReader;
        private string commandText;
        private string availableVehicle;
        private string vehicleID;
        private string vehicle;
        private string condition;

        public ReturnAVehicle()
        {
            InitializeComponent();
        }

        private void ReturnAVehicle_Load(object sender, EventArgs e)
        {
            
            

                //Populate the available Vehicles for a Customer
                Connection Conn = new Connection();
                conn = Conn.GetSqlConnection();
                commandText = "select ac.CarID ,ac.Color,ac.Condition,ac.NeedsRepair, cm.Name from AvailableCars as ac inner join CarModels cm on ac.CarModelID=cm.CarModelID where ac.RentedByPersonID= " + personID +
                        "select ab.BikeID ,ab.Color,ab.Condition,ab.NeedsRepair, bm.Name from AvailableBikes as ab inner join BikeModels bm on ab.BikeModelID = bm.BikeModelID where ab.RentedByPersonID = " + personID;
                command = new SqlCommand(commandText, conn);
                ds = new DataSet();

                condition = "Good";

                if (reportDamage)
                {
                    conditionGroupBox.Visible = false;
                    returnVehicleButton.Text = "Report Damaged Vehicle";
                }
                else { }

                try
                {
                    conn.Open();
                    dataAdapter = new SqlDataAdapter(command);
                    dataAdapter.Fill(ds);
                    if (returnCar)
                    {
                        rentedVehicleDataGrid.DataSource = ds.Tables[0];
                        availableVehicle = "AvailableCars";
                        vehicleID = "CarID";
                        vehicle = "Car";
                    }
                    else
                    {
                        rentedVehicleDataGrid.DataSource = ds.Tables[1];
                        availableVehicle = "AvailableBikes";
                        vehicleID = "BikeID";
                        vehicle = "Bike";
                        vehicleIDLabel.Text = "BikeID";
                    }




                    //populate comboBox to choose VehicleID the customer wants to return
                    commandText = "select * from " + availableVehicle + " where RentedByPersonID= " + personID;
                    SqlCommand populateCommand = new SqlCommand(commandText, conn);
                    SqlDataReader dataReader2 = populateCommand.ExecuteReader();
                    List<int> carIDList = new List<int>();
                    while (dataReader2.Read())
                    {
                        carIDList.Add(Convert.ToInt32(dataReader2[vehicleID].ToString()));
                    }
                    vehicleIDComboBox.DataSource = carIDList;
                    dataReader2.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                }
                finally
                {
                    conn.Close();
                }

        
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void returnVehicleButton_Click(object sender, EventArgs e)
        {
            if (vehicleIDComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("You did not select a vehicleID", "Error", MessageBoxButtons.OK);
                return;
            }
            else
            {

                int vehicleID = Convert.ToInt32(vehicleIDComboBox.SelectedItem.ToString());
                //If the customer wants to return a car
                if (!reportDamage)
                {
                    availableVehicleDB availableVehicle = new availableVehicleDB();
                    availableVehicle.returnVehicle(vehicleID, returnCar,personID, condition);

                 
                }
                //If the Customer wants to report a Damage
                else
                {
                    availableVehicleDB availableVehicle = new availableVehicleDB();
                    availableVehicle.reportDamaged(vehicleID, returnCar);
                }
                this.Close();
            }

            this.Close();
        }

        private void averageRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (goodRadioButton.Checked)
                condition = "Good";
            else if (averageRadioButton.Checked)
                condition = "Average";
            else if (brandNewRadioButton.Checked)
                condition = "Brand New";
            else
                condition = "Weared Out";
        }
    }
}
