using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiMyPham.DTO
{
    public class ProductDTO
    {
        public ProductDTO() { }

        public ProductDTO(string id, string name, string type, string ingredients, string mfgDate, string expDate, string production, string price, string img)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.ingredients = ingredients;
            this.mfgDate = mfgDate;
            this.expDate = expDate;
            this.production = production;
            this.price = price;
            this.img = img;
        }

        public string id;
        public string name;
        public string type;
        public string ingredients;
        public string mfgDate;
        public string expDate;
        public string production;
        public string price;
        public string img;
    }
}
