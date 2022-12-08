using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiMyPham.DTO
{
    internal class ReceiptDTO
    {
        public string id;
        public string employeeId;
        public string customerId;
        public string date;
        public string totalPrice;
        public string promotionId;
        public string afterDiscountPrice;
        public ReceiptDTO() { }

        public ReceiptDTO(string id, string employeeId, string customerId, string date, string totalPrice, string promotionId, string afterDiscountPrice)
        {
            this.id = id;
            this.employeeId = employeeId;
            this.customerId = customerId;
            this.date = date;
            this.totalPrice = totalPrice;
            this.promotionId = promotionId;
            this.afterDiscountPrice = afterDiscountPrice;
        }
    }
}
