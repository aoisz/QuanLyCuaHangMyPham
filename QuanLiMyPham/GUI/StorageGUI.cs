using QuanLiMyPham.BUS;
using QuanLiMyPham.DAO;
using QuanLiMyPham.DTO;
using QuanLiMyPham.GUI.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;


namespace QuanLiMyPham.GUI
{
    public partial class StorageGUI : UserControl
    {
        public static string action = "";
        public StorageGUI()
        {
            InitializeComponent();
            LoadDataGridView();
            SettingDataGridView();
            ShowRowAtIndex(0);
        }
        public void LoadDataGridView()
        {
            StorageBUS bus = new StorageBUS();
            bus.SetTableData();
            dataGridView.DataSource = StorageBUS.storageList;
        }

        public void SettingDataGridView()
        {
            dataGridView.Columns["MA"].Width = (int)(dataGridView.Width * 0.5);
            dataGridView.Columns["TEN"].Width = (int)(dataGridView.Width * 0.5);


            dataGridView.Columns["MA"].HeaderText = "ID";
            dataGridView.Columns["TEN"].HeaderText = "Name";
        }
        public void ShowRowAtIndex(int index)
        {
            idTxtBox.Text = dataGridView.Rows[index].Cells["MA"].Value.ToString();
            nameTxtBox.Text = dataGridView.Rows[index].Cells["TEN"].Value.ToString();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowRowAtIndex(e.RowIndex);
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            StorageDetailBUS storageDetailBUS = new StorageDetailBUS();
            storageDetailBUS.SetTableData();
            StorageDetailDialog storageDetailGUI = new StorageDetailDialog(dataGridView.CurrentRow.Cells["MA"].Value.ToString());
            storageDetailGUI.ShowDialog();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            action = "add";
            StorageDialog dialog = new StorageDialog();
            dialog.Show();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            action = "edit";
            StorageDTO dto = new StorageDTO(idTxtBox.Text, nameTxtBox.Text);
            StorageDialog dialog = new StorageDialog();
            dialog.ShowData(dto);
            dialog.Show();
        }

        private void unselectBtn_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
            SettingDataGridView();

            searchTxtBox.Text = "";
            searchOpt.SelectedIndex = -1;

            addBtn.Enabled = true;
            dataGridView.CurrentCell = null;
            idTxtBox.Text = null;
            nameTxtBox.Text = null;
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Delete storage " + nameTxtBox.Text + "?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            if (result == DialogResult.OK)
            {
                StorageBUS bus = new StorageBUS();
                bus.DelData(idTxtBox.Text, dataGridView.CurrentRow.Index);
                MessageBox.Show("Delete Succesfully!", "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (searchOpt.SelectedIndex == -1)
            {
                MessageBox.Show("Choose a search option!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (searchTxtBox.Text == string.Empty)
            {
                MessageBox.Show("Empty data!!!");
                return;
            }
            StorageBUS bus = new StorageBUS();
            DataTable list = bus.SearchByOption(searchOpt.SelectedItem.ToString(), searchTxtBox.Text);
            dataGridView.DataSource = list;
            SettingDataGridView();
        }

        private void tradeBTN_Click(object sender, EventArgs e)
        {
            TradeStorageDialog dialog = new TradeStorageDialog();
            dialog.ShowDialog();
        }
    }
}
