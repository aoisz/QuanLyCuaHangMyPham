using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiMyPham.DTO
{
    internal class InputDetailDTO
    {
        public string inputId;
        public string productId;
        public string price;
        public string quantity;
        public string totalPrice;

        public InputDetailDTO() { }
        public InputDetailDTO(string inputId, string productId, string price, string quantity, string totalPrice)
        {
            this.inputId = inputId;
            this.productId = productId;
            this.price = price;
            this.quantity = quantity;
            this.totalPrice = totalPrice;
        }
    }
}
