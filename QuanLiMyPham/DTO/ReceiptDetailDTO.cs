using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiMyPham.DTO
{
    internal class ReceiptDetailDTO
    {
        public string receiptId;
        public string productId;
        public string price;
        public string quantity;
        public string totalPrice;

        public ReceiptDetailDTO() { }

        public ReceiptDetailDTO(string receiptId, string productId, string price, string quantity, string totalPrice)
        {
            this.receiptId = receiptId;
            this.productId = productId;
            this.price = price;
            this.quantity = quantity;
            this.totalPrice = totalPrice;
        }
    }
}
