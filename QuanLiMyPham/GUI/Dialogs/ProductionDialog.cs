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
    public partial class ProductionDialog : Form
    {
        public ProductionDialog()
        {
            InitializeComponent();
            if (ProductionGUI.action.Equals("add"))
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
            ProductionBUS bus = new ProductionBUS();
            idTxtBox.Text = bus.GetNewId();
        }

        public void FillData(ProductionDTO dto)
        {
            idTxtBox.Text = dto.id;
            nameTxtBox.Text = dto.name;
            countryTxtBox.Text = dto.country;
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
            if (ProductionGUI.action.Equals("add"))
            {
                AddData();
            }
            else if (ProductionGUI.action.Equals("edit"))
            {
                EditData();
            }
            Close();
        }
        public void AddData()
        {
            if (nameTxtBox.Text == string.Empty ||
                idTxtBox.Text == string.Empty ||
                countryTxtBox.Text == string.Empty 
            )
            {
                MessageBox.Show("Please enter all data required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ProductionDTO temp = new ProductionDTO();
            temp.id = idTxtBox.Text;
            temp.name = nameTxtBox.Text;
            temp.country = countryTxtBox.Text;

            ProductionBUS bus = new ProductionBUS();
            bus.AddData(temp);
            MessageBox.Show("Add Succesfully!", "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void EditData()
        {
            if (nameTxtBox.Text == string.Empty ||
                idTxtBox.Text == string.Empty ||
                countryTxtBox.Text == string.Empty
            )
            {
                MessageBox.Show("Please enter all data required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ProductionDTO temp = new ProductionDTO();
            temp.id = idTxtBox.Text;
            temp.name = nameTxtBox.Text;
            temp.country = countryTxtBox.Text;

            ProductionBUS bus = new ProductionBUS();
            bus.EditData(temp);
            MessageBox.Show("Edit Succesfully!", "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
