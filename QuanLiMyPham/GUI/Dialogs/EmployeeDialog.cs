using QuanLiMyPham.BUS;
using QuanLiMyPham.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLiMyPham.GUI.Dialogs
{
    public partial class EmployeeDialog : Form
    {
        public EmployeeDialog()
        {
            InitializeComponent();
            if (EmployeeGUI.action.Equals("add"))
            {
                FillId();
            }
            else if (EmployeeGUI.action.Equals("edit"))
            {
                title.Text = "Edit Employee";
                acceptBtn.Text = "EDIT";
            }
        }
        public void FillId()
        {
            EmployeeBUS bus = new EmployeeBUS();
            idTxtBox.Text = bus.FillId();
        }
        public void ShowData(EmployeeDTO employeeDTO)
        {
            idTxtBox.Text = employeeDTO.id;
            lastNameTxtBox.Text = employeeDTO.lastName;
            firstNameTxtBox.Text = employeeDTO.firstName;
            addressTxtBox.Text = employeeDTO.address;
            genderTxtBox.Text = employeeDTO.gender;
            salaryTxtBox.Text = employeeDTO.salary;
            yobTxtBox.Text = employeeDTO.yob;   
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            if (EmployeeGUI.action.Equals("add"))
            {
                AddData();
            }
            else if (EmployeeGUI.action.Equals("edit"))
            {
                EditData();
            }
            Close();
        }
        public void AddData()
        {
            if (lastNameTxtBox.Text == string.Empty ||
                idTxtBox.Text == string.Empty ||
                firstNameTxtBox.Text == string.Empty ||
                addressTxtBox.Text == string.Empty ||   
                genderTxtBox.Text == string.Empty ||
                salaryTxtBox.Text == string.Empty ||
                yobTxtBox.Text == string.Empty 
            )
            {
                MessageBox.Show("Please enter all data required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            EmployeeDTO temp = new EmployeeDTO();
            temp.id = idTxtBox.Text;
            temp.lastName = lastNameTxtBox.Text;
            temp.firstName = firstNameTxtBox.Text;
            temp.address = addressTxtBox.Text;
            temp.gender = genderTxtBox.Text;
            temp.salary = salaryTxtBox.Text;
            temp.yob = yobTxtBox.Text;

            EmployeeBUS bus = new EmployeeBUS();
            bus.AddData(temp);
            MessageBox.Show("Add Succesfully!", "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void EditData()
        {
            if (lastNameTxtBox.Text == string.Empty ||
               idTxtBox.Text == string.Empty ||
               firstNameTxtBox.Text == string.Empty ||
               addressTxtBox.Text == string.Empty ||
               genderTxtBox.Text == string.Empty ||
               salaryTxtBox.Text == string.Empty ||
               yobTxtBox.Text == string.Empty
            )
            {
                MessageBox.Show("Please enter all data required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            EmployeeDTO temp = new EmployeeDTO();
            temp.id = idTxtBox.Text;
            temp.lastName = lastNameTxtBox.Text;
            temp.firstName = firstNameTxtBox.Text;
            temp.address = addressTxtBox.Text;
            temp.gender = genderTxtBox.Text;
            temp.salary = salaryTxtBox.Text;
            temp.yob = yobTxtBox.Text;

            EmployeeBUS bus = new EmployeeBUS();
            bus.EditData(temp);
            MessageBox.Show("Edit Succesfully!", "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
