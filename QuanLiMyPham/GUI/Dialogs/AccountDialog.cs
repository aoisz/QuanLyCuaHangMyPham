using QuanLiMyPham.BUS;
using QuanLiMyPham.DAO;
using QuanLiMyPham.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static Google.Protobuf.Reflection.FieldOptions.Types;

namespace QuanLiMyPham.GUI.Dialogs
{
    public partial class AccountDialog : Form
    {
        public AccountDTO account;
        public int index;
        public RoleDTO roleDTO;
        public AccountDialog(AccountDTO account, int index)
        {
            InitializeComponent();
            FillComboBox();
            if(AccountGUI.action.Equals("add"))
            {
                FillId();
            }
            else if(AccountGUI.action.Equals("edit"))
            {
                this.account = account;
                this.index = index;
                acceptBtn.Text = "EDIT";
                FillInformation();
            }
        }

        public void FillId()
        {
            AccountDAO dao = new AccountDAO();
            idTxtBox.Text = dao.GetNewID();
        }

        public void FillComboBox()
        {
            RoleBUS roleBUS = new RoleBUS();
            roleBUS.SetTableData();
            DataTable dataTable = RoleBUS.roleList;
            List<string> comBoxItems = new List<string>();
            foreach(DataRow row in dataTable.Rows) 
            {
                comBoxItems.Add(row["Ten"].ToString());
            }
            permissionComBox.Items.AddRange(comBoxItems.ToArray());
        }

        public void FillInformation()
        {
            idTxtBox.Text = account.id;
            loginNameTxtBox.Text = account.name;
            passwordTxtBox.Text = account.password;
            DataRow[] rows = RoleBUS.roleList.Select("MaQ like '%" + account.roleId +"%'");
            roleDTO = new RoleDTO(rows[0]["MaQ"].ToString(),
                                  rows[0]["Ten"].ToString()
            );
            permissionComBox.SelectedIndex = permissionComBox.Items.IndexOf(roleDTO.name);
        }

        public bool IsEmptyTxtBox()
        {
            if(loginNameTxtBox.Text == string.Empty ||
               passwordTxtBox.Text == string.Empty ||
               permissionComBox.SelectedIndex < 0
            )
            {
                return true;
            }
            return false;
        }

        public void AddAccount()
        {
            DataRow[] rows = RoleBUS.roleList.Select("Ten like '%" + permissionComBox.SelectedItem + "%'");
            roleDTO = new RoleDTO(rows[0]["MaQ"].ToString(),
                                  rows[0]["Ten"].ToString()
            );
            AccountBUS bus = new AccountBUS();
            bus.AddData(loginNameTxtBox.Text, passwordTxtBox.Text, roleDTO.id);
        }
        
        public void EditAccount()
        {
            DataRow[] rows = RoleBUS.roleList.Select("Ten like '%" + permissionComBox.SelectedItem + "%'");
            roleDTO = new RoleDTO(rows[0]["MaQ"].ToString(),
                                  rows[0]["Ten"].ToString()
            );
            account = new AccountDTO(idTxtBox.Text, loginNameTxtBox.Text, passwordTxtBox.Text, roleDTO.id);
            AccountBUS bus = new AccountBUS();
            bus.EditData(index,account);
        }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            if(IsEmptyTxtBox())
            {
                MessageBox.Show("Please enter all data required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (AccountGUI.action.Equals("add"))
            {
                AddAccount();
                MessageBox.Show("Add Succesfully!", "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(AccountGUI.action.Equals("edit"))
            {
                EditAccount();
                MessageBox.Show("Edit Succesfully!", "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Close();
        }
    }
}
