using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiMyPham.DTO
{
    public class AccountDTO
    {
        public string id;
        public string name;
        public string password;
        public string roleId;
         public AccountDTO() { }

        public AccountDTO(string id, string name, string password, string roleId)
        {
            this.id = id;
            this.name = name;
            this.password = password;
            this.roleId = roleId;
        }
    }
}
