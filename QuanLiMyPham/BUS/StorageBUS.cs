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
    internal class StorageBUS
    {
        public static DataTable storageList;

        public void SetTableData()
        {
            StorageDAO DAO = new StorageDAO();
            if (storageList == null)
            {
                storageList = new DataTable();
                storageList = DAO.GetDB();
            }
        }
        // lấy id mới 
        public string FillId()
        {
            StorageDAO dao = new StorageDAO();
            return dao.FillId();
        }
        //thêm
        public void AddData(StorageDTO storageDTO)
        {
            StorageDAO storageDAO = new StorageDAO();
            storageDAO.AddData(storageDTO);
            DataRow row = storageList.NewRow();
            row[0] = storageDTO.id;
            row[1] = storageDTO.name;
            storageList.Rows.Add(row);
        }
        //sửa 
        public void EditData(StorageDTO storageDTO)
        {
            StorageDAO storageDAO = new StorageDAO();
            storageDAO.EditData(storageDTO);

            // finds all rows with id==2 and selects first or null if haven't found any
            foreach (DataRow row in storageList.Rows)
            {
                if (row["MA"].Equals(storageDTO.id))
                {
                    row["TEN"] = storageDTO.name;
                }
            }
        }
        public void DelData(string id, int rowIndex)
        {
            StorageDAO storageDAO = new StorageDAO();
            storageDAO.DelData(id);
            storageList.Rows.RemoveAt(rowIndex);
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
            foreach (DataColumn col in storageList.Columns)
            {
                list.Columns.Add(col.ColumnName, col.DataType);
            }
            foreach (DataRow row in storageList.Rows)
            {
                if (searchData.ToLower().Equals(row["MA"].ToString().ToLower()))
                {
                    DataRow dataRow = list.NewRow();
                    foreach (DataColumn col in storageList.Columns)
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
            foreach (DataColumn col in storageList.Columns)
            {
                list.Columns.Add(col.ColumnName, col.DataType);
            }
            foreach (DataRow row in storageList.Rows)
            {
                if ((row["TEN"].ToString().ToLower().Contains(searchData.ToLower()) == true) || (row["HO"].ToString().ToLower().Contains(searchData.ToLower()) == true))
                {
                    DataRow dataRow = list.NewRow();
                    foreach (DataColumn col in storageList.Columns)
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
