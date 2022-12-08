using QuanLiMyPham.DAO;
using QuanLiMyPham.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiMyPham.BUS
{
    internal class EmployeeBUS
    {
        public static DataTable employeeList;

        public EmployeeBUS() { }

        public void SetTableData()
        {
            EmployeeDAO employeeDAO = new EmployeeDAO();
            if (employeeList == null)
            {
                employeeList = new DataTable();
                employeeList = employeeDAO.GetDB();
            }
        }
        public void DelData(string id, int rowIndex)
        {
            EmployeeDAO employeeDAO = new EmployeeDAO();
            employeeDAO.DelData(id);
            employeeList.Rows.RemoveAt(rowIndex);
        }

        //thêm
        public void AddData(EmployeeDTO employeeDTO)
        {
            EmployeeDAO employeeDAO = new EmployeeDAO();
            employeeDAO.AddData(employeeDTO);
            DataRow row = employeeList.NewRow();
            row[0] = employeeDTO.id;
            row[1] = employeeDTO.lastName;
            row[2] = employeeDTO.firstName;
            row[3] = employeeDTO.address;
            row[4] = employeeDTO.gender;
            row[5] = employeeDTO.salary;
            row[6] = employeeDTO.yob;
            employeeList.Rows.Add(row);
        }

        //sửa 
        public void EditData(EmployeeDTO employeeDTO)
        {
            EmployeeDAO employeeDAO = new EmployeeDAO();
            employeeDAO.EditData(employeeDTO);

            // finds all rows with id==2 and selects first or null if haven't found any
            foreach (DataRow row in employeeList.Rows)
            {
                if (row["MANV"].Equals(employeeDTO.id))
                {
                    row["HO"] = employeeDTO.lastName;
                    row["TEN"] = employeeDTO.firstName;
                    row["DIACHI"] = employeeDTO.address;
                    row["GIOITINH"] = employeeDTO.gender;
                    row["LUONG"] = employeeDTO.salary;
                    row["NAMSINH"] = employeeDTO.yob;
                }
            }
        }

        public DataTable SearchByOption(string opt, string searchData)
        {
            DataTable list = new DataTable();
            if (opt.Equals("ID"))
            {
                list = SearchID(searchData);
            }
            else if (opt.Equals("Name"))
            {
                list = SearchName(searchData);
            }
            return list;
        }

        //tìm kiếm theo mã
        public DataTable SearchID(string searchData)
        {
            DataTable list = new DataTable();
            foreach (DataColumn col in employeeList.Columns)
            {
                list.Columns.Add(col.ColumnName, col.DataType);
            }
            /*DataTable list = new DataTable();
            list.Columns.Add("MANV", typeof(string));
            list.Columns.Add("HO", typeof(string));
            list.Columns.Add("TEN", typeof(string));
            list.Columns.Add("DIACHI", typeof(string));
            list.Columns.Add("GIOITINH", typeof(string));
            list.Columns.Add("LUONG", typeof(string));
            list.Columns.Add("NAMSINH", typeof(string));*/
            foreach (DataRow row in employeeList.Rows)
            {
                if (searchData.ToLower().Equals(row["MANV"].ToString().ToLower()))
                {
                    DataRow dataRow = list.NewRow();
                    foreach (DataColumn col in employeeList.Columns)
                    {
                        dataRow[col.ColumnName] = row[col.ColumnName];
                    }
                    list.Rows.Add(dataRow);
                }
            }
            return list;
        }

        //tìm kiếm theo tên
        public DataTable SearchName(string searchData)
        {
            DataTable list = new DataTable();
            foreach (DataColumn col in employeeList.Columns)
            {
                list.Columns.Add(col.ColumnName, col.DataType);
            }
            foreach (DataRow row in employeeList.Rows)
            {
                if ((row["TEN"].ToString().ToLower().Contains(searchData.ToLower()) == true) || (row["HO"].ToString().ToLower().Contains(searchData.ToLower()) == true))
                {
                    DataRow dataRow = list.NewRow();
                    foreach (DataColumn col in employeeList.Columns)
                    {
                        dataRow[col.ColumnName] = row[col.ColumnName];
                    }
                    list.Rows.Add(dataRow);
                }
            }
            return list;
        }

        // lấy id mới 
        public string FillId()
        {
            EmployeeDAO dao = new EmployeeDAO();
            return dao.FillId();
        }
    }
}
