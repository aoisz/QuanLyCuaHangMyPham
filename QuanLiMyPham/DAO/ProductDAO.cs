using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using QuanLiMyPham.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiMyPham.DAO
{
    internal class ProductDAO
    {
        public DataTable GetDB()
        {
            DataTable data = new DataTable();
            try
            {
                String sql = "SELECT sanpham.*, SUM(chitietkho.SOLUONG) as SOLUONG " +
                            "FROM `sanpham`, `chitietkho` " + 
                            "WHERE sanpham.MA = chitietkho.MaSP " +
                            "GROUP BY chitietkho.MaSP";
                MySqlDataAdapter dataAdapter = MySQLConnection.ToQueryTable(sql);
                dataAdapter.Fill(data);
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
            return data;
        }
        public DataTable GetDataByStorageID(string storageID)
        {
            DataTable data = new DataTable();
            try
            {
                String sql = "SELECT sanpham.*, SUM(chitietkho.SOLUONG) as SOLUONG " +
                            "FROM `sanpham`, `chitietkho` " +
                            "WHERE sanpham.MA = chitietkho.MaSP " +
                            "AND chitietkho.MaKho = '" + storageID + "' " +
                            "GROUP BY chitietkho.MaSP";
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
                string sql = "DELETE FROM `chitietkho` WHERE MaSP =  '" + id + "'";
                MySQLConnection.ToUpdate(sql);
                sql = "DELETE FROM `sanpham` WHERE MA = '" + id + "'";
                MySQLConnection.ToUpdate(sql);
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void EditData(ProductDTO product)
        {
            try
            {
                string sql = "UPDATE `sanpham` SET " +
                    "sanpham.TEN = '" + product.name + "', " +
                    "sanpham.LOAIHANG = '" + product.type + "', " +
                    "sanpham.THANHPHAN = '" + product.ingredients + "', " +
                    "sanpham.NGAYSX = '" + product.mfgDate + "', " +
                    "sanpham.HANSD = '" + product.expDate + "', " +
                    "sanpham.DONGIA = " + product.price + ", " +
                    "sanpham.HINHANH = '" + product.img + "' " +
                    "WHERE sanpham.MA = '" + product.id + "'";
                MessageBox.Show(sql);
                MySQLConnection.ToUpdate(sql);
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public string getNewID()
        {
            string newId = "";
            string sql = "SELECT MA FROM `sanpham` ORDER BY MA DESC LIMIT 1";
            MySqlDataReader dr = MySQLConnection.ToQuery(sql);
            string id = "";
            while (dr.Read()) { id = dr.GetString("MA"); }
            id = id.Substring(id.Length - 2, 2);
            int intId = Int32.Parse(id);
            intId++;
            if (intId < 10)
            {
                id = "SP0";
            }
            else
            {
                id = "SP";
            }
            id += intId.ToString();
            return id;
        }

        public ProductDTO AddData(string name, string ingredients, string type, string mfgDate, string expDate, string production, string price, string img)
        {
            ProductDTO productDTO = new ProductDTO();
            try
            {
                string sql = "";

                productDTO.id = getNewID();
                productDTO.name = name;
                productDTO.type = type;
                productDTO.ingredients = ingredients;
                productDTO.mfgDate = mfgDate;
                productDTO.expDate = expDate;
                productDTO.production = production;
                productDTO.price = price;
                productDTO.img = img;

                sql = "INSERT INTO `sanpham`(MA, TEN, THANHPHAN, NGAYSX, HANSD, LOAIHANG, NSX, DONGIA, HINHANH) VALUES (" +
                    "'" + productDTO.id + "', " +
                    "'" + productDTO.name + "', " +
                    "'" + productDTO.ingredients + "', " +
                    "'" + productDTO.mfgDate + "', " +
                    "'" + productDTO.expDate + "', " +
                    "'" + productDTO.type + "', " +
                    "'" + productDTO.production + "', " +
                    "" + productDTO.price + ", " +
                    "'" + productDTO.img + "')";
                MySQLConnection.ToUpdate(sql);

                sql = "SELECT MA FROM `kho`";
                DataTable dataTable = new DataTable();
                MySQLConnection.ToQueryTable(sql).Fill(dataTable);
                List<string> stockList = new List<string>();
                foreach (DataRow row in dataTable.Rows)
                {
                    stockList.Add(row["MA"].ToString());
                }

                for(int i = 0; i < stockList.Count; i++)
                {
                    sql = "INSERT INTO `chitietkho` (MaKho, MaSP, SOLUONG) VALUES (" +
                           "'" + stockList[i] + "', " +
                           "'" + productDTO.id + "', " +
                           "" + 0 + ")";
                    MySQLConnection.ToUpdate(sql);
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
            MySQLConnection.CloseConnection();
            return productDTO;
        }
    }
}
