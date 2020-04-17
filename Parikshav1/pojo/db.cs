using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
namespace Parikshav1.pojo
{
    class db
    {
       
            // the connection
            
            private MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ConnectionString);


            // create a function to open the connection
            public void openConnection()
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
            }

            // create a function to close the connection
            public void closeConnection()
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            // create a function to return the connection
            public MySqlConnection getConnection()
            {
                return connection;
            }
        
    }
}
