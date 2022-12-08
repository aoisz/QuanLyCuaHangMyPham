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
    internal class AccountDAO
    {
        public DataTable GetDB()
        {
            DataTable data = new DataTable();
            try
            {
                String sql = "SELECT * FROM `taikhoan`";
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
                string sql = "DELETE FROM `taikhoan` WHERE MA = '" + id + "'";
                MySQLConnection.ToUpdate(sql);
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void EditData(AccountDTO account)
        {
            try
            {
                string sql = "UPDATE `taikhoan` SET " +
                    "TENDANGNHAP = '" + account.name + "', " +
                    "MATKHAU = '" + account.password + "', " +
                    "MaQ = '" + account.roleId + "' " +
                    "WHERE MA = '" + account.id + "'";
                MySQLConnection.ToUpdate(sql);
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public string GetNewID()
        {
            string sql = "SELECT MA FROM `taikhoan` ORDER BY MA DESC LIMIT 1";
            MySqlDataReader dr = MySQLConnection.ToQuery(sql);
            string id = "";
            while (dr.Read()) { id = dr.GetString("MA"); }
            id = id.Substring(id.Length - 2, 2);
            int intId = Int32.Parse(id);
            intId++;
            if (intId < 10)
            {
                id = "TK0";
            }
            else
            {
                id = "TK";
            }
            id += intId.ToString();
            return id;
        }
        public AccountDTO AddData(string name, string password, string roleId)
        {
            AccountDTO accountDTO = new AccountDTO();
            try
            {
                accountDTO.id = GetNewID();
                accountDTO.name = name;
                accountDTO.password = password;
                accountDTO.roleId = roleId;

                string sql = "INSERT INTO `taikhoan` VALUE (" +
                    "'" + accountDTO.id + "'," +
                    "'" + accountDTO.name + "'," +
                    "'" + accountDTO.password + "'," +
                    "'" + accountDTO.roleId + "')";

                MySQLConnection.ToUpdate(sql);
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
            MySQLConnection.CloseConnection();
            return accountDTO;
        }
    }
}
