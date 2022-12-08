using QuanLiMyPham.BUS;
using QuanLiMyPham.DAO;
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
using System.Windows.Documents;
using System.Windows.Forms;

namespace QuanLiMyPham.GUI
{
    public partial class ProductTypeGUI : UserControl
    {
        public static string action = "";
        public ProductTypeGUI()
        {
            InitializeComponent();
            LoadDataGridView();
            SettingDataGridView();
            ShowRowAtIndex(0);
        }
        public void LoadDataGridView()
        {
            TypeBUS bus = new TypeBUS();
            bus.SetTableData();
            dataGridView.DataSource = TypeBUS.typeList;
        }

        public void SettingDataGridView()
        {
            /*dataGridView.Columns[0].HeaderText = "ID";
            dataGridView.Columns[1].HeaderText = "NAME";
            dataGridView.Columns[0].Width = (int)(dataGridView.Width * 0.4);
            dataGridView.Columns[1].Width = (int)(dataGridView.Width * 0.5);*/
            dataGridView.Columns["MA"].Width = (int)(dataGridView.Width * 0.5);
            dataGridView.Columns["TEN"].Width = (int)(dataGridView.Width * 0.5);


            dataGridView.Columns["MA"].HeaderText = "ID";
            dataGridView.Columns["TEN"].HeaderText = "Name";
        }
        public void ShowRowAtIndex(int index)
        {
            idTxtBox.Text = dataGridView.Rows[index].Cells["MA"].Value.ToString();
            nameTxtBox.Text = dataGridView.Rows[index].Cells["TEN"].Value.ToString();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowRowAtIndex(e.RowIndex);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (searchOpt.SelectedIndex == -1)
            {
                MessageBox.Show("Choose a search option!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            if (searchTxtBox.Text == string.Empty)
            {
                MessageBox.Show("Empty data!!!");
                return;
            }
            TypeBUS bus = new TypeBUS();
            DataTable list = bus.searchByOption(searchOpt.SelectedItem.ToString(), searchTxtBox.Text);
            dataGridView.DataSource = list;
            SettingDataGridView();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            action = "add";
           /* TypeDTO type = new TypeDTO(dataGridView.CurrentRow.Cells["MA"].Value.ToString(),
                                                dataGridView.CurrentRow.Cells["TEN"].Value.ToString()
            );*/
            TypeDialog dialog = new TypeDialog();
            dialog.ShowDialog();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            action = "edit";
            TypeDialog dialog = new TypeDialog();
            TypeDTO typeDTO = new TypeDTO(idTxtBox.Text, nameTxtBox.Text);
            dialog.ShowData(typeDTO);
            dialog.ShowDialog();
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Delete product type " + nameTxtBox.Text.ToString() + "?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            if (result == DialogResult.OK)
            {
                TypeBUS bus = new TypeBUS();
                bus.DelData(idTxtBox.Text, dataGridView.CurrentRow.Index);
                MessageBox.Show("Delete Succesfully!", "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void unselectBtn_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
            SettingDataGridView();

            searchTxtBox.Text = "";
            searchOpt.SelectedIndex = -1;

            addBtn.Enabled = true;
            dataGridView.CurrentCell = null;
            idTxtBox.Text = null;
            nameTxtBox.Text = null;
        }

        private void searchOpt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void searchTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void nameTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void idTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
