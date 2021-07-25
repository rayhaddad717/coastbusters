using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Coast_Busters
{
    class Connection
    {
        private string connectionName { get; set; }
        public SqlConnection GetSqlConnection()
        {
            string sqlCommand = "Data Source=localhost\\SQLEXPRESS; Initial Catalog= 'Coast Busters';Integrated Security=True";
            SqlConnection conn = new SqlConnection(sqlCommand);
            return conn;
        }


    }
}
