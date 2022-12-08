using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiMyPham.DTO
{

    public class EmployeeDTO
    {
        public string id;
        public string lastName;
        public string firstName;
        public string address;
        public string gender;
        public string salary;
        public string yob;

        public EmployeeDTO() { }

        public EmployeeDTO(string id, string lastName, string firstName, string address, string gender, string salary, string yob)
        {
            this.id = id;
            this.lastName = lastName;
            this.firstName = firstName;
            this.address = address;
            this.gender = gender;
            this.salary = salary;
            this.yob = yob;
        }
    }
}
