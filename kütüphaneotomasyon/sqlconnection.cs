using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace kütüphaneotomasyon
{
    internal class sqlconnection
    {
       public static SqlConnection connection = new SqlConnection("Data Source=dbktp.database.windows.net;Initial Catalog=db_kutuphane;User ID=dbktp;Password=D123123d");

        public static void CheckConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public static void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
