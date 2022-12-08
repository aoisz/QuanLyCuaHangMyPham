using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiMyPham.DTO
{
    public class TypeDTO
    {
        public string id;
        public string name;
        public TypeDTO() { }
        public TypeDTO(string id, string name) 
        { 
            this.id = id;
            this.name = name;
        }
    }
}
