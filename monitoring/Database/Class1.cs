using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Database
{
    public class Class1
    {
        string connctionString = string.Format(
               "Server={0};Port={1};Database={2};Uid={3};Pwd={4};" +
               "Connection Timeout=3;CharSet=utf8;SslMode=None;",
               "localhost",
               "3306",
               "yeonoodb",
               "root",
               "tlaqlwm2174");
        MySqlConnection connection = new MySqlConnection(connctionString);
            try
            {
                connection.Open();
                return connection;
            }
            catch
            {
                return null;
            }
    }
}