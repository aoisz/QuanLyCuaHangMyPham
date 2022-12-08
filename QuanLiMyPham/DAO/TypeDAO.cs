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
    internal class TypeDAO
    {
        public DataTable GetDB()
        {
            DataTable data = new DataTable();
            try
            {
                String sql = "SELECT * FROM `loaihang`";
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
                string sql = "DELETE FROM `loaihang` WHERE MA = '" + id + "'";
                MySQLConnection.ToUpdate(sql);
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void EditData(TypeDTO type)
        {
            try
            {
                string sql = "UPDATE `loaihang` SET " +
                            "TEN = '" + type.name + "' " +
                            "WHERE MA = '" + type.id + "'";
                MySQLConnection.ToUpdate(sql);
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        
        public String FillId()
        {
            string id = "";
            try
            {
                string sql = "SELECT MA FROM loaihang ORDER BY MA DESC LIMIT 1";
                MySqlDataReader dr = MySQLConnection.ToQuery(sql);
                while (dr.Read()) { id = dr.GetString("MA"); }
                id = id.Substring(id.Length - 2, 2);
                int intId = Int32.Parse(id);
                intId++;
                if (intId < 10)
                {
                    id = "ML0";
                }
                else
                {
                    id = "ML";
                }
                id += intId.ToString();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
            return id;
        }
        public void AddData(TypeDTO typeDTO)
        {
            try
            {
                string sql = "INSERT INTO `loaihang` VALUE (" +
                            "'" + typeDTO.id + "'," +
                            "'" + typeDTO.name + "')";

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
