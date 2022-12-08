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
    public partial class ProductionPicker : Form
    {
        public ProductionDTO production;
        public ProductionPicker()
        {
            InitializeComponent();
            LoadProduction();
            SettingDataGridView();
        }

        public void LoadProduction()
        {
            ProductionBUS bus = new ProductionBUS();
            bus.SetTableData();
            dataGridView.DataSource = ProductionBUS.productionList;
        }

        public void SettingDataGridView()
        {
            dataGridView.Columns["MA"].Width = (int)(dataGridView.Width * 0.33);
            dataGridView.Columns["TEN"].Width = (int)(dataGridView.Width * 0.33);
            dataGridView.Columns["QUOCGIA"].Width = (int)(dataGridView.Width * 0.33);

            dataGridView.Columns["MA"].HeaderText = "ID";
            dataGridView.Columns["TEN"].HeaderText = "NAME";
            dataGridView.Columns["QUOCGIA"].HeaderText = "COUNTRY";
        }

        private void chooseBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow.Index > -1)
            {
                production = new ProductionDTO();
                production.id = dataGridView.CurrentRow.Cells["MA"].Value.ToString();
                production.name = dataGridView.CurrentRow.Cells["TEN"].Value.ToString();
                production.country = dataGridView.CurrentRow.Cells["QUOCGIA"].Value.ToString();
                this.DialogResult = DialogResult.OK;
                Close();
            }

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
