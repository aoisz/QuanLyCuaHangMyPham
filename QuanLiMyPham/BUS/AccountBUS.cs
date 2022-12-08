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
    internal class AccountBUS
    {
        public static DataTable accountList;

        public AccountBUS() { }

        public void SetTableData()
        {
            AccountDAO accountDAO = new AccountDAO();
            if (accountList == null)
            {
                accountList = new DataTable();
                accountList = accountDAO.GetDB();
            }
        }
        public void DelData(int rowIndex, string id)
        {
            AccountDAO accountDAO = new AccountDAO();
            accountDAO.DelData(id);
            accountList.Rows.RemoveAt(rowIndex);
        }

        //thêm
        public AccountDTO AddData(string name, string password, string roleId)
        {
            AccountDAO accountDAO = new AccountDAO();
            AccountDTO accountDTO = accountDAO.AddData(name,password,roleId);
            DataRow row = accountList.NewRow();
            row[0] = accountDTO.id;
            row[1] = accountDTO.name;
            row[2] = accountDTO.password;
            row[3] = accountDTO.roleId;
            accountList.Rows.Add(row);
            return accountDTO;
        }

        //sửa 
        public void EditData(int indexRow, AccountDTO account)
        {
            AccountDAO accountDAO = new AccountDAO();
            accountDAO.EditData(account);

            // finds all rows with id==2 and selects first or null if haven't found any
            foreach (DataRow row in accountList.Rows)
            {
                if (row["MA"].Equals(account.id))
                {
                    row["TENDANGNHAP"] = account.name;
                    row["MATKHAU"] = account.password;
                    row["MaQ"] = account.roleId;
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
            else
            {
                list = SearchRole(searchData);
            }
            return list;
        }

        //tìm kiếm theo mã
        public DataTable SearchID(string searchData)
        {
            DataTable list = new DataTable();
            foreach (DataColumn col in accountList.Columns)
            {
                list.Columns.Add(col.ColumnName, col.DataType);
            }
            foreach (DataRow row in accountList.Rows)
            {
                if (searchData.ToLower().Equals(row["MA"].ToString().ToLower()))
                {
                    DataRow dataRow = list.NewRow();
                    foreach (DataColumn col in accountList.Columns)
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
            foreach (DataColumn col in accountList.Columns)
            {
                list.Columns.Add(col.ColumnName, col.DataType);
            }
            foreach (DataRow row in accountList.Rows)
            {
                if (row["TENDANGNHAP"].ToString().ToLower().Contains(searchData.ToLower()) == true)
                {
                    DataRow dataRow = list.NewRow();
                    foreach (DataColumn col in accountList.Columns)
                    {
                        dataRow[col.ColumnName] = row[col.ColumnName];
                    }
                    list.Rows.Add(dataRow);
                }
            }
            return list;
        }

        //tìm kiếm theo tên
        public DataTable SearchRole(string searchData)
        {
            DataTable list = new DataTable();
            foreach (DataColumn col in accountList.Columns)
            {
                list.Columns.Add(col.ColumnName, col.DataType);
            }
            foreach (DataRow row in accountList.Rows)
            {
                if (searchData.ToLower().Equals(row["MaQ"].ToString().ToLower()))
                {
                    DataRow dataRow = list.NewRow();
                    foreach (DataColumn col in accountList.Columns)
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
