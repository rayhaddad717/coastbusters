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
    public partial class RentAVehicle : Form
    {
        public Boolean rentCar;
        public RentAVehicle()
        {
            InitializeComponent();
        }
        private Connection connection;
        private SqlConnection conn;
        public int PersonID;
        private string vehicleModel;
        private string availableVehicle;
        private string vehicleID;
        private string vehicle;
        private void TakeACar_Load(object sender, EventArgs e)
        {
            if (!rentCar)
            {
                //if The person wants to rent a bike then adjust the entire form to display bike info
                this.Text = "Take A Bike";
                availableLabel.Text = "Available Bikes";
                carIDLabel.Text = "BikeID";
                rentCarButton.Text = "Rent Bike";
                vehicle = "Bike";
                vehicleModel = "BikeModels";
                availableVehicle = "AvailableBikes";
                vehicleID = "BikeID";
            }
            else
            {
                vehicle = "Car";
                availableVehicle = "AvailableCars";
                vehicleModel = "CarModels";
                vehicleID = "CarID";
            }
            connection = new Connection();
            conn = connection.GetSqlConnection();
            SqlCommand getCarsCommand=new SqlCommand();
            string comandText = "select * from "+ vehicleModel+ " where Nb"+ vehicle +"sLeft > 0";
            //Fill the dataGrid and the combobox with info about the available Cars/Bikes
            try
            {
                conn.Open();
                //Populate data grid with vehicle models
                getCarsCommand.CommandText = comandText;
                getCarsCommand.Connection = conn;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(getCarsCommand);
                DataSet carList = new DataSet();
                dataAdapter.Fill(carList);
                carsDataGrid.DataSource = carList.Tables[0];


                //Populate VehicleModelID ComboBox 

                string commandText = "select * from " + vehicleModel + " where Nb" + vehicle + "sLeft >0 "; 
                getCarsCommand.CommandText = commandText;
                SqlDataReader dataReader2 = getCarsCommand.ExecuteReader();
                List<int> carModelIDList = new List<int>();
                while (dataReader2.Read())
                {
                    carModelIDList.Add(Convert.ToInt32(dataReader2[vehicle + "ModelID"].ToString()));
                }
                dataReader2.Close();
                carModelIDComboBox.DataSource = carModelIDList;

                //Populate available vehicleID combobox 
                if (carModelIDComboBox.SelectedIndex != -1)
                {
                    commandText = "select * from " + availableVehicle + " where isRented=0 and " + vehicle + "ModelID = " + carModelIDComboBox.SelectedItem.ToString();
                    getCarsCommand.CommandText = commandText;
                    if (conn.State.ToString() != "Open")
                    {
                        conn.Open();
                    }
                    else { }
                    SqlDataReader dataReader = getCarsCommand.ExecuteReader();
                    List<int> carIDList = new List<int>();
                    while (dataReader.Read())
                    {
                        carIDList.Add(Convert.ToInt32(dataReader[vehicleID].ToString()));
                    }
                    dataReader.Close();
                    carIDComboBox.DataSource = carIDList;
                }
                else { }




            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void rentCarButton_Click(object sender, EventArgs e)
        {

            if (carIDComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("You did not select a vehicleID", "Error", MessageBoxButtons.OK);
                return;
            }
            else
            {
                //Get Bike/Car ID the customer wants to rent from the combobox
                int vehicleID = Convert.ToInt32(carIDComboBox.SelectedItem.ToString());
                availableVehicleDB availableVehicleDB = new availableVehicleDB();
                if(!availableVehicleDB.rentVehicle(vehicleID, rentCar , PersonID))
                {

                    MessageBox.Show("Could not Rent Car","Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            this.Close();

        }

        private void carModelIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (conn.State.ToString() != "Open")
                {
                    conn.Open();
                }
                else { }
                //Populate available vehicleID combobox 
                string commandText = "select * from " + availableVehicle + " where isRented=0 and " + vehicle + "ModelID = " + carModelIDComboBox.SelectedItem.ToString();

                SqlCommand Command = new SqlCommand(commandText, conn);
                SqlDataReader dataReader = Command.ExecuteReader();
                List<String> carIDList = new List<String>();
                while (dataReader.Read())
                {
                    carIDList.Add(dataReader[vehicleID].ToString());
                }

                carIDComboBox.DataSource = null;
                carIDComboBox.Items.Clear();
                carIDComboBox.DataSource = carIDList;
                dataReader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
