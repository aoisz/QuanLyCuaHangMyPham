using QuanLiMyPham.BUS;
using QuanLiMyPham.DTO;
using QuanLiMyPham.GUI.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiMyPham.GUI
{
    public partial class ProductionGUI : UserControl
    {
        public static string action;
        public ProductionGUI()
        {
            InitializeComponent();
            LoadListView();
            SettingDataGridView();
            searchOpt.SelectedIndex = 0;
            ShowRowAt(0);
        }

        public void LoadListView()
        {
            ProductionBUS production = new ProductionBUS();
            production.SetTableData();
            dataGridView.DataSource = ProductionBUS.productionList;
        }

        public void SettingDataGridView()
        {
            dataGridView.Columns[0].HeaderText = "ID";
            dataGridView.Columns[1].HeaderText = "Tên";
            dataGridView.Columns[2].HeaderText = "Quốc gia";
            dataGridView.Columns[0].Width = (int)(dataGridView.Width * 0.20);
            dataGridView.Columns[1].Width = (int)(dataGridView.Width * 0.38);
            dataGridView.Columns[2].Width = (int)(dataGridView.Width * 0.38);
        }

        public void ShowRowAt(int index)
        {
            idTxtBox.Text = dataGridView.Rows[index].Cells[0].Value.ToString();
            nameTxtBox.Text = dataGridView.Rows[index].Cells[1].Value.ToString();
            countryTxtBox.Text = dataGridView.Rows[index].Cells[2].Value.ToString();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowRowAt(e.RowIndex);
        }

        private void unselectBtn_Click(object sender, EventArgs e)
        {
            Unselect();
        }
        public void Unselect()
        {

            LoadListView();

            SettingDataGridView();

            searchTxtBox.Text = "";
            searchOpt.SelectedIndex = -1;

            addBtn.Enabled = true;
            dataGridView.CurrentCell = null;
            idTxtBox.Text = null;
            nameTxtBox.Text = null;
            countryTxtBox.Text = null;
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            action = "add";
            ProductionDialog dialog = new ProductionDialog();
            dialog.ShowDialog();
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Delete production " + idTxtBox.Text + "?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                {
                    ProductionBUS bus = new ProductionBUS();
                    bus.DelData(idTxtBox.Text, dataGridView.CurrentRow.Index);

                    MessageBox.Show("Delete Succesfully!", "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Unselect();
                }
            }
            else
            {
                MessageBox.Show("Please select a row!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            action = "edit";
            ProductionDialog dialog = new ProductionDialog();
            dialog.FillData(new ProductionDTO(dataGridView.CurrentRow.Cells["MA"].Value.ToString(), dataGridView.CurrentRow.Cells["TEN"].Value.ToString(), dataGridView.CurrentRow.Cells["QUOCGIA"].Value.ToString()));
            dialog.ShowDialog();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (searchOpt.SelectedIndex == -1)
            {
                MessageBox.Show("Select an search option", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (searchTxtBox.Text == "" || searchTxtBox.Text == "")
            {
                MessageBox.Show("Please enter data to search!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ProductionBUS bus = new ProductionBUS();
            DataTable data = null;
            if (searchOpt.SelectedIndex == 0)
            {
                data = bus.searchByOption("id", searchTxtBox.Text);
                if (data.Rows.Count < 1)
                {
                    MessageBox.Show("Have no result!", "No result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                dataGridView.DataSource = bus.searchByOption("id", searchTxtBox.Text);
            }
            else if (searchOpt.SelectedIndex == 1)
            {
                data = bus.searchByOption("name", searchTxtBox.Text);
                if (data.Rows.Count < 1)
                {
                    MessageBox.Show("Have no result!", "No result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                dataGridView.DataSource = bus.searchByOption("name", searchTxtBox.Text);
            }
            else if (searchOpt.SelectedIndex == 2)
            {
                data = bus.searchByOption("phone", searchTxtBox.Text);
                if (data.Rows.Count < 1)
                {
                    MessageBox.Show("Have no result!", "No result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                dataGridView.DataSource = bus.searchByOption("phone", searchTxtBox.Text);
            }
        }
    }
}
