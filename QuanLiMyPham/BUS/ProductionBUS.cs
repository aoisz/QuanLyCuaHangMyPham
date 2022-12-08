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
    internal class ProductionBUS
    {
        public static DataTable productionList;

        public ProductionBUS() { }

        public void SetTableData()
        {
            ProductionDAO productionDAO = new ProductionDAO();
            if (productionList == null)
            {
                productionList = new DataTable();
                productionList = productionDAO.GetDB();
            }
        }
        public void DelData(string id, int rowIndex)
        {
            ProductionDAO production = new ProductionDAO();
            production.DelData(id);
            productionList.Rows.RemoveAt(rowIndex);
        }

        //thêm
        public void AddData(ProductionDTO productionDTO )
        {
            ProductionDAO productionDAO = new ProductionDAO();
            productionDAO.AddData(productionDTO);
            DataRow row = productionList.NewRow();
            row[0] = productionDTO.id;
            row[1] = productionDTO.name;
            row[2] = productionDTO.country;
            productionList.Rows.Add(row);
        }

        //sửa 
        public void EditData(ProductionDTO production)
        {
            ProductionDAO khachHang = new ProductionDAO();
            khachHang.EditData(production);

            // finds all rows with id==2 and selects first or null if haven't found any
            foreach (DataRow row in productionList.Rows)
            {
                if (row["MA"].Equals(production.id))
                {
                    row["TEN"] = production.name;
                    row["QUOCGIA"] = production.country;
                }
            }
        }

        public string GetNewId()
        {
            ProductionDAO dao = new ProductionDAO();
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
                list = searchCountry(searchData);
            }
            return list;
        }

        //tìm kiếm theo mã
        public DataTable searchID(string searchData)
        {
            DataTable list = new DataTable();
            foreach (DataColumn col in productionList.Columns)
            {
                list.Columns.Add(col.ColumnName, col.DataType);
            }
            foreach (DataRow row in productionList.Rows)
            {
                if (searchData.ToLower().Equals(row["MA"].ToString().ToLower()))
                {
                    DataRow dataRow = list.NewRow();
                    foreach (DataColumn col in productionList.Columns)
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
            foreach (DataColumn col in productionList.Columns)
            {
                list.Columns.Add(col.ColumnName, col.DataType);
            }
            foreach (DataRow row in productionList.Rows)
            {
                if (row["TEN"].ToString().ToLower().Contains(searchData.ToLower()) == true)
                {
                    DataRow dataRow = list.NewRow();
                    foreach (DataColumn col in productionList.Columns)
                    {
                        dataRow[col.ColumnName] = row[col.ColumnName];
                    }
                    list.Rows.Add(dataRow);
                }
            }
            return list;
        }

        //tìm kiếm theo sdt 
        public DataTable searchCountry(string searchData)
        {
            DataTable list = new DataTable();
            foreach (DataColumn col in productionList.Columns)
            {
                list.Columns.Add(col.ColumnName, col.DataType);
            }
            foreach (DataRow row in productionList.Rows)
            {
                if (row["QUOCGIA"].ToString().ToLower().Contains(searchData.ToLower()) == true)
                {
                    DataRow dataRow = list.NewRow();
                    foreach (DataColumn col in productionList.Columns)
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
