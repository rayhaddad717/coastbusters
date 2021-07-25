using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Coast_Busters
{
    class vehicleModelDB

    {

        private string vehicle;
        private string availableVehicle;
        private string vehicleModel;
        private string vehicleIDString;
        public Boolean updateNbAvailableVehicles(int vehicleModelID, Boolean isCar,Boolean toRemoveOne)
        {
            //RemoveOne will decrease the nb of available vehicles for this model by 1, is false it will add 1
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

            //Update the number of available cars for this car/bike model
            string commandText;
            if (toRemoveOne)
            {
                commandText = "update " + vehicleModel + " set Nb" + vehicle + "sLeft=Nb" + vehicle + "sLeft-1 where " + vehicle + "ModelID= " + vehicleModelID;
            }
            else
            {
                commandText = "update " + vehicleModel + " set Nb" + vehicle + "sLeft=Nb" + vehicle + "sLeft+1 where " + vehicle + "ModelID= " + vehicleModelID;

            }
            SqlCommand command = new SqlCommand(commandText, conn);
            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                return true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Could not get VehicleModelID", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conn.Close();
            }


        }
    }
}
