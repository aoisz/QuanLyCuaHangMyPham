using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiMyPham.DTO
{
    public class ProductionDTO
    {

        public string id;
        public string name;
        public string country;

        public ProductionDTO()
        {
        }

        public ProductionDTO(string id, string name, string country)
        {
            this.id = id;
            this.name = name;
            this.country = country;
        }
    }
}
