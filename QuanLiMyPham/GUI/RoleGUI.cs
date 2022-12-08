using QuanLiMyPham.BUS;
using QuanLiMyPham.DTO;
using QuanLiMyPham.GUI.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiMyPham.GUI
{
    public partial class RoleGUI : UserControl
    {
        public static string action = "";
        public RoleGUI()
        {
            InitializeComponent();
            LoadDataGridView();
            SettingDataGridView();
            ShowRowAtIndex(0);
        }

        public void LoadDataGridView()
        {
            RoleBUS bus = new RoleBUS();
            bus.SetTableData();
            RoleDetailBUS detailBus = new RoleDetailBUS();
            detailBus.SetTableData();
            dataGridView.DataSource = RoleBUS.roleList;
        }

        public void SettingDataGridView()
        {
            dataGridView.Columns["MaQ"].Width = (int)(dataGridView.Width * 0.46);
            dataGridView.Columns["Ten"].Width = (int)(dataGridView.Width * 0.5);

            dataGridView.Columns["MaQ"].HeaderText = "ID";
            dataGridView.Columns["Ten"].HeaderText = "Role";
        }

        public void ShowRowAtIndex(int index)
        {
            idTxtBox.Text = dataGridView.Rows[index].Cells["MaQ"].Value.ToString();
            nameTxtBox.Text = dataGridView.Rows[index].Cells["Ten"].Value.ToString();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

        }

        private void detailViewBtn_Click(object sender, EventArgs e)
        {
            RoleDetailsDialog dialog = new RoleDetailsDialog(dataGridView.CurrentRow.Cells["MaQ"].Value.ToString());
            dialog.ShowDialog();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            action = "add";
            RoleDialog dialog = new RoleDialog(0,null);
            dialog.ShowDialog();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            action = "edit";
            RoleDTO roleDTO = new RoleDTO(dataGridView.CurrentRow.Cells["MaQ"].Value.ToString(), dataGridView.CurrentRow.Cells["Ten"].Value.ToString());
            RoleDialog dialog = new RoleDialog(dataGridView.CurrentRow.Index,roleDTO);
            dialog.ShowDialog();
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Delete " + dataGridView.CurrentRow.Cells["MaQ"].Value.ToString() + "?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(dialogResult == DialogResult.OK)
            {
                string id = dataGridView.CurrentRow.Cells["MaQ"].Value.ToString();
                RoleDetailBUS detailBUS = new RoleDetailBUS();
                detailBUS.DelData(dataGridView.CurrentRow.Index, id);
                RoleBUS bus = new RoleBUS();
                bus.DelData(dataGridView.CurrentRow.Index, id);
            }
        }

        private void unselectBtn_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
            SettingDataGridView();
            ShowRowAtIndex(0);
            searchTxtBox.Text = string.Empty;
            searchOpt.SelectedIndex = -1;
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowRowAtIndex(e.RowIndex);
        }
    }
}
