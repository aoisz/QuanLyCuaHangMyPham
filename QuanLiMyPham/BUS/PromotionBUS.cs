using QuanLiMyPham.DAO;
using QuanLiMyPham.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace QuanLiMyPham.BUS
{
    internal class PromotionBUS
    {
        public static DataTable promotionList;

        public PromotionBUS() { }

        public void SetTableData()
        {
            PromotionDAO promotionDAO = new PromotionDAO();
            if (promotionList == null)
            {
                promotionList = new DataTable();
                promotionList = promotionDAO.GetDB();
            }
        }
        public void DelData(int rowIndex, string id)
        {
            PromotionDAO promotionDAO = new PromotionDAO();
            promotionDAO.DelData(id);
            promotionList.Rows.RemoveAt(rowIndex);
        }

        //thêm
        public void AddData(PromotionDTO dto)
        {
            PromotionDAO promotionDAO = new PromotionDAO();
            promotionDAO.AddData(dto);
            DataRow row = promotionList.NewRow();
            row[0] = dto.id;
            row[1] = dto.name;
            row[2] = dto.discount;
            row[3] = dto.minPrice;
            row[4] = dto.maxPrice;
            promotionList.Rows.Add(row);
        }

        //sửa 
        public void EditData(PromotionDTO promotion)
        {
            PromotionDAO promotionDAO = new PromotionDAO();
            promotionDAO.EditData(promotion);

            foreach (DataRow row in promotionList.Rows)
            {
                if (row["MA"].Equals(promotion.id))
                {
                    row["TEN"] = promotion.name;
                    row["TIENKM"] = promotion.discount;
                    row["MUCTOITHIEU"] = promotion.minPrice;
                    row["MUCTOIDA"] = promotion.maxPrice;
                }
            }
        }

        public DataTable GetDiscountAvailable(int price)
        {
            DataTable list = new DataTable();
            foreach (DataColumn col in promotionList.Columns)
            {
                list.Columns.Add(col.ColumnName, col.DataType);
            }
            foreach (DataRow row in promotionList.Rows)
            {
                DataRow data = list.NewRow();
                int min = Int32.Parse(row["MUCTOITHIEU"].ToString());
                if (row["MUCTOIDA"].ToString() == string.Empty)
                {
                    if (price > min)
                    {
                        foreach (DataColumn col in promotionList.Columns)
                        {
                            data[col.ColumnName] = row[col.ColumnName];
                        }
                        list.Rows.Add(data);
                    }
                }
                else
                {
                    int max = Int32.Parse(row["MUCTOIDA"].ToString());
                    if (price > min && price < max)
                    {
                        foreach (DataColumn col in promotionList.Columns)
                        {
                            data[col.ColumnName] = row[col.ColumnName];
                        }
                        list.Rows.Add(data);
                    }
                }
            }
            return list;
        }

        public string FillId()
        {
            PromotionDAO dao = new PromotionDAO();
            return dao.GetNewID();
        }

       /* public DataTable SearchByOption(string opt, string searchData)
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
        }*/

        //tìm kiếm theo mã
        /*public DataTable SearchID(string searchData)
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
        }*/

        //tìm kiếm theo tên
        /*public DataTable SearchName(string searchData)
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
        }*/

        //tìm kiếm theo tên
        /*public DataTable SearchRole(string searchData)
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
        }*/
    }
}
