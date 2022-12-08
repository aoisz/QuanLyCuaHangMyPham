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
    internal class TypeBUS
    {
        public static DataTable typeList;

        public TypeBUS() { }

        public void SetTableData()
        {
            TypeDAO typeDAO = new TypeDAO();
            if (typeList == null)
            {
                typeList = new DataTable();
                typeList = typeDAO.GetDB();
            }
        }
        public void DelData(string id, int rowIndex)
        {
            TypeDAO type = new TypeDAO();
            type.DelData(id);
            typeList.Rows.RemoveAt(rowIndex);
        }

        //thêm
        public void AddData(TypeDTO typeDTO)
        {
            TypeDAO typeDAO = new TypeDAO();
            typeDAO.AddData(typeDTO);
            DataRow row = typeList.NewRow();
            row[0] = typeDTO.id;
            row[1] = typeDTO.name;
            typeList.Rows.Add(row);
        }

        //sửa 
        public void EditData(TypeDTO typeDTO)
        {
            TypeDAO typeDAO = new TypeDAO();
            typeDAO.EditData(typeDTO);

            // finds all rows with id==2 and selects first or null if haven't found any
            foreach (DataRow row in typeList.Rows)
            {
                if (row["MA"].Equals(typeDTO.id))
                {
                    row["TEN"] = typeDTO.name;
                }
            }
        }

        public DataTable searchByOption(string opt, string searchData)
        {
            DataTable list = new DataTable();
            if (opt.Equals("ID"))
            {
                list = searchID(searchData);
            }
            else if (opt.Equals("Name"))
            {
                list = searchName(searchData);
            }
            
            return list;
        }

        //tìm kiếm theo mã
        public DataTable searchID(string searchData)
        {
            DataTable list = new DataTable();
            foreach (DataColumn col in typeList.Columns)
            {
                list.Columns.Add(col.ColumnName, col.DataType);
            }
            /*DataTable list = new DataTable();
            list.Columns.Add("MA", typeof(string));
            list.Columns.Add("TEN", typeof(string));*/
            foreach (DataRow row in typeList.Rows)
            {
                if (searchData.ToLower().Equals(row["MA"].ToString().ToLower()))
                {
                    DataRow dataRow = list.NewRow();
                    dataRow["MA"] = row[0];
                    dataRow["TEN"] = row[1];
                    list.Rows.Add(dataRow);
                }
            }
            return list;
        }

        //tìm kiếm theo tên
        public DataTable searchName(string searchData)
        {
           
            DataTable list = new DataTable();
            foreach (DataColumn col in typeList.Columns)
            {
                list.Columns.Add(col.ColumnName, col.DataType);
            }
            foreach (DataRow row in typeList.Rows)
            {
                if (row["TEN"].ToString().ToLower().Contains(searchData.ToLower()) == true)
                {
                    DataRow dataRow = list.NewRow();
                    foreach (DataColumn col in typeList.Columns)
                    {
                        dataRow[col.ColumnName] = row[col.ColumnName];
                    }
                    list.Rows.Add(dataRow);
                }
            }
            return list;
        }

        // lấy id mới 
        public string FillId()
        {
            TypeDAO dao = new TypeDAO();
            return dao.FillId();
        }
    }
}
