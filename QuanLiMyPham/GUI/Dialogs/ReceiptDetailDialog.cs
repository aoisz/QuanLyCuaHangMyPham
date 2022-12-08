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
    public partial class ReceiptDetailDialog : Form
    {
        public ReceiptDetailDialog()
        {
            InitializeComponent();
        }

        public void LoadDetailTable(string receiptId)
        {
            ReceiptDetailBUS bus = new ReceiptDetailBUS();
            detailTable.DataSource = bus.SearchByID(receiptId);
            SettingDetailTable();
        }

        public void SettingDetailTable()
        {
            detailTable.Columns["MAHD"].Width = (int)(detailTable.Width * 0.2);
            detailTable.Columns["MASP"].Width = (int)(detailTable.Width * 0.2);
            detailTable.Columns["DONGIA"].Width = (int)(detailTable.Width * 0.2);
            detailTable.Columns["SOLUONG"].Width = (int)(detailTable.Width * 0.2);
            detailTable.Columns["THANHTIEN"].Width = (int)(detailTable.Width * 0.2);

            detailTable.Columns["MAHD"].HeaderText = "Receipt ID";
            detailTable.Columns["MASP"].HeaderText = "Product ID";
            detailTable.Columns["DONGIA"].HeaderText = "Price";
            detailTable.Columns["SOLUONG"].HeaderText = "Quantity";
            detailTable.Columns["THANHTIEN"].HeaderText = "Total";
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
