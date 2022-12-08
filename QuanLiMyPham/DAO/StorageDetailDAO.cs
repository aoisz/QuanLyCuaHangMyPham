using MySql.Data.MySqlClient;
using QuanLiMyPham.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace QuanLiMyPham.DAO
{
    internal class StorageDetailDAO
    {
        public DataTable GetDB()
        {
            DataTable data = new DataTable();
            try
            {
                String sql = "SELECT * FROM `chitietkho`";
                MySqlDataAdapter dataAdapter = MySQLConnection.ToQueryTable(sql);
                dataAdapter.Fill(data);
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
            return data;
        }

        public DataTable GetDetailById(String id)
        {
            DataTable data = new DataTable();
            try
            {
                String sql = "SELECT * FROM `chitietkho` WHERE MaKho = '" + id + "'";
                MySqlDataAdapter dataAdapter = MySQLConnection.ToQueryTable(sql);
                dataAdapter.Fill(data);
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
            return data;
        }

        public void UpdateQuantity(StorageDetailDTO dto)
        {
            try
            {
                String sql = "UPDATE `chitietkho` SET `SOLUONG`='" + dto.productQuantity + "'"
                            + " WHERE `MaKho`='" + dto.storageID + "'"
                            + " AND `MaSP`='" + dto.productID + "'";
                MySQLConnection.ToUpdate(sql);
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void InsertNewProduct(StorageDetailDTO dto)
        {
            try
            {
                string sql = "INSERT INTO `chitietkho` VALUE (" +
                    "'" + dto.storageID + "'," +
                    "'" + dto.storageID + "'," +
                    "'" + dto.productQuantity + "')";

                MySQLConnection.ToUpdate(sql);
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
