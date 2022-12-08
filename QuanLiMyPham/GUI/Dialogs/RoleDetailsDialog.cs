
using QuanLiMyPham.BUS;
using System.Data;

namespace QuanLiMyPham.GUI.Dialogs
{
    public partial class RoleDetailsDialog : Form
    {
        public string id;
        Dictionary<string, TextBox> functionList;
        public RoleDetailsDialog(string id)
        {
            functionList = new Dictionary<string, TextBox>();
            this.id = id;
            InitializeComponent();
            SettingDictionary();
            LoadRoleDetailList();
        }

        public void LoadRoleDetailList()
        {
            RoleDetailBUS bus = new RoleDetailBUS();
            DataRow[] roleDetails = bus.GetDetailById(id);
            foreach(DataRow row in roleDetails)
            {
                foreach(KeyValuePair<string, TextBox> kvp in functionList)
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
            functionList.Add("sanpham", productTxtBox);
            functionList.Add("hoadon", receiptTxtBox);
            functionList.Add("phieunhap", inputTxtBox);
            functionList.Add("ctkhuyenmai", promotionTxtBox);
            functionList.Add("khachhang", customerTxtBox);
            functionList.Add("nhanvien", employeeTxtBox);
            functionList.Add("nhasanxuat", productionTxtBox);
            functionList.Add("quyen", roleTxtBox);
            functionList.Add("taikhoan", accountTxtBox);
            functionList.Add("kho", storageTxtBox);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
