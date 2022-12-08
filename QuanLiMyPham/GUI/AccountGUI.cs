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
    public partial class AccountGUI : UserControl
    {
        public static string action = "";
        public AccountGUI()
        {
            InitializeComponent();
            LoadDataGridView();
            SettingDataGridView();
            ShowRowAtIndex(0);
        }

        public void LoadDataGridView()
        {
            AccountBUS bus = new AccountBUS();
            bus.SetTableData();
            dataGridView.DataSource = AccountBUS.accountList;
        }

        public void SettingDataGridView()
        {
            dataGridView.Columns["MA"].Width = (int)(dataGridView.Width * 0.21);
            dataGridView.Columns["TENDANGNHAP"].Width = (int)(dataGridView.Width * 0.25);
            dataGridView.Columns["MATKHAU"].Width = (int)(dataGridView.Width * 0.25);
            dataGridView.Columns["MaQ"].Width = (int)(dataGridView.Width * 0.25);

            dataGridView.Columns["MA"].HeaderText = "ID";
            dataGridView.Columns["TENDANGNHAP"].HeaderText = "Login Name";
            dataGridView.Columns["MATKHAU"].HeaderText = "Password";
            dataGridView.Columns["MaQ"].HeaderText = "Permission";
        }

        public void ShowRowAtIndex(int index)
        {
            idTxtBox.Text = dataGridView.Rows[index].Cells["MA"].Value.ToString();
            loginNameTxtBox.Text = dataGridView.Rows[index].Cells["TENDANGNHAP"].Value.ToString();
            passwordTxtBox.Text = dataGridView.Rows[index].Cells["MATKHAU"].Value.ToString();
        }

        private void unselectBtn_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            action = "add";
            AccountDTO account = new AccountDTO(dataGridView.CurrentRow.Cells["MA"].Value.ToString(),
                                                dataGridView.CurrentRow.Cells["TENDANGNHAP"].Value.ToString(),
                                                dataGridView.CurrentRow.Cells["MATKHAU"].Value.ToString(),
                                                dataGridView.CurrentRow.Cells["MaQ"].Value.ToString()
            );
            AccountDialog dialog = new AccountDialog(account, dataGridView.CurrentRow.Index);
            dialog.ShowDialog();
        }

        private void delBtn_Click(object sender, EventArgs e)
        {

        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            action = "edit";
            AccountDTO account = new AccountDTO(dataGridView.CurrentRow.Cells["MA"].Value.ToString(),
                                                dataGridView.CurrentRow.Cells["TENDANGNHAP"].Value.ToString(),
                                                dataGridView.CurrentRow.Cells["MATKHAU"].Value.ToString(),
                                                dataGridView.CurrentRow.Cells["MaQ"].Value.ToString()
            );
            AccountDialog dialog = new AccountDialog(account, dataGridView.CurrentRow.Index);
            dialog.ShowDialog();

        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            RoleDetailsDialog roleDetailGUI  = new RoleDetailsDialog(dataGridView.CurrentRow.Cells["MaQ"].Value.ToString());
            roleDetailGUI.ShowDialog();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowRowAtIndex(e.RowIndex);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
