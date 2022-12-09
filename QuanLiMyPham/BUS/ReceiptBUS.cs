using Org.BouncyCastle.Crypto.Engines;
using QuanLiMyPham.DAO;
using QuanLiMyPham.DTO;
using System.Data;
using System.Globalization;

namespace QuanLiMyPham.BUS
{
    internal class ReceiptBUS
    {
        public static DataTable receiptList;

        public ReceiptBUS() { }

        public void SetTableData()
        {
            ReceiptDAO receiptDAO = new ReceiptDAO();
            if (receiptList == null)
            {
                receiptList = new DataTable();
                receiptList = receiptDAO.GetDB();
            }
        }
        public void DelData(int rowIndex, string id)
        {
            ReceiptDAO receiptDAO = new ReceiptDAO();
            receiptDAO.DelData(id);
            receiptList.Rows.RemoveAt(rowIndex);
        }

        //thêm
        public void AddData(ReceiptDTO dto)
        {
            ReceiptDAO receiptDAO = new ReceiptDAO();
            receiptDAO.AddData(dto);
            DataRow row = receiptList.NewRow();
            row[0] = dto.id;
            row[1] = dto.employeeId;
            row[2] = dto.customerId;
            row[3] = dto.date;
            row[4] = dto.totalPrice;
            row[5] = dto.promotionId;
            row[6] = dto.afterDiscountPrice;
            receiptList.Rows.Add(row);
        }

        //sửa 
        public void EditData(int indexRow, ReceiptDTO receipt)
        {
            ReceiptDAO receiptDAO = new ReceiptDAO();
            receiptDAO.EditData(receipt);

            // finds all rows with id==2 and selects first or null if haven't found any
            foreach (DataRow row in receiptList.Rows)
            {
                if (row["MA"].Equals(receipt.id))
                {
                    row["MANV"] = receipt.employeeId;
                    row["MAKH"] = receipt.customerId;
                    row["NGAY"] = receipt.date;
                    row["TONGTIEN"] = receipt.totalPrice;
                    row["MACTKM"] = receipt.promotionId;
                    row["TONGTIENSAUKM"] = receipt.afterDiscountPrice;
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
            foreach (DataColumn col in receiptList.Columns)
            {
                list.Columns.Add(col.ColumnName, col.DataType);
            }
            foreach (DataRow row in receiptList.Rows)
            {
                if (searchData.ToLower().Equals(row["MA"].ToString().ToLower()))
                {
                    DataRow dataRow = list.NewRow();
                    foreach (DataColumn col in receiptList.Columns)
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
            foreach (DataColumn col in receiptList.Columns)
            {
                list.Columns.Add(col.ColumnName, col.DataType);
            }
            foreach (DataRow row in receiptList.Rows)
            {
                if (row["TENDANGNHAP"].ToString().ToLower().Contains(searchData.ToLower()) == true)
                {
                    DataRow dataRow = list.NewRow();
                    foreach (DataColumn col in receiptList.Columns)
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
            foreach (DataColumn col in receiptList.Columns)
            {
                list.Columns.Add(col.ColumnName, col.DataType);
            }
            foreach (DataRow row in receiptList.Rows)
            {
                if (searchData.ToLower().Equals(row["MaQ"].ToString().ToLower()))
                {
                    DataRow dataRow = list.NewRow();
                    foreach (DataColumn col in receiptList.Columns)
                    {
                        dataRow[col.ColumnName] = row[col.ColumnName];
                    }
                    list.Rows.Add(dataRow);
                }
            }
            return list;
        }

        public List<DateTime> GetAllMonths()
        {
            List<DateTime> dateList = new List<DateTime>();
            foreach(DataRow row in receiptList.Rows)
            {
                DateTime date = DateTime.Parse(row["NGAY"].ToString());
                if (!dateList.Contains(date))
                {
                    dateList.Add(date);
                }
            }
            return dateList;
        }

        public Dictionary<string, int> GetAllMonthSale()
        {
            Dictionary<string, int> sales = new Dictionary<string, int>();
            ReceiptDAO receiptDAO = new ReceiptDAO();
            DataTable rawData = receiptDAO.GetPriceByMonthYear();
            foreach(DataRow row in rawData.Rows)
            {
                string key = row["THANG"].ToString() + "/" + row["NAM"].ToString();
                int value = int.Parse(row["THANHTIEN"].ToString());
                sales.Add(key, value);
            }
            return sales;
        }

        public int CountByEmployeeId(string employeeId)
        {
            int count = 0;
            foreach(DataRow row in receiptList.Rows)
            {
                if (row["MANV"].ToString().Equals(employeeId))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
