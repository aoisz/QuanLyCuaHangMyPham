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
    public partial class InputDetailDialog : Form
    {
        public string inputID;
        public InputDetailDialog(string inputID)
        {
            InitializeComponent();
            this.inputID = inputID;
            Detail();
            SettingdataGridView();
            label1.Text = "Input Products " + inputID;
        }

        public void SettingdataGridView()
        {
            InputDetailBUS bus = new InputDetailBUS();
            bus.SetTableData();
            dataGridView.Columns["MAPN"].Visible = false;
            dataGridView.Columns["MASP"].Width = (int)(dataGridView.Width * 0.25);
            dataGridView.Columns["DONGIA"].Width = (int)(dataGridView.Width * 0.25);
            dataGridView.Columns["SOLUONG"].Width = (int)(dataGridView.Width * 0.25);
            dataGridView.Columns["THANHTIEN"].Width = (int)(dataGridView.Width * 0.25);

            dataGridView.Columns["MASP"].HeaderText = "Product ID";
            dataGridView.Columns["DONGIA"].HeaderText = "Price";
            dataGridView.Columns["SOLUONG"].HeaderText = "Quantity";
            dataGridView.Columns["THANHTIEN"].HeaderText = "Total";
        }

        public void Detail()
        {
            DataTable list = new DataTable();
            foreach (DataColumn col in InputDetailBUS.inputDetailList.Columns)
            {
                list.Columns.Add(col.ColumnName, col.DataType);
            }
            foreach (DataRow row in InputDetailBUS.inputDetailList.Rows)
            {
                if (inputID.ToLower().Equals(row["MAPN"].ToString().ToLower()))
                {
                    DataRow dataRow = list.NewRow();
                    foreach (DataColumn col in InputDetailBUS.inputDetailList.Columns)
                    {
                        dataRow[col.ColumnName] = row[col.ColumnName];
                    }
                    list.Rows.Add(dataRow);
                }
            }
            dataGridView.DataSource = list;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
