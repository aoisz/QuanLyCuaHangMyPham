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
    public partial class EmployeeGUI : UserControl
    {
        public static string action = "";
        public EmployeeGUI()
        {
            InitializeComponent();
            LoadDataGridView();
            SettingDataGridView();
            ShowRowAtIndex(0);
        }
        public void LoadDataGridView()
        {
            EmployeeBUS bus = new EmployeeBUS();
            bus.SetTableData();
            dataGridView.DataSource = EmployeeBUS.employeeList;
        }

        public void SettingDataGridView()
        {
            /*dataGridView.Columns[0].Width = (int)(dataGridView.Width * 0.13);
            dataGridView.Columns[1].Width = (int)(dataGridView.Width * 0.14);
            dataGridView.Columns[2].Width = (int)(dataGridView.Width * 0.14);
            dataGridView.Columns[3].Width = (int)(dataGridView.Width * 0.142);
            dataGridView.Columns[4].Width = (int)(dataGridView.Width * 0.13);
            dataGridView.Columns[5].Width = (int)(dataGridView.Width * 0.14);
            dataGridView.Columns[6].Width = (int)(dataGridView.Width * 0.14);*/
            dataGridView.Columns["MANV"].Width = (int)(dataGridView.Width * 0.13);
            dataGridView.Columns["HO"].Width = (int)(dataGridView.Width * 0.14);
            dataGridView.Columns["TEN"].Width = (int)(dataGridView.Width * 0.14);
            dataGridView.Columns["DIACHI"].Width = (int)(dataGridView.Width * 0.142);
            dataGridView.Columns["GIOITINH"].Width = (int)(dataGridView.Width * 0.13);
            dataGridView.Columns["LUONG"].Width = (int)(dataGridView.Width * 0.14);
            dataGridView.Columns["NAMSINH"].Width = (int)(dataGridView.Width * 0.13);


            dataGridView.Columns["MANV"].HeaderText = "ID";
            dataGridView.Columns["HO"].HeaderText = "Last Name";
            dataGridView.Columns["TEN"].HeaderText = "First Name";
            dataGridView.Columns["DIACHI"].HeaderText = "Address";
            dataGridView.Columns["GIOITINH"].HeaderText = "Gender";
            dataGridView.Columns["LUONG"].HeaderText = "Salary";
            dataGridView.Columns["NAMSINH"].HeaderText = "Year of birth";
        }
        public void ShowRowAtIndex(int index)
        {
            idTxtBox.Text = dataGridView.Rows[index].Cells["MANV"].Value.ToString();
            lastNameTxtBox.Text = dataGridView.Rows[index].Cells["HO"].Value.ToString();
            firstNameTxtBox.Text = dataGridView.Rows[index].Cells["TEN"].Value.ToString();
            addressTxtBox.Text = dataGridView.Rows[index].Cells["DIACHI"].Value.ToString();
            genderTxtBox.Text = dataGridView.Rows[index].Cells["GIOITINH"].Value.ToString();
            salaryTxtBox.Text = dataGridView.Rows[index].Cells["LUONG"].Value.ToString();
            yobTxtBox.Text = dataGridView.Rows[index].Cells["NAMSINH"].Value.ToString();
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
            EmployeeBUS bus = new EmployeeBUS();
            DataTable list = bus.SearchByOption(searchOpt.SelectedItem.ToString(), searchTxtBox.Text);
            dataGridView.DataSource = list;
            SettingDataGridView();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            action = "add";
            /* TypeDTO type = new TypeDTO(dataGridView.CurrentRow.Cells["MA"].Value.ToString(),
                                                 dataGridView.CurrentRow.Cells["TEN"].Value.ToString()
             );*/
            EmployeeDialog dialog = new EmployeeDialog();
            dialog.ShowDialog();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            action = "edit";
            EmployeeDTO temp = new EmployeeDTO();
            temp.id = idTxtBox.Text;
            temp.lastName = lastNameTxtBox.Text;
            temp.firstName = firstNameTxtBox.Text;
            temp.address = addressTxtBox.Text;
            temp.gender = genderTxtBox.Text;
            temp.salary = salaryTxtBox.Text;
            temp.yob = yobTxtBox.Text;

            EmployeeDialog dialog = new EmployeeDialog();
            dialog.ShowData(temp);
            dialog.ShowDialog();
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Delete employee " + lastNameTxtBox.Text.ToString() + " " + lastNameTxtBox.Text.ToString() + "?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            if (result == DialogResult.OK)
            {
                EmployeeBUS bus = new EmployeeBUS();
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
            lastNameTxtBox.Text = null;
            yobTxtBox.Text = null;
            firstNameTxtBox.Text = null;
            salaryTxtBox.Text = null;
            genderTxtBox.Text = null;
            addressTxtBox.Text = null;
        }
    }
}
