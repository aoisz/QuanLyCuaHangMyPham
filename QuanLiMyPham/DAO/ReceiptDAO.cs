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
    internal class ReceiptDAO
    {
        public DataTable GetDB()
        {
            DataTable data = new DataTable();
            try
            {
                String sql = "SELECT * FROM `hoadon`";
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
                string sql = "DELETE FROM `hoadon` WHERE MA = '" + id + "'";
                MySQLConnection.ToUpdate(sql);
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void EditData(ReceiptDTO receipt)
        {
            try
            {
                string sql = "UPDATE `hoadon` SET " +
                    "MANV = '" + receipt.employeeId + "', " +
                    "MAKH = '" + receipt.customerId + "', " +
                    "NGAY = '" + receipt.date + "', " +
                    "TONGTIEN = '" + receipt.totalPrice + "', " +
                    "MACTKM = '" + receipt.promotionId + "', " +
                    "TONGTIENSAUKM = '" + receipt.afterDiscountPrice + "' " +
                    "WHERE MA = '" + receipt.id + "'";
                MySQLConnection.ToUpdate(sql);
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public string GetNewID()
        {
            string sql = "SELECT MA FROM `hoadon` ORDER BY MA DESC LIMIT 1";
            MySqlDataReader dr = MySQLConnection.ToQuery(sql);
            string id = "";
            while (dr.Read()) { id = dr.GetString("MA"); }
            id = id.Substring(id.Length - 2, 2);
            int intId = Int32.Parse(id);
            intId++;
            if (intId < 10)
            {
                id = "HD0";
            }
            else
            {
                id = "HD";
            }
            id += intId.ToString();
            return id;
        }
        public void AddData(ReceiptDTO dto)
        {
            try
            {
                string sql = "INSERT INTO `hoadon` VALUE (" +
                    "'" + dto.id + "'," +
                    "'" + dto.employeeId + "'," +
                    "'" + dto.customerId + "'," +
                    "'" + DateTime.Parse(dto.date).ToString("yyyy-MM-dd") + "'," +
                    "'" + dto.totalPrice + "'," +
                    "'" + dto.promotionId + "'," +
                    "'" + dto.afterDiscountPrice + "')";

                MySQLConnection.ToUpdate(sql);
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
            MySQLConnection.CloseConnection();
        }

        public DataTable GetPriceByMonthYear()
        {
            DataTable data = new DataTable();
            try
            {
                String sql = "SELECT MONTH(hoadon.NGAY) as 'THANG', YEAR(hoadon.NGAY) as 'NAM', SUM(hoadon.TONGTIENSAUKM) as 'THANHTIEN' " +
                    "FROM `hoadon` " +
                    "GROUP BY YEAR(hoadon.NGAY), MONTH(hoadon.NGAY)";
                MySqlDataAdapter dataAdapter = MySQLConnection.ToQueryTable(sql);
                dataAdapter.Fill(data);
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
            return data;
        }
    }
}
