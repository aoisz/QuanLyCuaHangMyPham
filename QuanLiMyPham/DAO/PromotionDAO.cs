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
    internal class PromotionDAO
    {
        public DataTable GetDB()
        {
            DataTable data = new DataTable();
            try
            {
                String sql = "SELECT * FROM `ctkhuyenmai`";
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
                string sql = "DELETE FROM `ctkhuyenmai` WHERE MA = '" + id + "'";
                MySQLConnection.ToUpdate(sql);
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void EditData(PromotionDTO promotion)
        {
            try
            {
                string sql = "UPDATE `hoadon` SET " +
                    "TEN = '" + promotion.name + "', " +
                    "TIENKM = '" + promotion.discount + "', " +
                    "MUCTOITHIEU = '" + promotion.minPrice + "', " +
                    "MUCTOIDA = '" + promotion.maxPrice + "', " +
                    "WHERE MA = '" + promotion.id + "'";
                MySQLConnection.ToUpdate(sql);
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public string GetNewID()
        {
            string sql = "SELECT MA FROM `ctkhuyenmai` ORDER BY MA DESC LIMIT 1";
            MySqlDataReader dr = MySQLConnection.ToQuery(sql);
            string id = "";
            while (dr.Read()) { id = dr.GetString("MA"); }
            id = id.Substring(id.Length - 2, 2);
            int intId = Int32.Parse(id);
            intId++;
            if (intId < 10)
            {
                id = "KM0";
            }
            else
            {
                id = "KM";
            }
            id += intId.ToString();
            return id;
        }
        public void AddData(PromotionDTO dto)
        {
            try
            {
                string sql = "INSERT INTO `ctkhuyenmai` VALUE (" +
                    "'" + dto.id + "'," +
                    "'" + dto.name + "'," +
                    "'" + dto.discount + "'," +
                    "'" + dto.minPrice + "'," +
                    "'" + dto.maxPrice + "')";

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
