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
    public partial class PromotionPicker : Form
    {
        public string id;
        public string discountValue;
        public PromotionPicker()
        {
            InitializeComponent();
        }

        public void LoadDataGridView(int price)
        {
            PromotionBUS bus = new PromotionBUS();
            bus.SetTableData();
            //dataGridView.DataSource = PromotionBUS.promotionList;
            dataGridView.DataSource = bus.GetDiscountAvailable(price);
            SettingDataGridView();
        }

        public void SettingDataGridView()
        {
            dataGridView.Columns["MA"].Width = (int)(dataGridView.Width * 0.16);
            dataGridView.Columns["TEN"].Width = (int)(dataGridView.Width * 0.2);
            dataGridView.Columns["TIENKM"].Width = (int)(dataGridView.Width * 0.2);
            dataGridView.Columns["MUCTOITHIEU"].Width = (int)(dataGridView.Width * 0.2);
            dataGridView.Columns["MUCTOIDA"].Width = (int)(dataGridView.Width * 0.2);

            dataGridView.Columns["MA"].HeaderText = "ID";
            dataGridView.Columns["TEN"].HeaderText = "Name";
            dataGridView.Columns["TIENKM"].HeaderText = "Discount";
            dataGridView.Columns["MUCTOITHIEU"].HeaderText = "Minimum";
            dataGridView.Columns["MUCTOIDA"].HeaderText = "Maximum";
        }

        public bool CheckAnyAvailable()
        {
            DataTable table = (DataTable)dataGridView.DataSource;
            if (table.Rows.Count == 0)
            {
                return false;
            }
            return true;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chooseBtn_Click(object sender, EventArgs e)
        {
            this.id = dataGridView.CurrentRow.Cells["MA"].Value.ToString();
            this.discountValue = dataGridView.CurrentRow.Cells["TIENKM"].Value.ToString();
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
