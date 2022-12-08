using QuanLiMyPham.BUS;
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
    public partial class StoragePicker : Form
    {
        public string storageSelectedId;
        public StoragePicker()
        {
            InitializeComponent();
            LoadDataGridView();
            SettingDataGridView();
        }

        public void LoadDataGridView()
        {
            StorageBUS storageBUS = new StorageBUS();
            storageBUS.SetTableData();
            dataGridView.DataSource = StorageBUS.storageList;
        }

        public void SettingDataGridView()
        {
            dataGridView.Columns["MA"].Width = (int)(dataGridView.Width * 0.5);
            dataGridView.Columns["TEN"].Width = (int)(dataGridView.Width * 0.5);

            dataGridView.Columns["MA"].HeaderText = "ID";
            dataGridView.Columns["TEN"].HeaderText = "Name";
        }
        private void StoragePicker_Load(object sender, EventArgs e)
        {

        }

        private void chooseBtn_Click(object sender, EventArgs e)
        {
            storageSelectedId = dataGridView.CurrentRow.Cells["MA"].Value.ToString();
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
