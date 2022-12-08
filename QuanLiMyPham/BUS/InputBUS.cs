using MySql.Data.MySqlClient;
using QuanLiMyPham.DAO;
using QuanLiMyPham.DTO;
using System.Data;

namespace QuanLiMyPham.BUS
{
    internal class InputBUS
    {
        public static DataTable inputList;

        public InputBUS() { }

        public void SetTableData()
        {
            InputDAO DAO = new InputDAO();
            if (inputList == null)
            {
                inputList = new DataTable();
                inputList = DAO.GetDB();
            }
        }
        public void AddData(InputDTO dto)
        {
            InputDAO inputDAO = new InputDAO();
            inputDAO.AddData(dto);
            DataRow row = inputList.NewRow();
            row[0] = dto.id;
            row[1] = dto.storageID;
            row[2] = dto.employeeId;
            row[3] = dto.date;
            row[4] = dto.totalPrice;
            inputList.Rows.Add(row);
        }
        public void DelData(string id, int rowIndex)
        {
            InputDAO inputDAO = new InputDAO();
            inputDAO.DelData(id);
            inputList.Rows.RemoveAt(rowIndex);
        }
        public DataTable SearchByOption(string opt, string searchData)
        {
            DataTable list = new DataTable();
            if (opt.Equals("Input Products ID"))
            {
                list = SearchID(searchData);
            }
            else if (opt.Equals("Employee ID"))
            {
                list = SearchEmployee(searchData);
            }
            else if (opt.Equals("Storage ID"))
            {
                list = SearchStorage(searchData);
            }
            return list;
        }

        //tìm kiếm theo mã
        public DataTable SearchID(string searchData)
        {
            DataTable list = new DataTable();
            foreach (DataColumn col in inputList.Columns)
            {
                list.Columns.Add(col.ColumnName, col.DataType);
            }
            
            foreach (DataRow row in inputList.Rows)
            {
                if (searchData.ToLower().Equals(row["MA"].ToString().ToLower()))
                {
                    DataRow dataRow = list.NewRow();
                    foreach (DataColumn col in inputList.Columns)
                    {
                        dataRow[col.ColumnName] = row[col.ColumnName];
                    }
                    list.Rows.Add(dataRow);
                }
            }
            return list;
        }

        //tìm kiếm theo nhan vien
        public DataTable SearchEmployee(string searchData)
        {
            DataTable list = new DataTable();
            foreach (DataColumn col in inputList.Columns)
            {
                list.Columns.Add(col.ColumnName, col.DataType);
            }
            foreach (DataRow row in inputList.Rows)
            {
                if (searchData.ToLower().Equals(row["MANV"].ToString().ToLower()))
                {
                    DataRow dataRow = list.NewRow();
                    foreach (DataColumn col in inputList.Columns)
                    {
                        dataRow[col.ColumnName] = row[col.ColumnName];
                    }
                    list.Rows.Add(dataRow);
                }
            }
            return list;
        }

        //tìm kiếm theo kho
        public DataTable SearchStorage(string searchData)
        {
            DataTable list = new DataTable();
            foreach (DataColumn col in inputList.Columns)
            {
                list.Columns.Add(col.ColumnName, col.DataType);
            }
            foreach (DataRow row in inputList.Rows)
            {
                if (searchData.ToLower().Equals(row["MAKHO"].ToString().ToLower()))
                {
                    DataRow dataRow = list.NewRow();
                    foreach (DataColumn col in inputList.Columns)
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
