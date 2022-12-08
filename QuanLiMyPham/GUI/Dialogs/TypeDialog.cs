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
    public partial class TypeDialog : Form
    {
        public TypeDialog()
        {
            InitializeComponent();
            if (ProductTypeGUI.action.Equals("add"))
            {
                FillId();
            }
            else if (ProductTypeGUI.action.Equals("edit"))
            {
                title.Text = "Edit Product Type";
                acceptBtn.Text = "EDIT";
            }
        }
        public void FillId()
        {
            TypeBUS bus = new TypeBUS();
            idTxtBox.Text = bus.FillId();
        }
        public void ShowData(TypeDTO typeDTO)
        {
            idTxtBox.Text = typeDTO.id;
            nameTxtBox.Text = typeDTO.name;
        }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            if (ProductTypeGUI.action.Equals("add"))
            {
                AddData();
            }
            else if (ProductTypeGUI.action.Equals("edit"))
            {
                EditData();
            }
            Close();
        }
        public void AddData()
        {
            if (nameTxtBox.Text == string.Empty ||
                idTxtBox.Text == string.Empty 
            )
            {
                MessageBox.Show("Please enter all data required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            TypeBUS bus = new TypeBUS();
            bus.AddData(new TypeDTO(idTxtBox.Text, nameTxtBox.Text));
            MessageBox.Show("Add Succesfully!", "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void EditData()
        {
            if (nameTxtBox.Text == string.Empty ||
               idTxtBox.Text == string.Empty
            )
            {
                MessageBox.Show("Please enter all data required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            TypeBUS bus = new TypeBUS();
            bus.EditData(new TypeDTO(idTxtBox.Text, nameTxtBox.Text));
            MessageBox.Show("Edit Succesfully!", "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
