using MySql.Data.MySqlClient;
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
    public partial class QuantityDetailDialog : Form
    {
        String productId;
        public QuantityDetailDialog(string id)
        {
            this.productId = id;
            InitializeComponent();
            LoadDataGridView();
        }

        public void LoadDataGridView()
        {
            string sql = "SELECT MaKho, SOLUONG FROM `chitietkho` WHERE MaSP = '" + productId + "'";
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = MySQLConnection.ToQueryTable(sql);
            adapter.Fill(dt);
            dataGridView.DataSource = dt;

            dataGridView.Columns[0].HeaderText = "ID Storage";
            dataGridView.Columns[1].HeaderText = "Quantity";
            dataGridView.Columns[0].Width = (int)(dataGridView.Width * 0.45);
            dataGridView.Columns[1].Width = (int)(dataGridView.Width * 0.45);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
