using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiMyPham.DTO
{
    public class StorageDTO
    {
        public string id;
        public string name;
        
        public StorageDTO() { }

        public StorageDTO(string id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
