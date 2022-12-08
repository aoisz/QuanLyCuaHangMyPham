using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiMyPham.DTO
{
    internal class StorageDetailDTO
    {
        public string storageID;
        public string productID;
        public string productQuantity;
        
        public StorageDetailDTO() { }
        public StorageDetailDTO(string storageID, string productID, string productQuantity)
        {
            this.storageID = storageID;
            this.productID = productID;
            this.productQuantity = productQuantity;
        }
    }
}
