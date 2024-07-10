using MySql.Data.MySqlClient;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library2
{
    internal class ClassDataBase
    {

        // MySqlConnection connection = new MySqlConnection("server=");
        public NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=libraryDataBase;User Id=postgres;Password=1234;");//если не заработает, то ставим ;

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed) {
            connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public NpgsqlConnection getConnection()
        {
            return connection;
        }

    }
}
