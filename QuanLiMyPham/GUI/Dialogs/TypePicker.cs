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
    public partial class TypePicker : Form
    {
        public TypeDTO type;
        public TypePicker()
        {
            InitializeComponent();
            LoadType();
            SettingDataGridView();
        }

        public void LoadType()
        {
            TypeBUS bus = new TypeBUS();
            bus.SetTableData();
            dataGridView.DataSource = TypeBUS.typeList;
        }

        public void SettingDataGridView()
        {
            dataGridView.Columns["MA"].Width = (int)(dataGridView.Width * 0.5);
            dataGridView.Columns["TEN"].Width = (int)(dataGridView.Width * 0.5);

            dataGridView.Columns["MA"].HeaderText = "ID";
            dataGridView.Columns["TEN"].HeaderText = "NAME";
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chooseBtn_Click(object sender, EventArgs e)
        {
            if(dataGridView.CurrentRow.Index > -1)
            {
                type = new TypeDTO();
                type.id = dataGridView.CurrentRow.Cells["MA"].Value.ToString();
                type.name = dataGridView.CurrentRow.Cells["TEN"].Value.ToString();
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
