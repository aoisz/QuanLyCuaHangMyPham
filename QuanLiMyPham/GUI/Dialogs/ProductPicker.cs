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
    public partial class ProductPicker : Form
    {
        public string productSelectedId;
        public string idStorage;
        public ProductPicker()
        {
            InitializeComponent();
            if (!TradeStorageDialog.action.Equals(""))
            {
                LoadDataGridViewByStorageID();
            }
            else
            {
                LoadDataGridView();
            }
            SettingDataGridView();
        }
        public void LoadDataGridViewByStorageID()
        {
            ProductBUS productBUS = new ProductBUS();
            dataGridView.DataSource = productBUS.GetDataByStorageID(TradeStorageDialog.action);
        }
        public void LoadDataGridView()
        {
            ProductBUS productBUS = new ProductBUS();
            productBUS.SetTableData();
            dataGridView.DataSource = ProductBUS.productList;
        }

        public void SettingDataGridView()
        {
            dataGridView.Columns["LOAIHANG"].Visible = false;
            dataGridView.Columns["THANHPHAN"].Visible = false;
            dataGridView.Columns["NGAYSX"].Visible = false;
            dataGridView.Columns["HANSD"].Visible = false;
            dataGridView.Columns["NSX"].Visible = false;
            dataGridView.Columns["HINHANH"].Visible = false;

            dataGridView.Columns["MA"].Width = (int)(dataGridView.Width * 0.1);
            dataGridView.Columns["TEN"].Width = (int)(dataGridView.Width * 0.4469);
            dataGridView.Columns["DONGIA"].Width = (int)(dataGridView.Width * 0.2);
            dataGridView.Columns["SOLUONG"].Width = (int)(dataGridView.Width * 0.2);

            dataGridView.Columns["MA"].HeaderText = "ID";
            dataGridView.Columns["TEN"].HeaderText = "PRODUCT NAME";
            dataGridView.Columns["DONGIA"].HeaderText = "PRICE";
            dataGridView.Columns["SOLUONG"].HeaderText = "QUANTITY";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            productSelectedId = dataGridView.CurrentRow.Cells["MA"].Value.ToString();
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
