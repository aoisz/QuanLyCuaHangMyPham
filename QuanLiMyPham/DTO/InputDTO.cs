using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiMyPham.DTO
{
    internal class InputDTO
    {
        public string id;
        public string storageID;
        public string employeeId;
        public string date;
        public string totalPrice;

        public InputDTO() { }

        public InputDTO(string id, string storageID, string employeeId, string date, string totalPrice)
        {
            this.id = id;
            this.storageID = storageID;
            this.employeeId = employeeId;
            this.date = date;
            this.totalPrice = totalPrice;
        }
    }
}
