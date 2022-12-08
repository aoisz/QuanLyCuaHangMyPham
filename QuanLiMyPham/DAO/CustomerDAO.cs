using MySql.Data.MySqlClient;
using QuanLiMyPham.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLiMyPham.DAO
{
    internal class CustomerDAO
    {
        public DataTable GetDB()
        {
            DataTable data = new DataTable();
            try
            {
                String sql = "SELECT * FROM `khachhang`";
                MySqlDataAdapter dataAdapter = MySQLConnection.ToQueryTable(sql);
                dataAdapter.Fill(data);
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
            return data;
        }

        public void DelData(string id)
        {
            try {
                string sql = "DELETE FROM `khachhang` WHERE MAKH = '" + id + "'";
                MySQLConnection.ToUpdate(sql);
            }
            catch(MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void EditData(CustomerDTO customer)
        {
            try
            {
                string sql = "UPDATE `khachhang` SET " +
                    "HO = '" + customer.lastName + "', " +
                    "TEN = '" + customer.firstName + "', " +
                    "SDT = '" + customer.phoneNum + "'" +
                    "WHERE MAKH = '" + customer.id + "'";
                MySQLConnection.ToUpdate(sql);
            }
            catch(MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public string GetNewId()
        {
            string sql = "SELECT MAKH FROM khachhang ORDER BY MAKH DESC LIMIT 1";
            MySqlDataReader dr = MySQLConnection.ToQuery(sql);
            string id = "";
            while (dr.Read()) { id = dr.GetString("MAKH"); }
            id = id.Substring(id.Length - 2, 2);
            int intId = Int32.Parse(id);
            intId++;
            if (intId < 10)
            {
                id = "KH0";
            }
            else
            {
                id = "KH";
            }
            id += intId.ToString();
            return id;
        }

        public void AddData(CustomerDTO customerDTO)
        {
            try
            {
                string sql = "INSERT INTO `khachhang` VALUE (" +
                            "'" + customerDTO.id + "'," +
                            "'" + customerDTO.lastName + "'," +
                            "'" + customerDTO.firstName + "'," +
                            "'" + customerDTO.phoneNum + "')";
                MySQLConnection.ToUpdate(sql);
            }
            catch(MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
            MySQLConnection.CloseConnection();
        }
    }
}
