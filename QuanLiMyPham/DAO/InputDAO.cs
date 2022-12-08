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
    internal class InputDAO
    {
        public DataTable GetDB()
        {
            DataTable data = new DataTable();
            try
            {
                String sql = "SELECT * FROM `phieunhap`";
                MySqlDataAdapter dataAdapter = MySQLConnection.ToQueryTable(sql);
                dataAdapter.Fill(data);
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
            return data;
        }

        public string GetNewID()
        {
            string sql = "SELECT MA FROM `phieunhap` ORDER BY MA DESC LIMIT 1";
            MySqlDataReader dr = MySQLConnection.ToQuery(sql);
            string id = "";
            while (dr.Read()) { id = dr.GetString("MA"); }
            id = id.Substring(id.Length - 2, 2);
            int intId = Int32.Parse(id);
            intId++;
            if (intId < 10)
            {
                id = "PN0";
            }
            else
            {
                id = "PN";
            }
            id += intId.ToString();
            return id;
        }
        public void AddData(InputDTO dto)
        {
            try
            {
                string sql = "INSERT INTO `phieunhap` VALUE (" +
                    "'" + dto.id + "'," +
                    "'" + dto.storageID + "'," +
                    "'" + dto.employeeId + "'," +
                    "'" + dto.date + "'," +
                    "'" + dto.totalPrice + "')";

                MySQLConnection.ToUpdate(sql);
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
            MySQLConnection.CloseConnection();
        }
        public void DelData(string id)
        {
            try
            {
                string sql = "DELETE FROM `phieunhap` WHERE MA = '" + id + "'";
                MySQLConnection.ToUpdate(sql);
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
