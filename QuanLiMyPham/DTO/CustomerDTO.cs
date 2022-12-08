using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiMyPham.DTO
{
    public class CustomerDTO
    {

        public string id;
        public string firstName;
        public string lastName;
        public string phoneNum;

        public CustomerDTO()
        {
        }

        public CustomerDTO(string id, string firstName, string lastName, string phoneNum)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNum = phoneNum;
        }
    }
}
