using MySql.Data.MySqlClient;
using MySql.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiMyPham
{
    public static class MySQLConnection
    {
        static MySqlConnection connection;
        static MySqlDataAdapter dataAdapter;
        static MySqlDataReader dataReader;
        static MySqlCommand command;
        static string connectionString = "server=127.0.0.1;uid=root;pwd=;database=db;CharSet=utf8";
        public static MySqlDataAdapter ToQueryTable(string sql)
        {
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                command = new MySqlCommand(sql, connection);
                dataAdapter = new MySqlDataAdapter(command);
                return dataAdapter;
            }
            catch(MySqlException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public static void ToUpdate(string sql)
        {
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                command = new MySqlCommand(sql, connection);
                command.ExecuteNonQuery();
            }
            catch(MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static MySqlDataReader ToQuery(String sql)
        {
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                command = new MySqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                return dataReader;
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }

        }

        public static void CloseConnection()
        {
            connection.Close();
        }
    }
}
