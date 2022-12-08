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
    internal class RoleDetailDAO
    {
        public DataTable GetDB()
        {
            DataTable data = new DataTable();
            try
            {
                String sql = "SELECT * FROM `chitietquyen`";
                MySqlDataAdapter dataAdapter = MySQLConnection.ToQueryTable(sql);
                dataAdapter.Fill(data);
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
            return data;
        }

        public void DelData(string roleId)
        {
            try
            {
                string sql = "DELETE FROM `chitietquyen` WHERE MAQ = '" + roleId + "'";
                MySQLConnection.ToUpdate(sql);
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void EditData(RoleDetailDTO roleDetail)
        {
            try
            {
                string sql = "UPDATE `chitietquyen` SET " +
                    "CHUCNANG = '" + roleDetail.function + "' " +
                    "WHERE MAQ = '" + roleDetail.roleId + "' AND TENBANG = '" + roleDetail.tableName + "'";
                MessageBox.Show(sql);
                MySQLConnection.ToUpdate(sql);
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public RoleDetailDTO AddData( string tableName, string function, string roleId)
        {
            RoleDetailDTO roleDetailDTO = new RoleDetailDTO();
            try
            {
                roleDetailDTO.tableName = tableName;
                roleDetailDTO.function = function;
                roleDetailDTO.roleId = roleId;

                string sql = "INSERT INTO `chitietquyen` (TENBANG, CHUCNANG, MAQ) VALUES (" +
                    "'" + roleDetailDTO.tableName + "'," +
                    "'" + roleDetailDTO.function + "'," +
                    "'" + roleDetailDTO.roleId + "')";

                MySQLConnection.ToUpdate(sql);
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
            MySQLConnection.CloseConnection();
            return roleDetailDTO;
        }
    }
}
