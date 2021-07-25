using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Coast_Busters
{
    class availableVehicleDB
    {
        public int vehicleID;
        public int vehicleModelID;
        public bool isRented;
        public int rentedByPersonID;
        public string rentedDate;
        public Boolean needsRepair;
        public string color;
        public string condition;

        private string vehicle;
        private string availableVehicle;
        private string vehicleModel;
        private string vehicleIDString;

        public Boolean rentVehicle(int vehicleID, Boolean isCar,int PersonID)
       {
            Connection Conn = new Connection();
            SqlConnection conn = Conn.GetSqlConnection();
            if (!isCar)
            {
                //if The person wants to rent a bike then adjust the entire form to display bike info
                vehicle = "Bike";
                vehicleModel = "BikeModels";
                availableVehicle = "AvailableBikes";
                vehicleIDString = "BikeID";
            }
            else
            {
                vehicle = "Car";
                availableVehicle = "AvailableCars";
                vehicleModel = "CarModels";
                vehicleIDString = "CarID";
            }

            string rentCarCommandText = "update " + availableVehicle + " set isRented=1 where " + vehicleIDString + " = " + vehicleID
                + " update " + availableVehicle + " set RentedByPersonID= " + PersonID + " where " + vehicleIDString + " = " + vehicleID +
                " update " + availableVehicle + " set RentedDate= " + "\' " + DateTime.Now.ToString() + "\'" + " where " + vehicleIDString + " = " + vehicleID;

            SqlCommand rentCarcommand = new SqlCommand(rentCarCommandText, conn);
            try
            {
                conn.Open();
                //Check is the customer has reached his rent limit for his current subscription

                PersonDB personDB = new PersonDB();
                int nbRentedCars = personDB.getNbRentedCars(PersonID);
                int SubscriptionID = personDB.getSubscriptionID(PersonID);

                SubscriptionDB subscriptionDB = new SubscriptionDB();
                int SubscriptionTypeID = subscriptionDB.getSubscriptionType(SubscriptionID);
                int nbAllowedRentedCars = subscriptionDB.getAllowedNumberofRentedCars(SubscriptionTypeID);

                if (nbAllowedRentedCars <= nbRentedCars)
                {
                    MessageBox.Show("You have reached the maximum number of rented cars at a time for your plan.\nPlease return any vehicles and try again.", "Rented Vehicles Limit", MessageBoxButtons.OK);

                }
                else
                {
                    //Update the availableCars/Bikes table to rent a new Car/Bike
                    if (rentCarcommand.ExecuteNonQuery() <= 0)
                    {
                        //If zero rows were affected this means no update was made and therefore an error occured
                        MessageBox.Show("Rent Failed", "Error", MessageBoxButtons.OK);
                    }
                    else
                    {

                        int vehicleModelID = getVehicleModelID(vehicleID, isCar);
                        vehicleModelDB vehicleModelDB = new vehicleModelDB();
                        vehicleModelDB.updateNbAvailableVehicles(vehicleModelID, isCar,true);


                        //Update the nb of Rented Cars for this Customer
                        personDB.updateNbRentedCars(PersonID);


                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Could not Rent Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public int getVehicleModelID(int vehicleID, Boolean isCar)
        {
            if (!isCar)
            {
                //if The person wants to rent a bike then adjust the entire form to display bike info
                vehicle = "Bike";
                vehicleModel = "BikeModels";
                availableVehicle = "AvailableBikes";
                vehicleIDString = "BikeID";
            }
            else
            {
                vehicle = "Car";
                availableVehicle = "AvailableCars";
                vehicleModel = "CarModels";
                vehicleIDString = "CarID";
            }
            Connection Conn = new Connection();
            SqlConnection conn = Conn.GetSqlConnection();
            //Get the Car or Bike ID from Car/BikeModelID i'm about to rent to update nbVehiclesLeft
            string getModelID = "select * from " + availableVehicle + " where " + vehicleIDString + " = " + vehicleID;
            SqlCommand getModelCommand = new SqlCommand(getModelID, conn);
            try
            {
                conn.Open();
                SqlDataReader dataReader = getModelCommand.ExecuteReader();
                dataReader.Read();
                int vehicleModel = Convert.ToInt32(dataReader[vehicle + "ModelID"].ToString());
                dataReader.Close();
                return vehicleModel;
            }



            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Could not get VehicleModelID", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return -1;
            }
            finally
            {
                conn.Close();
            }
        }

        public Boolean reportDamaged(int vehicleID,Boolean isCar)
        {

            if (!isCar)
            {
                //if The person wants to rent a bike then adjust the entire form to display bike info
                vehicle = "Bike";
                vehicleModel = "BikeModels";
                availableVehicle = "AvailableBikes";
                vehicleIDString = "BikeID";
            }
            else
            {
                vehicle = "Car";
                availableVehicle = "AvailableCars";
                vehicleModel = "CarModels";
                vehicleIDString = "CarID";
            }
            string damagedCommandText = "update " + availableVehicle + " set NeedsRepair=1 where " + vehicleIDString + " = " + vehicleID;
            Connection Conn = new Connection();
            SqlConnection conn = Conn.GetSqlConnection();
            SqlCommand command = new SqlCommand(damagedCommandText, conn);
            command.CommandText = damagedCommandText;
            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in reporting damaged vehicle", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public Boolean returnVehicle(int vehicleID,Boolean isCar, int PersonID,string condition)
        {
            if (!isCar)
            {
                //if The person wants to rent a bike then adjust the entire form to display bike info
                vehicle = "Bike";
                vehicleModel = "BikeModels";
                availableVehicle = "AvailableBikes";
                vehicleIDString = "BikeID";
            }
            else
            {
                vehicle = "Car";
                availableVehicle = "AvailableCars";
                vehicleModel = "CarModels";
                vehicleIDString = "CarID";
            }
            Connection Conn = new Connection();
            SqlConnection conn = Conn.GetSqlConnection();
            string returnCommandText = "update " + availableVehicle + " set isRented=0, RentedByPersonID= NULL, RentedDate=NULL,Condition=@cond where " + vehicleIDString + " = " + vehicleID;
            SqlCommand command = new SqlCommand(returnCommandText, conn);
            command.Parameters.AddWithValue("@cond", condition);
            try
            {
                conn.Open();
                command.CommandText = returnCommandText;
                //Update the Vehicle to not be Currently rented
                if (command.ExecuteNonQuery() <= 0)
                {
                    MessageBox.Show("Return Failed", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    //Update the nb of vehicles the customer currently rents
                    returnCommandText = "update People set NbOfRentedCars=NbOfRentedCars-1 where PersonID= " + PersonID;
                    command.CommandText = returnCommandText;
                    command.ExecuteNonQuery();

                    //Get VehicleModelID of the car the customer wants to return
                    availableVehicleDB availableVehiclee =new availableVehicleDB();
                    int vehicleModelID = availableVehiclee.getVehicleModelID(vehicleID, isCar);

                    vehicleModelDB vehicleModel = new vehicleModelDB();
                    vehicleModel.updateNbAvailableVehicles(vehicleModelID, isCar, false);

                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
