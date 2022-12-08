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
    public partial class EmployeePicker : Form
    {
        public string employeeSelectedId;
        public EmployeePicker()
        {
            InitializeComponent();
            LoadDataGridView();
            SettingDataGridView();
        }

        public void LoadDataGridView()
        {
            EmployeeBUS employeeBUS = new EmployeeBUS();
            employeeBUS.SetTableData();
            dataGridView.DataSource = EmployeeBUS.employeeList;
        }

        public void SettingDataGridView()
        {
            dataGridView.Columns["MANV"].Width = (int)(dataGridView.Width * 0.30);
            dataGridView.Columns["HO"].Width = (int)(dataGridView.Width * 0.33);
            dataGridView.Columns["TEN"].Width = (int)(dataGridView.Width * 0.33);

            dataGridView.Columns["MANV"].HeaderText = "ID";
            dataGridView.Columns["HO"].HeaderText = "Last Name";
            dataGridView.Columns["TEN"].HeaderText = "First Name";


            dataGridView.Columns["DIACHI"].Visible = false;
            dataGridView.Columns["GIOITINH"].Visible = false;
            dataGridView.Columns["LUONG"].Visible = false;
            dataGridView.Columns["NAMSINH"].Visible = false;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chooseBtn_Click(object sender, EventArgs e)
        {
            employeeSelectedId = dataGridView.CurrentRow.Cells["MANV"].Value.ToString();
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
