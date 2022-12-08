using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiMyPham.DTO
{
    public class RoleDTO
    {
        public string id;
        public string name;
        public RoleDTO() { }
        public RoleDTO(string id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
