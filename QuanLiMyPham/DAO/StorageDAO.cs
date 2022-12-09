using MySql.Data.MySqlClient;
using QuanLiMyPham.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiMyPham.DAO
{
    internal class StorageDAO
    {
        public DataTable GetDB()
        {
            DataTable data = new DataTable();
            try
            {
                String sql = "SELECT * FROM `kho`";
                MySqlDataAdapter dataAdapter = MySQLConnection.ToQueryTable(sql);
                dataAdapter.Fill(data);
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
            return data;
        }
        public String FillId()
        {
            string newId = "";
            string sql = "SELECT MA FROM `kho` ORDER BY MA DESC LIMIT 1";
            MySqlDataReader dr = MySQLConnection.ToQuery(sql);
            string id = "";
            while (dr.Read()) { id = dr.GetString("MA"); }
            id = id.Substring(id.Length - 2, 2);
            int intId = Int32.Parse(id);
            intId++;
            if (intId < 10)
            {
                id = "K0";
            }
            else
            {
                id = "K";
            }
            id += intId.ToString();
            return id;
        }
        public void AddData(StorageDTO storageDTO)
        {
            try
            {
                string sql = "INSERT INTO `kho` VALUE (" +
                            "'" + storageDTO.id + "'," +
                            "'" + storageDTO.name + "')";

                MySQLConnection.ToUpdate(sql);
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
            MySQLConnection.CloseConnection();
        }
        public void EditData(StorageDTO storage)
        {
            try
            {
                string sql = "UPDATE `chitietkho` SET " +
                            "TEN = '" + storage.name + "' " +
                            "WHERE MA = '" + storage.id + "'";
                MySQLConnection.ToUpdate(sql);
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void DelData(string id)
        {
            try
            {
                string sql = "DELETE FROM `kho` WHERE MA = '" + id + "'";
                MySQLConnection.ToUpdate(sql);
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
