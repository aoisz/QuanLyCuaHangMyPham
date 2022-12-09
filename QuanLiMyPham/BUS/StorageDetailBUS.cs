using QuanLiMyPham.DAO;
using QuanLiMyPham.DTO;
using Syncfusion.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QuanLiMyPham.BUS
{
    internal class StorageDetailBUS
    {
        public static DataTable storageDetailList;

        public StorageDetailBUS() { }

        public void SetTableData()
        {
            StorageDetailDAO storageDetailDAO = new StorageDetailDAO();
            if (storageDetailList == null)
            {
                storageDetailList = new DataTable();
                storageDetailList = storageDetailDAO.GetDB();
            }
        }

        public DataTable GetDetailById(string id)
        {
            StorageDetailDAO dao = new StorageDetailDAO();
            DataTable storageDetails = dao.GetDetailById(id);
            return storageDetails;
        }
        public void UpdateQuantity(StorageDetailDTO dto)
        {
            SetTableData();
            int flag = 1;
            StorageDetailDAO dao = new StorageDetailDAO();
            foreach (DataRow row in storageDetailList.Rows)
            {
                if (row["MaSP"].ToString().Equals(dto.productID) && row["MaKho"].ToString().Equals(dto.storageID))
                {
                    flag = 0;
                    int quantity = int.Parse(row["SOLUONG"].ToString()) + int.Parse(dto.productQuantity);
                    dto.productQuantity = quantity.ToString();
                    dao.UpdateQuantity(dto);
                    break;
                }
            }
            if (flag == 1)
            {
                dao.InsertNewProduct(dto);
            }
            storageDetailList.Clear();
            SetTableData();
        }
        public void UpDownQuantityTrade(StorageDetailDTO dto)
        {

            SetTableData();
            StorageDetailDAO dao = new StorageDetailDAO();
            foreach (DataRow row in storageDetailList.Rows)
            {
                if (row["MaSP"].ToString().Equals(dto.productID) && row["MaKho"].ToString().Equals(dto.storageID))
                {
                    int quantity = (int.Parse(row["SOLUONG"].ToString()) - int.Parse(dto.productQuantity));
                    dto.productQuantity = quantity.ToString();
                    dao.UpdateQuantity(dto);
                    break;
                }
            }
        }

        public bool IsAvailableProduct(string id, int quantity)
        {
            int amount = 0;
            foreach(DataRow row in storageDetailList.Rows)
            {
                if (row["MaSP"].ToString().Equals(id))
                {
                    amount += int.Parse(row["SOLUONG"].ToString());
                }
            }
            if(amount > quantity)
            {
                return true;
            }
            return false;
        }

        public string GetAvailableStorage(string productId)
        {
            string storageId = "";
            foreach(DataRow row in storageDetailList.Rows)
            {
                if (row["MaSP"].ToString().Equals(productId) && int.Parse(row["SOLUONG"].ToString()) > 0)
                {
                    storageId = row["MaKho"].ToString();
                    break;
                }
            }
            return storageId;
        }

        public void ReduceQuantity(string productId, int quantity)
        {
            StorageDetailDAO detailDAO = new StorageDetailDAO();
            DataRow[] storages = storageDetailList.Select("MaSP like '%" + productId + "%'");
            int quantityS1 = int.Parse(storages[0]["SOLUONG"].ToString());
            int sub = quantity - quantityS1;
            if (sub < 0)
            {
                // neu so luong o kho 1 nhieu hon so luong can mua thi lay so luong o kho 1 tru cho so luong can mua
                detailDAO.UpdateQuantity(new StorageDetailDTO(storages[0]["MaKho"].ToString(), productId, (quantityS1 - quantity).ToString()));
            }
            else
            {
                // neu so luong kho 1 it hon so luong mua thi giam so luong kho 1 = 0 va lay so luong kho 2 tru cho (mua - kho1)
                int quantityS2 = int.Parse(storages[1]["SOLUONG"].ToString());
                detailDAO.UpdateQuantity(new StorageDetailDTO(storages[0]["MaKho"].ToString(), productId, "0"));
                int final = quantityS2 - (quantity - quantityS1);
                detailDAO.UpdateQuantity(new StorageDetailDTO(storages[1]["MaKho"].ToString(), productId, final.ToString()));
            }
            /*int remain = quantity;
            foreach(DataRow row in storages)
            {
                int quantityTemp = int.Parse(row["SOLUONG"].ToString());
                if(quantityTemp < remain)
                {
                    remain -= quantityTemp;
                    detailDAO.UpdateQuantity(new StorageDetailDTO(row["MaKho"].ToString(), productId, "0"));
                }
                else
                {
                    detailDAO.UpdateQuantity(new StorageDetailDTO(row["MaKho"].ToString(), productId, (quantityTemp-remain).ToString()));
                }
            }*/
        }
    }
}
