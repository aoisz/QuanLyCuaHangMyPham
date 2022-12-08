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
    internal class InputDetailDAO
    {
        public DataTable GetDB()
        {
            DataTable data = new DataTable();
            try
            {
                String sql = "SELECT * FROM `chitietphieunhap`";
                MySqlDataAdapter dataAdapter = MySQLConnection.ToQueryTable(sql);
                dataAdapter.Fill(data);
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
            return data;
        }
        public void AddData(InputDetailDTO dto)
        {
            try
            {
                string sql = "INSERT INTO `chitietphieunhap` VALUE (" +
                    "'" + dto.inputId + "'," +
                    "'" + dto.productId + "'," +
                    "'" + dto.price + "'," +
                    "'" + dto.quantity + "'," +
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
                string sql = "DELETE FROM `chitietphieunhap` WHERE MAPN = '" + id + "'";
                MySQLConnection.ToUpdate(sql);
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
