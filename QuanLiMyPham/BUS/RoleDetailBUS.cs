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
    internal class RoleDetailBUS
    {
        public static DataTable roleDetailList;

        public RoleDetailBUS() { }

        public void SetTableData()
        {
            RoleDetailDAO roleDetailDAO = new RoleDetailDAO();
            if (roleDetailList == null)
            {
                roleDetailList = new DataTable();
                roleDetailList = roleDetailDAO.GetDB();
            }
        }
        public void DelData(int rowIndex, string roleId)
        {
            RoleDetailDAO roleDetailDAO = new RoleDetailDAO();
            roleDetailDAO.DelData(roleId);
            DataRow[] rows = roleDetailList.Select("MAQ = '%" + roleId + "%'");
            for(int i = 0; i < rows.Length; i++)
            {
                rows[i].Delete();
            }
            roleDetailList.AcceptChanges();
        }

        //thêm
        public void AddData(string tableName, string function, string roleId)
        {
            RoleDetailDAO roleDetailDAO = new RoleDetailDAO();
            RoleDetailDTO roleDetailDTO = roleDetailDAO.AddData(tableName, function, roleId);
            DataRow row = roleDetailList.NewRow();
            row[0] = roleDetailDTO.tableName;
            row[1] = roleDetailDTO.function;
            row[2] = roleDetailDTO.roleId;
            roleDetailList.Rows.Add(row);
        }

        //sửa 
        public void EditData(int indexRow, RoleDetailDTO roleDetail)
        {
            RoleDetailDAO roleDetailDAO = new RoleDetailDAO();
            roleDetailDAO.EditData(roleDetail);

            // finds all rows with id==2 and selects first or null if haven't found any
            foreach (DataRow row in roleDetailList.Rows)
            {
                if (row["MAQ"].Equals(roleDetail.roleId) && row["TENBANG"].Equals(roleDetail.tableName))
                {
                    row["CHUCNANG"] = roleDetail.function;
                }
            }
        }

        public DataRow[] GetDetailById(string id)
        {
            RoleDetailBUS bus = new RoleDetailBUS();
            bus.SetTableData();
            DataRow[] roleDetails = roleDetailList.Select("MAQ like '%" + id + "%'");
            return roleDetails;
        }
    }
}
