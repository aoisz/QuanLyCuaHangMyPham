
using QuanLiMyPham.BUS;
using System.Data;
using System.Security.Principal;

namespace QuanLiMyPham.GUI.Dialogs
{
    public partial class StorageDetailDialog : Form
    {
        public string id;
        public StorageDetailDialog(string id)
        {
            InitializeComponent();
            this.id = id;
          /*  SettingDataGridView();
            LoadStorageDetailList();*/
            LoadDataGridView();
            SettingDataGridView();
            label1.Text = "Storage " + id;
        }
        public void LoadStorageDetailList()
        {
            StorageDetailBUS bus = new StorageDetailBUS();
            dataGridView.DataSource = bus.GetDetailById(id);
           
        }
        public void LoadDataGridView()
        {
            StorageDetailBUS bus = new StorageDetailBUS();
            bus.SetTableData();
            /* dataGridView.DataSource = StorageBUS.storageList;*/

            dataGridView.DataSource = bus.GetDetailById(id);
        }

        public void SettingDataGridView()
        {
            dataGridView.Columns["MaKho"].Visible = false;
            /*dataGridView.Columns["MaKho"].Width = (int)(dataGridView.Width * 0.3);*/

            dataGridView.Columns["MaSP"].Width = (int)(dataGridView.Width * 0.5);
            dataGridView.Columns["SOLUONG"].Width = (int)(dataGridView.Width * 0.5);

            dataGridView.Columns["MaSP"].HeaderText = "Product ID";
            dataGridView.Columns["SOLUONG"].HeaderText = "Quantity";
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EditProductDialog dialog = new EditProductDialog(dataGridView.CurrentRow.Cells[1].Value.ToString());
            dialog.ShowDialog();
        }
    }
}
