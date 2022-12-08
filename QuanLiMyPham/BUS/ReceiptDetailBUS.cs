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
    internal class ReceiptDetailBUS
    {
        public static DataTable receiptDetailList;

        public ReceiptDetailBUS() { }

        public void SetTableData()
        {
            ReceiptDetailDAO receiptDetailDAO = new ReceiptDetailDAO();
            if (receiptDetailList == null)
            {
                receiptDetailList = new DataTable();
                receiptDetailList = receiptDetailDAO.GetDB();
            }
        }
        public void DelData(int rowIndex, string id)
        {
            ReceiptDetailDAO receiptDetailDAO = new ReceiptDetailDAO();
            receiptDetailDAO.DelData(id);
            receiptDetailList.Rows.RemoveAt(rowIndex);
        }

        //thêm
        public void AddData(ReceiptDetailDTO detailDTO)
        {
            ReceiptDetailDAO receiptDetailDAO = new ReceiptDetailDAO();
            receiptDetailDAO.AddData(detailDTO);
            DataRow row = receiptDetailList.NewRow();
            row[0] = detailDTO.receiptId;
            row[1] = detailDTO.productId;
            row[2] = detailDTO.price;
            row[3] = detailDTO.quantity;
            row[4] = detailDTO.totalPrice;
            receiptDetailList.Rows.Add(row);
        }

        //sửa 
        public void EditData(int indexRow, ReceiptDetailDTO receiptDetail)
        {
            ReceiptDetailDAO receiptDetailDAO = new ReceiptDetailDAO();
            receiptDetailDAO.EditData(receiptDetail);

            // finds all rows with id==2 and selects first or null if haven't found any
            foreach (DataRow row in receiptDetailList.Rows)
            {
                if (row["MAHD"].Equals(receiptDetail.productId) && row["MASP"].Equals(receiptDetail.productId))
                {
                    row["SOLUONG"] = receiptDetail.quantity;
                    row["THANHTIEN"] = receiptDetail.totalPrice;
                }
            }
        }

        public DataTable SearchByID(string receiptId)
        {
            DataTable list = new DataTable();
            foreach (DataColumn col in receiptDetailList.Columns)
            {
                list.Columns.Add(col.ColumnName, col.DataType);
            }
            foreach (DataRow row in receiptDetailList.Rows)
            {
                if (receiptId.ToLower().Equals(row["MAHD"].ToString().ToLower()))
                {
                    DataRow dataRow = list.NewRow();
                    foreach (DataColumn col in receiptDetailList.Columns)
                    {
                        dataRow[col.ColumnName] = row[col.ColumnName];
                    }
                    list.Rows.Add(dataRow);
                }
            }
            return list;
        }

        public int GetQuantityByProductId(string productId)
        {
            int sum = 0;
            foreach (DataRow row in receiptDetailList.Rows)
            {
                if (row["MASP"].ToString().Equals(productId))
                {
                    sum += int.Parse(row["SOLUONG"].ToString());
                }
            }
            return sum;
        }

        /*public DataTable SearchByOption(string opt, string searchData)
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
            foreach (DataColumn col in receiptDetailList.Columns)
            {
                list.Columns.Add(col.ColumnName, col.DataType);
            }
            foreach (DataRow row in receiptDetailList.Rows)
            {
                if (searchData.ToLower().Equals(row["MA"].ToString().ToLower()))
                {
                    DataRow dataRow = list.NewRow();
                    foreach (DataColumn col in receiptDetailList.Columns)
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
            foreach (DataColumn col in receiptDetailList.Columns)
            {
                list.Columns.Add(col.ColumnName, col.DataType);
            }
            foreach (DataRow row in receiptDetailList.Rows)
            {
                if (row["TENDANGNHAP"].ToString().ToLower().Contains(searchData.ToLower()) == true)
                {
                    DataRow dataRow = list.NewRow();
                    foreach (DataColumn col in receiptDetailList.Columns)
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
            foreach (DataColumn col in receiptDetailList.Columns)
            {
                list.Columns.Add(col.ColumnName, col.DataType);
            }
            foreach (DataRow row in receiptDetailList.Rows)
            {
                if (searchData.ToLower().Equals(row["MaQ"].ToString().ToLower()))
                {
                    DataRow dataRow = list.NewRow();
                    foreach (DataColumn col in receiptDetailList.Columns)
                    {
                        dataRow[col.ColumnName] = row[col.ColumnName];
                    }
                    list.Rows.Add(dataRow);
                }
            }
            return list;
        }*/
    }
}
