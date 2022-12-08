using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiMyPham.DTO
{
    public class RoleDetailDTO
    {
        public string roleId;
        public string function;
        public string tableName;
        public RoleDetailDTO() { }

        public RoleDetailDTO(string tableName, string function, string roleId)
        {
            this.roleId = roleId;
            this.function = function;
            this.tableName = tableName;
        }
    }
}
