using QuanLiMyPham.DAO;
using QuanLiMyPham.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLiMyPham.BUS
{
    internal class CustomerBUS
    {
        public static DataTable customerList;

        public CustomerBUS() { }

        public void SetTableData()
        {
            CustomerDAO customerDAO = new CustomerDAO();
            if(customerList == null)
            {
                customerList = new DataTable();
                customerList = customerDAO.GetDB();
            }
        }
        public void DelData(string id, int rowIndex)
        {
            CustomerDAO Customer = new CustomerDAO();
            Customer.DelData(id);
            customerList.Rows.RemoveAt(rowIndex);
        }

        //thêm
        public void AddData(CustomerDTO khachHang)
        {
            CustomerDAO customer = new CustomerDAO();
            customer.AddData(khachHang);
            DataRow row = customerList.NewRow();
            row[0] = khachHang.id;
            row[1] = khachHang.lastName;
            row[2] = khachHang.firstName;
            row[3] = khachHang.phoneNum;
            customerList.Rows.Add(row);
        }

        //sửa 
        public void EditData(CustomerDTO customer)
        {
            CustomerDAO khachHang = new CustomerDAO();
            khachHang.EditData(customer);

            // finds all rows with id==2 and selects first or null if haven't found any
            foreach (DataRow row in customerList.Rows)
            {
                if (row["MAKH"].Equals(customer.id))
                {
                    row["HO"] = customer.lastName;
                    row["TEN"] = customer.firstName;
                    row["SDT"] = customer.phoneNum;
                }
            }
        }

        public string GetNewId()
        {
            CustomerDAO dao = new CustomerDAO();
            return dao.GetNewId();
        }

        public DataTable searchByOption(string opt, string searchData)
        {
            DataTable list = new DataTable();
            if (opt.Equals("id"))
            {
                list = searchID(searchData);
            }
            else if (opt.Equals("name"))
            {
                list = searchName(searchData);
            }
            else
            {
                list = searchPhone(searchData);
            }
            return list;
        }

        //tìm kiếm theo mã
        public DataTable searchID(string searchData)
        {
            DataTable list = new DataTable();
            foreach (DataColumn col in customerList.Columns)
            {
                list.Columns.Add(col.ColumnName, col.DataType);
            }
            foreach (DataRow row in customerList.Rows)
            {
                if (searchData.ToLower().Equals(row["MAKH"].ToString().ToLower()))
                {
                    DataRow dataRow = list.NewRow();
                    foreach (DataColumn col in customerList.Columns)
                    {
                        dataRow[col.ColumnName] = row[col.ColumnName];
                    }
                    list.Rows.Add(dataRow);
                }
            }
            return list;
        }

        //tìm kiếm theo tên
        public DataTable searchName(string searchData)
        {
            DataTable list = new DataTable();
            foreach(DataColumn col in customerList.Columns)
            {
                list.Columns.Add(col.ColumnName, col.DataType);
            }
            foreach (DataRow row in customerList.Rows)
            {
                if ((row["HO"].ToString().ToLower().Contains(searchData.ToLower()) == true) || (row["TEN"].ToString().ToLower().Contains(searchData.ToLower()) == true))
                {   
                    DataRow dataRow = list.NewRow();
                    foreach(DataColumn col in customerList.Columns)
                    {
                        dataRow[col.ColumnName] = row[col.ColumnName];
                    }
                    list.Rows.Add(dataRow);
                }
            }
            return list;
        }

        //tìm kiếm theo sdt 
        public DataTable searchPhone(string searchData)
        {
            DataTable list = new DataTable();
            foreach (DataColumn col in customerList.Columns)
            {
                list.Columns.Add(col.ColumnName, col.DataType);
            }
            foreach (DataRow row in customerList.Rows)
            {
                if (row["SDT"].ToString().ToLower().Contains(searchData.ToLower()) == true)
                {
                    DataRow dataRow = list.NewRow();
                    foreach (DataColumn col in customerList.Columns)
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
