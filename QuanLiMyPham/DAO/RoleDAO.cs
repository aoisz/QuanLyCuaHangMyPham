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
    internal class RoleDAO
    {
        public DataTable GetDB()
        {
            DataTable data = new DataTable();
            try
            {
                String sql = "SELECT * FROM `quyen`";
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
                string sql = "DELETE FROM `quyen` WHERE MaQ = '" + id + "'";
                MessageBox.Show(sql, "quyen");
                MySQLConnection.ToUpdate(sql);
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void EditData(RoleDTO role)
        {
            try
            {
                string sql = "UPDATE `quyen` SET " +
                    "Ten = '" + role.name + "', " +
                    "WHERE MaQ = '" + role.id + "'";
                MySQLConnection.ToUpdate(sql);
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public string GetNewID()
        {
            string newId = "";
            string sql = "SELECT MaQ FROM `quyen` ORDER BY MaQ DESC LIMIT 1";
            MySqlDataReader dr = MySQLConnection.ToQuery(sql);
            string id = "";
            while (dr.Read()) { id = dr.GetString("MaQ"); }
            id = id.Substring(id.Length - 2, 2);
            int intId = Int32.Parse(id);
            intId++;
            if (intId < 10)
            {
                id = "Q0";
            }
            else
            {
                id = "Q";
            }
            id += intId.ToString();
            return id;
        }
        public RoleDTO AddData(string name)
        {
            RoleDTO roleDTO = new RoleDTO();
            try
            {
                roleDTO.id = GetNewID();
                roleDTO.name = name;

                string sql = "INSERT INTO `quyen` VALUE (" +
                    "'" + roleDTO.id + "'," +
                    "'" + roleDTO.name + "')";

                MySQLConnection.ToUpdate(sql);
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
            MySQLConnection.CloseConnection();
            return roleDTO;
        }
    }
}
