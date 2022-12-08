using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiMyPham.DTO
{
    public class PromotionDTO
    {
        public string id;
        public string name;
        public string discount;
        public string minPrice;
        public string maxPrice;

        public PromotionDTO() { }

        public PromotionDTO(string id, string name, string discount, string minPrice, string maxPrice)
        {
            this.id = id;
            this.name = name;
            this.discount = discount;
            this.minPrice = minPrice;
            this.maxPrice = maxPrice;
        }
    }
}
