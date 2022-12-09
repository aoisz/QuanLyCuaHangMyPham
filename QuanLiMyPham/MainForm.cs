
using MySql.Data.MySqlClient;
using QuanLiMyPham.BUS;
using QuanLiMyPham.GUI;
using System.Data;

namespace QuanLiMyPham
{
    public partial class MainForm : Form
    {
        public static string accountId = "";
        public MainForm(String idAccount)
        {
            accountId = idAccount;
            InitializeComponent();
            
        }

        public void ShowWelcome()
        {
            WelcomeGUI welcomeGUI = new WelcomeGUI();
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(welcomeGUI);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowNameAccount();
            ShowWelcome();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
            login.Closed += (s, args) => this.Close();
        }

        private void ShowNameAccount()
        {
            AccountBUS accountBUS = new AccountBUS();
            accountBUS.SetTableData();
            string name = "";
            foreach(DataRow row in AccountBUS.accountList.Rows)
            {
                if (row["MA"].ToString().Equals(accountId))
                {
                    name += row["TENDANGNHAP"].ToString();
                }
            }
            accountInfor.Text += name;
        }

        private void receiptBtn_Click(object sender, EventArgs e)
        {
            ReceiptGUI receiptGUI = new ReceiptGUI();
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(receiptGUI);
            receiptBtn.BackColor = Color.Navy;
        }

        private void customerBtn_Click(object sender, EventArgs e)
        {
            CustomerGUI customerGUI = new CustomerGUI();
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(customerGUI);
            customerBtn.BackColor = Color.Navy;
        }

        private void productionBtn_Click(object sender, EventArgs e)
        {
            ProductionGUI productionGUI = new ProductionGUI();
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(productionGUI);
            productionBtn.BackColor = Color.Navy;
        }

        private void productBtn_Click(object sender, EventArgs e)
        {
            ProductGUI productGUI = new ProductGUI();
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(productGUI);
            productBtn.BackColor = Color.Navy;
        }

        private void roleBtn_Click(object sender, EventArgs e)
        {
            RoleGUI roleGUI = new RoleGUI();
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(roleGUI);
        }

        private void accountBtn_Click(object sender, EventArgs e)
        {
            AccountGUI accountGUI = new AccountGUI();
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(accountGUI);
            accountBtn.BackColor = Color.Navy;
        }

        private void productTypeBtn_Click(object sender, EventArgs e)
        {
            ProductTypeGUI productTypeGUI = new ProductTypeGUI();
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(productTypeGUI);
            productTypeBtn.BackColor = Color.Navy;
        }

        private void employeeBtn_Click(object sender, EventArgs e)
        {
            EmployeeGUI employeeGUI = new EmployeeGUI();
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(employeeGUI);
            employeeBtn.BackColor = Color.Navy;
        }

        private void promotionBtn_Click(object sender, EventArgs e)
        {
            PromotionGUI promotionGUI = new PromotionGUI();
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(promotionGUI);
            promotionBtn.BackColor = Color.Navy;
        }

        private void inputProductBtn_Click(object sender, EventArgs e)
        {
            InputProductGUI inputGUI = new InputProductGUI();
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(inputGUI);
            inputProductBtn.BackColor = Color.Navy;
        }

        private void storageBtn_Click(object sender, EventArgs e)
        {
            StorageGUI storageGUI = new StorageGUI();
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(storageGUI);
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            ChartGUI chartGUI = new ChartGUI();
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(chartGUI);
        }
    }
}