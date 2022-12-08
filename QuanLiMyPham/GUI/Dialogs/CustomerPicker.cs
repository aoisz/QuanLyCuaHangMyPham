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
    public partial class CustomerPicker : Form
    {
        public string customerSelectedId;
        public CustomerPicker()
        {
            InitializeComponent();
            LoadDataGridView();
            SettingDataGridView();
        }

        public void LoadDataGridView()
        {
            CustomerBUS customerBUS = new CustomerBUS();
            customerBUS.SetTableData();
            dataGridView.DataSource = CustomerBUS.customerList;
        }

        public void SettingDataGridView()
        {
            dataGridView.Columns["MAKH"].Width = (int)(dataGridView.Width * 0.16);
            dataGridView.Columns["HO"].Width = (int)(dataGridView.Width * 0.25);
            dataGridView.Columns["TEN"].Width = (int)(dataGridView.Width * 0.25);
            dataGridView.Columns["SDT"].Width = (int)(dataGridView.Width * 0.25);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chooseBtn_Click(object sender, EventArgs e)
        {
            customerSelectedId = dataGridView.CurrentRow.Cells[0].Value.ToString();
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
