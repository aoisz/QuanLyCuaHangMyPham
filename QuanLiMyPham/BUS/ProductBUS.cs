using QuanLiMyPham.DAO;
using QuanLiMyPham.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace QuanLiMyPham.BUS
{
    internal class ProductBUS
    {
        public static DataTable productList;

        public ProductBUS() { }

        public void SetTableData()
        {
            ProductDAO productDAO = new ProductDAO();
            if (productList == null)
            {
                productList = new DataTable();
                productList = productDAO.GetDB();
            }
        }
        public void DelData(string id, int rowIndex)
        {
            ProductDAO productDAO = new ProductDAO();
            productDAO.DelData(id);
            productList.Rows.RemoveAt(rowIndex);
        }

        //thêm
        public ProductDTO AddData(string name, string ingredients, string type, string production, string price, string mfgDate, string expDate, string img)
        {
            ProductDAO productDAO = new ProductDAO();
            ProductDTO productDTO = productDAO.AddData(name, ingredients, type, mfgDate, expDate, production, price, img);
            DataRow row = productList.NewRow();
            row["MA"] = productDTO.id;
            row["TEN"] = productDTO.name;
            row["THANHPHAN"] = productDTO.ingredients;
            row["NGAYSX"] = productDTO.mfgDate;
            row["LOAIHANG"] = productDTO.type;
            row["HANSD"] = productDTO.expDate;
            row["NSX"] = productDTO.production;
            row["DONGIA"] = productDTO.price;
            row["HINHANH"] = productDTO.img;
            productList.Rows.Add(row);
            return productDTO;
        }

        //sửa 
        public void EditData(int indexRow, ProductDTO customer)
        {
            ProductDAO khachHang = new ProductDAO();
            khachHang.EditData(customer);

            // finds all rows with id==2 and selects first or null if haven't found any
            foreach (DataRow row in productList.Rows)
            {
                if (row["MA"].Equals(customer.id))
                {
                    row["TEN"] = customer.name;
                    row["THANHPHAN"] = customer.ingredients;
                    row["NGAYSX"] = customer.mfgDate;
                    row["HANSD"] = customer.expDate;
                    row["LOAIHANG"] = customer.type;
                    row["NSX"] = customer.production;
                    row["DONGIA"] = customer.price;
                    row["HINHANH"] = customer.img;
                }
            }
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
            return list;
        }

        //tìm kiếm theo mã
        public DataTable searchID(string searchData)
        {
            DataTable list = new DataTable();
            foreach (DataColumn col in productList.Columns)
            {
                list.Columns.Add(col.ColumnName, col.DataType);
            }
            foreach (DataRow row in productList.Rows)
            {
                if (searchData.ToLower().Equals(row["MA"].ToString().ToLower()))
                {
                    DataRow dataRow = list.NewRow();
                    foreach (DataColumn col in productList.Columns)
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
            foreach (DataColumn col in productList.Columns)
            {
                list.Columns.Add(col.ColumnName, col.DataType);
            }
            foreach (DataRow row in productList.Rows)
            {
                if ((row["TEN"].ToString().ToLower().Contains(searchData.ToLower()) == true))
                {
                    DataRow dataRow = list.NewRow();
                    foreach (DataColumn col in productList.Columns)
                    {
                        dataRow[col.ColumnName] = row[col.ColumnName];
                    }
                    list.Rows.Add(dataRow);
                }
            }
            return list;
        }

        //filter theo đơn giá 
        public DataTable PriceFilter(string min, string max)
        {
            DataTable list = new DataTable();
            double minPrice = double.Parse(min);
            double maxPrice = double.Parse(max);
            foreach(DataColumn col in productList.Columns)
            {
                list.Columns.Add(col.ColumnName, col.DataType);
            }
            foreach (DataRow row in productList.Rows)
            {
                if (Double.Parse(row["DONGIA"].ToString()) > minPrice && Double.Parse(row["DONGIA"].ToString()) < maxPrice)
                {
                    DataRow dataRow = list.NewRow();
                    foreach (DataColumn col in productList.Columns)
                    {
                        dataRow[col.ColumnName] = row[col.ColumnName];
                    }
                    list.Rows.Add(dataRow);
                }
            }
            return list;
        }

        public DataTable ProductionFilter(string productionName)
        {
            DataTable list = new DataTable();
            foreach (DataColumn col in productList.Columns)
            {
                list.Columns.Add(col.ColumnName, col.DataType);
            }
            ProductionBUS productionBUS = new ProductionBUS();
            DataTable temp = productionBUS.searchName(productionName);
            string name = "";
            foreach(DataRow row in temp.Rows)
            {
                name = row["MA"].ToString();
            }
            foreach (DataRow row in productList.Rows)
            {
                if (row["NSX"].ToString().ToLower().Equals(name.ToLower()))
                {
                    DataRow dataRow = list.NewRow();
                    foreach (DataColumn col in productList.Columns)
                    {
                        dataRow[col.ColumnName] = row[col.ColumnName];
                    }
                    list.Rows.Add(dataRow);
                }
            }
            return list;
        }

        public DataTable TypeFilter(string typeName)
        {
            DataTable list = new DataTable();
            foreach (DataColumn col in productList.Columns)
            {
                list.Columns.Add(col.ColumnName, col.DataType);
            }
            TypeBUS typeBUS = new TypeBUS();
            DataTable temp = typeBUS.searchName(typeName);
            string name = "";
            foreach (DataRow row in temp.Rows)
            {
                name = row["MA"].ToString();
            }
            foreach (DataRow row in productList.Rows)
            {
                if (row["LOAIHANG"].ToString().ToLower().Equals(name.ToLower()))
                {
                    DataRow dataRow = list.NewRow();
                    foreach (DataColumn col in productList.Columns)
                    {
                        dataRow[col.ColumnName] = row[col.ColumnName];
                    }
                    list.Rows.Add(dataRow);
                }
            }
            return list;
        }
        public DataTable GetDataByStorageID(string storageID)
        {
            ProductDAO productDAO = new ProductDAO();
            return productList = productDAO.GetDataByStorageID(storageID); 
        }
    }
}
