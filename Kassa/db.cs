using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Contexts;
using System.Data.SqlClient;

namespace Databases
{
    public partial class db
    {
        MySqlConnection connect = new MySqlConnection("server=185.137.235.119;username=vh11587_prison;password=sZ5qP4dW5h;database=vh11587_prison");

        public void openConnection()
        {
            if (connect.State == System.Data.ConnectionState.Closed)
            {
                connect.Open();
            }
        }

        public void closeConnection()
        {
            if (connect.State == System.Data.ConnectionState.Open)
            {
                connect.Close();
            }
        }

        public MySqlConnection getConnection()
        {
            return connect;
        }
    }
}