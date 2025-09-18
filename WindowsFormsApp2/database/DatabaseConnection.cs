using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2.database
{
    class DatabaseConnection
    {

        public static MySqlConnection GetConnection(
                string server = "localhost",
                string database = "testdb",
                string user = "root",
                string password = "root",
                string port = "3306"
            )
        {
            
            return new MySqlConnection($"Server={server};Database={database};User={user};Password={password};Port={port};");
        }
    }
}
