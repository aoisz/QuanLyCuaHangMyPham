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
using System.Windows.Forms;

namespace QuanLiMyPham.GUI.Dialogs
{
    public partial class RoleDialog : Form
    {
        public RoleDTO role = new RoleDTO();
        Dictionary<string, ComboBox> functions = new Dictionary<string, ComboBox>();
        public int index;
        public RoleDialog(int index, RoleDTO roleDTO)
        {
            InitializeComponent();
            SettingDictionary();
            if(RoleGUI.action.Equals("add"))
            {
                GetID();
                FillNone();
            }
            else if(RoleGUI.action.Equals("edit"))
            {
                this.role = roleDTO;
                this.index = index;
                SetInformation();
                LoadRoleDetailList();
                addBtn.Text = "Edit";
            }
        }

        public void FillNone()
        {
            foreach(var item in functions)
            {
                item.Value.SelectedIndex = 0;
            }
        }

        public void GetID()
        {
            RoleDAO roleDAO = new RoleDAO();
            idTxtBox.Text = roleDAO.GetNewID();
        }

        public void SetInformation()
        {
            idTxtBox.Text = role.id;
            nameTxtBox.Text = role.name;
        }
        public void LoadRoleDetailList()
        {
            RoleDetailBUS bus = new RoleDetailBUS();
            DataRow[] roleDetails = bus.GetDetailById(role.id);
            foreach (DataRow row in roleDetails)
            {
                foreach (KeyValuePair<string, ComboBox> kvp in functions)
                {
                    if (row["TENBANG"].ToString().Equals(kvp.Key))
                    {
                        kvp.Value.Text = row["CHUCNANG"].ToString();
                    }
                }
            }
        }

        public void SettingDictionary()
        {
            functions.Add("sanpham", productComBox);
            functions.Add("hoadon", receiptComBox);
            functions.Add("phieunhap", inputComBox);
            functions.Add("ctkhuyenmai", promotionComBox);
            functions.Add("khachhang", customerComBox);
            functions.Add("nhanvien", employeeComBox);
            functions.Add("nhasanxuat", productionComBox);
            functions.Add("quyen", roleComBox);
            functions.Add("taikhoan", accountComBox);
            functions.Add("kho", storageComBox);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddRole()
        {
            if(nameTxtBox.Text == string.Empty)
            {
                MessageBox.Show("Name is empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            RoleBUS roleBUS = new RoleBUS();
            roleBUS.AddData(nameTxtBox.Text);
            RoleDetailBUS roleDetail = new RoleDetailBUS();
            foreach(var item in functions)
            {
                roleDetail.AddData(item.Key.ToString(), item.Value.GetItemText(item.Value.SelectedItem.ToString()), idTxtBox.Text);
            }
            MessageBox.Show("Add Succesfully!", "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void EditRole()
        {
            if (nameTxtBox.Text == string.Empty)
            {
                MessageBox.Show("Name is empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            RoleBUS roleBUS = new RoleBUS();
            roleBUS.EditData(index,new RoleDTO(idTxtBox.Text,nameTxtBox.Text));
            RoleDetailBUS roleDetail = new RoleDetailBUS();
            foreach (var item in functions)
            {
                RoleDetailDTO dto = new RoleDetailDTO(item.Key.ToString(), item.Value.GetItemText(item.Value.SelectedItem.ToString()), idTxtBox.Text);
                roleDetail.EditData(index, dto);
            }
            MessageBox.Show("Edit Succesfully!", "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if(RoleGUI.action.Equals("add"))
            {
                AddRole();
            }
            else if(RoleGUI.action.Equals("edit"))
            {
                EditRole();
            }
        }
    }
}
