using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Coast_Busters
{
    class PersonDB
    {
        private static SqlConnection conn;
        private static Connection connection;

        public static int addPerson(Person addThisPerson)
        {
            connection = new Connection();
            conn = connection.GetSqlConnection();
            SqlCommand insertCommand = new SqlCommand() ;
            string insertString;
            if (addThisPerson.isCustomer)
            {
                 insertString = "insert into People (FirstName,LastName,DateOfBirth,Address,SubscriptionID,AccidentsMade,NbOfRentedCars,isACustomer) values" +
                    " (@firstName,@lastName,@DOB,@Address,@SubscriptionID,0,0,1)";
                insertCommand.Parameters.AddWithValue("@firstName", addThisPerson.firstName);
                insertCommand.Parameters.AddWithValue("@lastName", addThisPerson.lastName);
                insertCommand.Parameters.AddWithValue("@DOB", addThisPerson.DOB);
                insertCommand.Parameters.AddWithValue("@Address", addThisPerson.address);
                insertCommand.Parameters.AddWithValue("@SubscriptionID", addThisPerson.subscriptionID);
            }
            else
            {
                 insertString = "insert into People (FirstName,LastName,DateOfBirth,Address,isACustomer, SubscriptionID) values" +
                   " (@firstName,@lastName,@DOB,@Address,0, @SubscriptionID)";
                insertCommand.Parameters.AddWithValue("@firstName", addThisPerson.firstName);
                insertCommand.Parameters.AddWithValue("@lastName", addThisPerson.lastName);
                insertCommand.Parameters.AddWithValue("@DOB", addThisPerson.DOB);
                insertCommand.Parameters.AddWithValue("@Address", addThisPerson.address);
                insertCommand.Parameters.AddWithValue("@SubscriptionID", addThisPerson.subscriptionID);
            }
            try
            {
                conn.Open();

                insertCommand.CommandText = insertString;
                insertCommand.Connection = conn;
                insertCommand.ExecuteNonQuery();
                string selectStatement =
                     "select ident_current('People') FROM People";
                SqlCommand selectCommand =
                    new SqlCommand(selectStatement, conn);
                return Convert.ToInt32(selectCommand.ExecuteScalar());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
            finally
            {
                conn.Close();
            }



        }
        public int getNbRentedCars(int personID)
        {

            connection = new Connection();
            conn = connection.GetSqlConnection();
            string getcustomer = "select * from People where PersonID=" + personID;
            SqlCommand getNbVehicles = new SqlCommand(getcustomer, conn);

            try
            {
                conn.Open();
                SqlDataReader dataReader = getNbVehicles.ExecuteReader();
                dataReader.Read();
                int nbRented = Convert.ToInt32(dataReader["NbOfRentedCars"].ToString());
                return nbRented;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return -1;
            }
            finally
            {
                conn.Close();
            }
        }
        public Boolean isCustomer(int personID)
        {
            connection = new Connection();
            conn = connection.GetSqlConnection();
            string getcustomer="select * from LoginCredentials where PersonID=" +personID;
            SqlCommand checkCommand = new SqlCommand(getcustomer,conn);

            try
            {
                conn.Open();
                SqlDataReader dataReader=checkCommand.ExecuteReader();
                dataReader.Read();
                Boolean isCustomer = Convert.ToBoolean(dataReader["isCustomer"].ToString());
                return isCustomer;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public int getSubscriptionID(int personID)

        {

            connection = new Connection();
            conn = connection.GetSqlConnection();
            string getcustomer = "select * from People where PersonID=" + personID;
            SqlCommand getNbVehicles = new SqlCommand(getcustomer, conn);

            try
            {
                conn.Open();
                SqlDataReader dataReader = getNbVehicles.ExecuteReader();
                dataReader.Read();
                int nbRented = Convert.ToInt32(dataReader["SubscriptionID"].ToString());
                return nbRented;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally
            {
                conn.Close();
            }
        }

        public Boolean updateNbRentedCars(int personID)
        {
            connection = new Connection();
            conn = connection.GetSqlConnection();

            string addrentedtoPersonCommand = "update People set NbOfRentedCars=NbOfRentedCars+1 where PersonID= " + personID;

            SqlCommand updateNb = new SqlCommand(addrentedtoPersonCommand, conn);
            try
            {
                conn.Open();
                updateNb.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Could Not update NbRentedCars for person!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public Boolean reportAccident(int PersonID)
        {
            string updateAccidentCommand = "update People set AccidentsMade= AccidentsMade +1 where PersonID= " + PersonID;
            Connection Conn = new Connection();
            SqlCommand command = new SqlCommand(updateAccidentCommand, conn);
            try
            {
                conn.Open();
                if (Convert.ToInt32(command.ExecuteNonQuery()) <= 0)
                {
                    MessageBox.Show("Update Failed", "Error", MessageBoxButtons.OK);
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

        public Boolean deletePeople(int PersonID)
        {

            Connection connection = new Connection();
            conn = connection.GetSqlConnection();
            string deleteStatement = "delete from People where PersonID= " + PersonID;
            SqlCommand command = new SqlCommand(deleteStatement, conn);
            try
            {
                conn.Open();
                if (command.ExecuteNonQuery() == 0)
                {
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Couldn't delete Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
    }

}
