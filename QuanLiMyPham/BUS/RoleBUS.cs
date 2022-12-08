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
    internal class RoleBUS
    {
        public static DataTable roleList;

        public RoleBUS() { }

        public void SetTableData()
        {
            RoleDAO roleDAO = new RoleDAO();
            if (roleList == null)
            {
                roleList = new DataTable();
                roleList = roleDAO.GetDB();
            }
        }
        public void DelData(int rowIndex, string id)
        {
            RoleDAO roleDAO = new RoleDAO();
            roleDAO.DelData(id);
            roleList.Rows.RemoveAt(rowIndex);
        }

        //thêm
        public RoleDTO AddData(string name)
        {
            RoleDAO roleDAO = new RoleDAO();
            RoleDTO roleDTO = roleDAO.AddData(name);
            DataRow row = roleList.NewRow();
            row[0] = roleDTO.id;
            row[1] = roleDTO.name;
            roleList.Rows.Add(row);
            return roleDTO;
        }

        //sửa 
        public void EditData(int indexRow, RoleDTO Role)
        {
            RoleDAO roleDAO = new RoleDAO();
            roleDAO.EditData(Role);

            // finds all rows with id==2 and selects first or null if haven't found any
            foreach (DataRow row in roleList.Rows)
            {
                if (row["MaQ"].Equals(Role.id))
                {
                    row["TEN"] = Role.name;
                }
            }
        }

        public DataTable SearchByOption(string opt, string searchData)
        {
            DataTable list = new DataTable();
            if (opt.Equals("id"))
            {
                list = SearchID(searchData);
            }
            else if (opt.Equals("name"))
            {
                list = SearchName(searchData);
            }
            return list;
        }

        //tìm kiếm theo mã
        public DataTable SearchID(string searchData)
        {
            DataTable list = new DataTable();
            foreach (DataColumn col in roleList.Columns)
            {
                list.Columns.Add(col.ColumnName, col.DataType);
            }
            foreach (DataRow row in roleList.Rows)
            {
                if (searchData.ToLower().Equals(row["MaQ"].ToString().ToLower()))
                {
                    DataRow dataRow = list.NewRow();
                    foreach (DataColumn col in roleList.Columns)
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
            foreach (DataColumn col in roleList.Columns)
            {
                list.Columns.Add(col.ColumnName, col.DataType);
            }
            foreach (DataRow row in roleList.Rows)
            {
                if (row["TEN"].ToString().ToLower().Contains(searchData.ToLower()) == true)
                {
                    DataRow dataRow = list.NewRow();
                    foreach (DataColumn col in roleList.Columns)
                    {
                        dataRow[col.ColumnName] = row[col.ColumnName];
                    }
                    list.Rows.Add(dataRow);
                }
            }
            return list;
        }
    }
}
