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
    internal class ReceiptDetailDAO
    {
        public DataTable GetDB()
        {
            DataTable data = new DataTable();
            try
            {
                String sql = "SELECT * FROM `chitiethoadon`";
                MySqlDataAdapter dataAdapter = MySQLConnection.ToQueryTable(sql);
                dataAdapter.Fill(data);
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
            return data;
        }

        public void DelData(string receiptId)
        {
            try
            {
                string sql = "DELETE FROM `chitiethoadon` WHERE MAHD = '" + receiptId + "'";
                MySQLConnection.ToUpdate(sql);
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void EditData(ReceiptDetailDTO receiptDetail)
        {
            try
            {
                string sql = "UPDATE `chitiethoadon` SET " +
                    "DONGIA = '" + receiptDetail.price + "', " +
                    "SOLUONG = '" + receiptDetail.quantity + "', " +
                    "THANHTIEN = '" + receiptDetail.totalPrice + "', " +
                    "WHERE MAHD = '" + receiptDetail.receiptId + "' AND " +
                          "MASP = '" + receiptDetail.productId + "'";
                MySQLConnection.ToUpdate(sql);
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void AddData(ReceiptDetailDTO dto)
        {
            try
            {
                string sql = "INSERT INTO `chitiethoadon` VALUE (" +
                    "'" + dto.receiptId + "'," +
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
    }
}
