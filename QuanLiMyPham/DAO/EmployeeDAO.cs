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
    internal class EmployeeDAO
    {
        public DataTable GetDB()
        {
            DataTable data = new DataTable();
            try
            {
                String sql = "SELECT * FROM `nhanvien`";
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
                string sql = "DELETE FROM `nhanvien` WHERE MANV = '" + id + "'";
                MySQLConnection.ToUpdate(sql);
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void EditData(EmployeeDTO employee)
        {
            try
            {
                string sql = "UPDATE `nhanvien` SET " +
                            "HO = '" + employee.lastName + "', " +
                            "TEN = '" + employee.firstName + "', " +
                            "DIACHI = '" + employee.address + "', " +
                            "GIOITINH = '" + employee.gender + "', " +
                            "LUONG = '" + employee.salary + "', " +
                            "NAMSINH = '" + employee.yob+ "' " +
                            "WHERE MA = '" + employee.id + "'";
                MySQLConnection.ToUpdate(sql);
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public String FillId()
        {
            string newId = "";
            string sql = "SELECT MANV FROM `nhanvien` ORDER BY MANV DESC LIMIT 1";
            MySqlDataReader dr = MySQLConnection.ToQuery(sql);
            string id = "";
            while (dr.Read()) { id = dr.GetString("MANV"); }
            id = id.Substring(id.Length - 2, 2);
            int intId = Int32.Parse(id);
            intId++;
            if (intId < 10)
            {
                id = "NV0";
            }
            else
            {
                id = "NV";
            }
            id += intId.ToString();
            return id;
        }
        public void AddData(EmployeeDTO employeeDTO)
        {
            try
            {
                string sql = "INSERT INTO `nhanvien` VALUE (" +
                            "'" + employeeDTO.id + "'," +
                            "'" + employeeDTO.lastName + "'," +
                            "'" + employeeDTO.firstName + "'," +
                            "'" + employeeDTO.address + "'," +
                            "'" + employeeDTO.gender + "'," +
                            "'" + employeeDTO.salary + "'," +
                            "'" + employeeDTO.yob + "')";

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
