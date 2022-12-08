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
    public partial class StorageDialog : Form
    {
        public StorageDialog()
        {
            InitializeComponent();
            if (StorageGUI.action.Equals("edit"))
            {
                title.Text = "Edit Storage";
                acceptBtn.Text = "Edit";
            }
            if (StorageGUI.action.Equals("add"))
            {
                FillId();
            }
        }
        public void FillId()
        {
            StorageBUS bus = new StorageBUS();
            idTxtBox.Text = bus.FillId();
        }
        public void ShowData(StorageDTO storageDTO)
        {
            idTxtBox.Text = storageDTO.id;
            nameTxtBox.Text = storageDTO.name;
        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            if (StorageGUI.action.Equals("add"))
            {
                AddData();
            }
            else if (StorageGUI.action.Equals("edit"))
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
            StorageDTO temp = new StorageDTO(idTxtBox.Text, nameTxtBox.Text);

            StorageBUS bus = new StorageBUS();
            bus.AddData(temp);
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
            StorageDTO temp = new StorageDTO(idTxtBox.Text, nameTxtBox.Text);

            StorageBUS bus = new StorageBUS();
            bus.EditData(temp);
            MessageBox.Show("Edit Succesfully!", "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
