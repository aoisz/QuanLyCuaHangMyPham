using QuanLiMyPham.BUS;
using QuanLiMyPham.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiMyPham.GUI.Dialogs
{
    public partial class CustomerDialog : Form
    {
        public CustomerDialog()
        {
            InitializeComponent();
            if(CustomerGUI.action.Equals("add"))
            {
                FillId();
            }
            else
            {
                acceptBtn.Text = "EDIT";
            }
        }

        public void FillId()
        {
            CustomerBUS bus = new CustomerBUS();
            idTxtBox.Text = bus.GetNewId();
        }

        public void FillData(CustomerDTO dto)
        {
            idTxtBox.Text = dto.id;
            lastNameTxtBox.Text = dto.lastName;
            firstNameTxtBox.Text = dto.firstName;
            phoneTxtBox.Text = dto.phoneNum;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            if (CustomerGUI.action.Equals("add"))
            {
                AddData();
            }
            else if (CustomerGUI.action.Equals("edit"))
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
                phoneTxtBox.Text == string.Empty 
            )
            {
                MessageBox.Show("Please enter all data required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            CustomerDTO temp = new CustomerDTO();
            temp.id = idTxtBox.Text;
            temp.lastName = lastNameTxtBox.Text;
            temp.firstName = firstNameTxtBox.Text;
            temp.phoneNum = phoneTxtBox.Text;

            CustomerBUS bus = new CustomerBUS();
            bus.AddData(temp);
            MessageBox.Show("Add Succesfully!", "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void EditData()
        {
            if (lastNameTxtBox.Text == string.Empty ||
                idTxtBox.Text == string.Empty ||
                firstNameTxtBox.Text == string.Empty ||
                phoneTxtBox.Text == string.Empty
            )
            {
                MessageBox.Show("Please enter all data required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            CustomerDTO temp = new CustomerDTO();
            temp.id = idTxtBox.Text;
            temp.lastName = lastNameTxtBox.Text;
            temp.firstName = firstNameTxtBox.Text;
            temp.phoneNum = phoneTxtBox.Text;

            CustomerBUS bus = new CustomerBUS();
            bus.EditData(temp);
            MessageBox.Show("Edit Succesfully!", "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
