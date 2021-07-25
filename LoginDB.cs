using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Coast_Busters
{
    class LoginDB
    {
        private SqlConnection conn;
        public int getPersonID(Login login)
        {

            Connection connection = new Connection();
            conn = connection.GetSqlConnection();
            string selectString = "select * from LoginCredentials where LoginID= " + login.LoginID;
            SqlDataReader dataReader;
            SqlCommand getIDCommand = new SqlCommand(selectString, conn);
            try
            {
                conn.Open();
                dataReader = getIDCommand.ExecuteReader();
                dataReader.Read();
                int PersonID = Convert.ToInt32(dataReader["PersonID"].ToString());
                if (PersonID > 0)
                {
                    return PersonID;
                }
                else
                {
                    MessageBox.Show("This user does not exist!", "User not found");
                    return -1;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
            finally
            {
                conn.Close();
            }
        }
        public int addLogin(Login login)
        {
            Connection connection = new Connection();
            conn = connection.GetSqlConnection();
            string insertString = "insert into LoginCredentials (PersonID,Password,isCustomer) values(" +
                login.PersonID.ToString() + ",\'" + login.password + "\'," + (Convert.ToInt32(login.isCustomer)).ToString() + ")";
            SqlCommand insertCommand = new SqlCommand(insertString, conn);
            try
            {
                conn.Open();
                insertCommand.ExecuteNonQuery();

                string selectStatement =
                     "select ident_current('LoginCredentials') FROM LoginCredentials";
                SqlCommand selectCommand =
                    new SqlCommand(selectStatement, conn);
                return Convert.ToInt32(selectCommand.ExecuteScalar());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
            finally
            {
                conn.Close();
            }
        }
        public bool isCorrectLogin(int LoginID, string password)
        {
            Connection connection = new Connection();
            conn = connection.GetSqlConnection();
            SqlCommand command;
            string selectStatement = "select password from LoginCredentials where loginID=" + LoginID.ToString();
            try
            {
                conn.Open();
                command = new SqlCommand(selectStatement, conn);
                SqlDataReader dataReader = command.ExecuteReader();
                dataReader.Read();
                if (password == dataReader["Password"].ToString())
                { return true; }
                else
                    return false;


            }
            catch (Exception ex)
            {
                if (ex.Message == "Invalid attempt to read when no data is present.")
                {

                    MessageBox.Show("LoginID not fonud", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);

                }
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public Boolean deleteLogin(int LoginID)
        {
            Connection connection = new Connection();
            conn = connection.GetSqlConnection();
            string deleteStatement = "delete from LoginCredentials where loginID= " + LoginID;
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Couldn't delete Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
