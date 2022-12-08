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
    internal class InputDetailBUS
    {
        public static DataTable inputDetailList;

        public InputDetailBUS() { }

        public void SetTableData()
        {
            InputDetailDAO DAO = new InputDetailDAO();
            if (inputDetailList == null)
            {
                inputDetailList = new DataTable();
                inputDetailList = DAO.GetDB();
            }
        }
        public void AddData(InputDetailDTO detailDTO)
        {
            InputDetailDAO inputDetailDAO = new InputDetailDAO();
            inputDetailDAO.AddData(detailDTO);
            DataRow row = inputDetailList.NewRow();
            row[0] = detailDTO.inputId;
            row[1] = detailDTO.productId;
            row[2] = detailDTO.price;
            row[3] = detailDTO.quantity;
            row[4] = detailDTO.totalPrice;
            inputDetailList.Rows.Add(row);
        }
        public void DelData(string id)
        {
            InputDetailDAO inputDAO = new InputDetailDAO();
            inputDAO.DelData(id);
            inputDetailList.Clear();
            SetTableData();
        }
    }
}
