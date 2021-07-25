using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Coast_Busters
{
    class SubscriptionDB
    {
        private SqlConnection conn;
        public int addSubscription(Subscription sub)
        {
            Connection connection = new Connection();
            conn = connection.GetSqlConnection();
            string insertString = "insert into Subscriptions (SubscriptionTypeID,Status) values(" +
                sub.SubscriptionTypeID.ToString() + ",1)";
            SqlCommand insertCommand = new SqlCommand(insertString, conn);
            try
            {
                conn.Open();
           insertCommand.ExecuteNonQuery(); 
                string selectStatement =
                     "select ident_current('Subscriptions') FROM Subscriptions";
                SqlCommand selectCommand =
                    new SqlCommand(selectStatement, conn);
                return Convert.ToInt32(selectCommand.ExecuteScalar());
                 
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK);
                return -1;
            }
            finally
            {
                conn.Close();
            }
        }
        public int getSubscriptionType(int SubscriptionID)
        {

            Connection connection = new Connection();
            conn = connection.GetSqlConnection();
            string commandText = "select * from Subscriptions where SubscriptionID= "+ SubscriptionID;
            SqlCommand command = new SqlCommand(commandText, conn);
            try
            {
                conn.Open();
                SqlDataReader dataReader = command.ExecuteReader();
                dataReader.Read();
               // dataReader.Close();
                return Convert.ToInt32(dataReader["SubscriptionTypeID"].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                return -1;
            }
            finally
            {
                conn.Close();
            }
        }
        public int getAllowedNumberofRentedCars(int SubscriptionTypeID)
        {

            Connection connection = new Connection();
            conn = connection.GetSqlConnection();
            string commandText = "select * from SubscriptionTypes where SubscriptionTypeID= " + SubscriptionTypeID;
            SqlCommand command = new SqlCommand(commandText, conn);
            try
            {
                conn.Open();
                SqlDataReader dataReader = command.ExecuteReader();
                dataReader.Read();
                //dataReader.Close();
                return Convert.ToInt32(dataReader["NbAllowedRentedCars"].ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                return -1;
            }
            finally
            {
                conn.Close();
            }
        }
        
        public Boolean deleteSubscription(int subs)
        {
            Connection connection = new Connection();
            conn = connection.GetSqlConnection();
            string deleteStatement = "delete from Subscriptions where SubscriptionID= " + subs;
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
                MessageBox.Show(ex.Message, "Couldn't delete Subscription", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
