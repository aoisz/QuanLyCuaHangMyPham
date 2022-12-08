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
using System.Windows.Forms;

namespace QuanLiMyPham.GUI
{
    public partial class CustomerGUI : UserControl
    {
        public static string action = "";
        public CustomerGUI()
        {
            InitializeComponent();
            loadListView();
            SettingDataGridView();
            searchOpt.SelectedIndex = 0;
            ShowRowAt(0);
        }

        public void loadListView()
        {
            CustomerBUS customer = new CustomerBUS();
            customer.SetTableData();
            dataGridView.DataSource = CustomerBUS.customerList;
        }

        public void SettingDataGridView()
        {
            dataGridView.Columns[0].HeaderText = "ID";
            dataGridView.Columns[1].HeaderText = "Họ";
            dataGridView.Columns[2].HeaderText = "Tên";
            dataGridView.Columns[3].HeaderText = "SDT";
            dataGridView.Columns[0].Width = (int)(dataGridView.Width*0.20);
            dataGridView.Columns[1].Width = (int)(dataGridView.Width * 0.25);
            dataGridView.Columns[2].Width = (int)(dataGridView.Width * 0.25);
            dataGridView.Columns[3].Width = (int)(dataGridView.Width * 0.25);
        }

        private void unselectBtn_Click(object sender, EventArgs e)
        {
            Unselect();
        }
        public void Unselect()
        {
            loadListView();
            SettingDataGridView();

            searchTxtBox.Text = "";
            searchOpt.SelectedIndex = -1;

            addBtn.Enabled = true;
            dataGridView.CurrentCell = null;
            idTxtBox.Text = null;
            lastNameTxtBox.Text = null;
            firstNameTxtBox.Text = null;
            phoneTxtBox.Text = null;
        }
        private void searchBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(searchOpt.SelectedItem.ToString());
            if(searchOpt.SelectedIndex == -1)
            {
                MessageBox.Show("Select an search option", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(searchTxtBox.Text == "" || searchTxtBox.Text == "")
            {
                MessageBox.Show("Please enter data to search!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CustomerBUS bus = new CustomerBUS();
            DataTable data = null;
            if(searchOpt.SelectedIndex == 0)
            {
                data = bus.searchByOption("id", searchTxtBox.Text);
                if(data.Rows.Count < 1)
                {
                    MessageBox.Show("Have no result!", "No result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                dataGridView.DataSource = bus.searchByOption("id",searchTxtBox.Text);
            }
            else if(searchOpt.SelectedIndex == 1)
            {
                data = bus.searchByOption("name", searchTxtBox.Text);
                if (data.Rows.Count < 1)
                {
                    MessageBox.Show("Have no result!", "No result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                dataGridView.DataSource = bus.searchByOption("name", searchTxtBox.Text);
            }
            else if(searchOpt.SelectedIndex == 2)
            {
                data = bus.searchByOption("phone", searchTxtBox.Text);
                if (data.Rows.Count < 1)
                {
                    MessageBox.Show("Have no result!", "No result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                dataGridView.DataSource = bus.searchByOption("phone", searchTxtBox.Text);
            }
            SettingDataGridView();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            action = "add";
            CustomerDialog dialog = new CustomerDialog();
            dialog.ShowDialog();
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if(dataGridView.SelectedRows.Count > 0) 
            {
                DialogResult result = MessageBox.Show("Delete customer " + idTxtBox.Text + "?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                {
                    CustomerBUS bus = new CustomerBUS();
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
            CustomerDialog dialog = new CustomerDialog();
            dialog.FillData(new CustomerDTO(dataGridView.CurrentRow.Cells["MAKH"].Value.ToString(), dataGridView.CurrentRow.Cells["TEN"].Value.ToString(), dataGridView.CurrentRow.Cells["HO"].Value.ToString(), dataGridView.CurrentRow.Cells["SDT"].Value.ToString()));
            dialog.ShowDialog();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowRowAt(e.RowIndex);
        }
        public void ShowRowAt(int index)
        {
            idTxtBox.Text = dataGridView.Rows[index].Cells[0].Value.ToString();
            lastNameTxtBox.Text = dataGridView.Rows[index].Cells[1].Value.ToString();
            firstNameTxtBox.Text = dataGridView.Rows[index].Cells[2].Value.ToString();
            phoneTxtBox.Text = dataGridView.Rows[index].Cells[3].Value.ToString();
        }
    }
}
