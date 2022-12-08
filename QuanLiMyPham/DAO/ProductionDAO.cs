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
    internal class ProductionDAO
    {
        public DataTable GetDB()
        {
            DataTable data = new DataTable();
            try
            {
                String sql = "SELECT * FROM `nhasanxuat`";
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
            try
            {
                string sql = "DELETE FROM `nhasanxuat` WHERE MA = '" + id + "'";
                MySQLConnection.ToUpdate(sql);
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void EditData(ProductionDTO production)
        {
            try
            {
                string sql = "UPDATE `nhasanxuat` SET " +
                    "TEN = '" + production.name + "', " +
                    "QUOCGIA = '" + production.country + "'" +
                    "WHERE MA = '" + production.id + "'";
                MySQLConnection.ToUpdate(sql);
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public string GetNewId()
        {
            string sql = "SELECT MA FROM nhasanxuat ORDER BY MA DESC LIMIT 1";
            MySqlDataReader dr = MySQLConnection.ToQuery(sql);
            string id = "";
            while (dr.Read()) { id = dr.GetString("MA"); }
            id = id.Substring(id.Length - 2, 2);
            int intId = Int32.Parse(id);
            intId++;
            if (intId < 10)
            {
                id = "SX0";
            }
            else
            {
                id = "SX";
            }
            id += intId.ToString();
            return id;
        }

        public void AddData(ProductionDTO productionDTO)
        {
            try
            {
                string sql = "INSERT INTO `nhasanxuat` VALUE (" +
                             "'" + productionDTO.id + "'," +
                             "'" + productionDTO.name + "'," +
                             "'" + productionDTO.country + "')";

                MySQLConnection.ToUpdate(sql);
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
            MySQLConnection.CloseConnection();
        } 
    }
}
