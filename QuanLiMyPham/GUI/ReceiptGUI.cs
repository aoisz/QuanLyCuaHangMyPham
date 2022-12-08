using MySqlX.XDevAPI.Relational;
using QuanLiMyPham.BUS;
using QuanLiMyPham.DAO;
using QuanLiMyPham.DTO;
using QuanLiMyPham.GUI.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiMyPham.GUI
{
    public partial class ReceiptGUI : UserControl
    {
        public ReceiptGUI()
        {
            InitializeComponent();
            LoadData();
            SettingDataGridView();
            LoadNewID();
            FillDate();
            LoadReceiptTable();
            SettingReceiptTable();
            ShowRowAt(0);
        }

        public void LoadData()
        {
            ReceiptBUS receiptBUS = new ReceiptBUS();
            receiptBUS.SetTableData();
            ReceiptDetailBUS receiptDetailBUS = new ReceiptDetailBUS();
            receiptDetailBUS.SetTableData();
        }
        // --- Create new receipt ---
        public void LoadNewID()
        {
            ReceiptDAO receiptDAO = new ReceiptDAO();
            detail_receiptIdTxtBox.Text = receiptDAO.GetNewID();
        }

        public void FillDate()
        {
            detail_dateTxtBox.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        public void SettingDataGridView()
        {
            detailTable.Columns["MA"].Width = (int)(detailTable.Width *0.16);
            detailTable.Columns["TEN"].Width = (int)(detailTable.Width *0.2);
            detailTable.Columns["DONGIA"].Width = (int)(detailTable.Width *0.2);
            detailTable.Columns["SOLUONG"].Width = (int)(detailTable.Width *0.2);
            detailTable.Columns["THANHTIEN"].Width = (int)(detailTable.Width *0.2);
        

            detailTable.Columns["MA"].HeaderText = "Product ID";
            detailTable.Columns["TEN"].HeaderText = "Product Name";
            detailTable.Columns["DONGIA"].HeaderText = "Price";
            detailTable.Columns["SOLUONG"].HeaderText = "Quantity";
            detailTable.Columns["THANHTIEN"].HeaderText = "Total";
        }

        public Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        public void UpdateDiscount()
        {
            PromotionBUS promotionBUS = new PromotionBUS();
            promotionBUS.SetTableData();
        }

        public void UpdatePriceBeforeDiscount()
        {
            int price = 0;
            foreach(DataGridViewRow row in detailTable.Rows)
            {
                price += Int32.Parse(row.Cells["THANHTIEN"].Value.ToString());
            }
            detail_totalPrice.Text = price.ToString();
        }

        public void UpdatePriceAfterDiscount()
        {
            int price = 0;
        }

        public void AddItem()
        {
            ProductBUS productBUS = new ProductBUS();
            productBUS.SetTableData();
            DataTable table = productBUS.searchByOption("id", productIdTxtBox.Text);
            DataRow row = table.Rows[0];
            string productId = row["MA"].ToString();
            string productName = row["TEN"].ToString();
            int quantity = Int32.Parse(quantityPick.Value.ToString());
            double price = double.Parse(row["DONGIA"].ToString());
            int totalPrice = (int)(price) * quantity;
            
            DataTable dataFromTable = (DataTable) detailTable.DataSource;
            if (dataFromTable == null)
            {
                dataFromTable = new DataTable();
                DataRow data = dataFromTable.NewRow();
                dataFromTable.Columns.Add("MA");
                dataFromTable.Columns.Add("TEN");
                dataFromTable.Columns.Add("DONGIA");
                dataFromTable.Columns.Add("SOLUONG");
                dataFromTable.Columns.Add("THANHTIEN");
                data["MA"] = productId;
                data["TEN"] = productName;
                data["DONGIA"] = price;
                data["SOLUONG"] = quantity;
                data["THANHTIEN"] = totalPrice;

                dataFromTable.Rows.Add(data);
                detailTable.Columns.Clear();
                detailTable.DataSource = dataFromTable;
                SettingDataGridView();
            }
            else
            {
                int checkExisted = -1;
                foreach (DataRow dataRow in dataFromTable.Rows)
                {
                    if (dataRow["MA"].ToString().Equals(productId))
                    {
                        checkExisted = dataFromTable.Rows.IndexOf(dataRow);
                    }
                }
                if (checkExisted > -1)
                {
                    int temp = int.Parse(dataFromTable.Rows[checkExisted]["SOLUONG"].ToString()) + quantity;
                    dataFromTable.Rows[checkExisted]["SOLUONG"] = temp.ToString();
                    dataFromTable.Rows[checkExisted]["THANHTIEN"] = (int.Parse(dataFromTable.Rows[checkExisted]["SOLUONG"].ToString()) * int.Parse(dataFromTable.Rows[checkExisted]["DONGIA"].ToString()));
                }
                else
                {
                    DataRow data = dataFromTable.NewRow();
                    data["MA"] = productId;
                    data["TEN"] = productName;
                    data["DONGIA"] = price;
                    data["SOLUONG"] = quantity;
                    data["THANHTIEN"] = totalPrice;

                    dataFromTable.Rows.Add(data);
                }

            }

            productIdTxtBox.Text = string.Empty;
            quantityPick.Value = 0;
            UpdatePriceBeforeDiscount();
        }

        public bool CheckBeforeSubmit()
        {
            DataTable table = (DataTable)detailTable.DataSource;
            if(table == null || table.Rows.Count < 1)
            {
                MessageBox.Show("Please select at least a product!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            if(
                detail_customerIdTxtBox.Text == string.Empty ||    
                detail_employeeIdTxtBox.Text == string.Empty 
                /*|| detail_discountTxtBox.Text == string.Empty*/
            )
            {
                MessageBox.Show("All input must be filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            return true;
        }

        private void productPicker_Click(object sender, EventArgs e)
        {
            ProductPicker dialog = new ProductPicker();
            dialog.ShowDialog();
            if(dialog.DialogResult== DialogResult.OK)
            {
                productIdTxtBox.Text = dialog.productSelectedId;
            }
        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            if(productIdTxtBox.Text == string.Empty)
            {
                MessageBox.Show("Please choose a product!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if(quantityPick.Value == 0)
            {
                MessageBox.Show("Quantity must be more than 0 !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            AddItem();
        }

        private void removeProductBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Remove " + detailTable.CurrentRow.Cells["MA"].Value.ToString() + " from list?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(dialogResult == DialogResult.OK)
            {
                DataTable dataTable = (DataTable)detailTable.DataSource;
                DataRow row = dataTable.Rows[detailTable.CurrentRow.Index];
                dataTable.Rows.Remove(row);
            }
        }

        private void customerPicker_Click(object sender, EventArgs e)
        {
            CustomerPicker dialog = new CustomerPicker();
            dialog.ShowDialog();
            if(dialog.DialogResult == DialogResult.OK)
            {
                detail_customerIdTxtBox.Text = dialog.customerSelectedId;
            }
        }

        private void employeePicker_Click(object sender, EventArgs e)
        {
            EmployeePicker dialog = new EmployeePicker();
            dialog.ShowDialog();
            if (dialog.DialogResult == DialogResult.OK)
            {
                detail_employeeIdTxtBox.Text = dialog.employeeSelectedId;
            }
        }

        private void promotionPicker_Click(object sender, EventArgs e)
        {
            int currentPrice = int.Parse(detail_totalPrice.Text);
            PromotionPicker dialog = new PromotionPicker();
            dialog.LoadDataGridView(currentPrice);
            if(!dialog.CheckAnyAvailable())
            {
                MessageBox.Show("Have no promotion available!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dialog.ShowDialog();
            if (dialog.DialogResult == DialogResult.OK)
            {
                detail_discountTxtBox.Text = dialog.id;
                int before = (int)(double.Parse(detail_totalPrice.Text));
                int discount = (int)(double.Parse(dialog.discountValue) * double.Parse(detail_totalPrice.Text));
                int afterDiscount = before - discount;
                detail_afterDiscountPrice.Text = afterDiscount.ToString();
            }
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            if(!CheckBeforeSubmit())
            {
                return;
            }
            DataTable dataTable = (DataTable)detailTable.DataSource;
            ReceiptBUS receiptBUS = new ReceiptBUS();
            ReceiptDetailBUS receiptDetailBUS = new ReceiptDetailBUS();

            //them vao hoa don
            DateTime temp = DateTime.ParseExact(detail_dateTxtBox.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            ReceiptDTO receiptDTO = new ReceiptDTO(
                detail_receiptIdTxtBox.Text, 
                detail_employeeIdTxtBox.Text, 
                detail_customerIdTxtBox.Text,
                temp.ToString("yyyy-MM-dd"), 
                detail_totalPrice.Text,
                detail_discountTxtBox.Text, 
                detail_afterDiscountPrice.Text
            );
            receiptBUS.AddData(receiptDTO);

            //them vao chi tiet hoa don
            foreach (DataRow row in dataTable.Rows)
            {
                ReceiptDetailDTO detailDTO = new ReceiptDetailDTO(
                    detail_receiptIdTxtBox.Text, 
                    row["MA"].ToString(), 
                    row["DONGIA"].ToString(), 
                    row["SOLUONG"].ToString(), 
                    detail_totalPrice.Text
                );
                receiptDetailBUS.AddData(detailDTO);
            }
            MessageBox.Show("Create new receipt successfully!", "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
        }
        // --- End create new receipt ---

        // --- Manage receipt ---
        public void LoadReceiptTable()
        {
            receiptTable.DataSource = ReceiptBUS.receiptList;
        }

        public void SettingReceiptTable()
        {
            receiptTable.Columns["MA"].Width = (int)(receiptTable.Width * 0.13);
            receiptTable.Columns["MANV"].Width = (int)(receiptTable.Width * 0.13);
            receiptTable.Columns["MAKH"].Width = (int)(receiptTable.Width * 0.13);
            receiptTable.Columns["NGAY"].Width = (int)(receiptTable.Width * 0.14);
            receiptTable.Columns["TONGTIEN"].Width = (int)(receiptTable.Width * 0.14);
            receiptTable.Columns["MACTKM"].Width = (int)(receiptTable.Width * 0.14);
            receiptTable.Columns["TONGTIENSAUKM"].Width = (int)(receiptTable.Width * 0.14);

            receiptTable.Columns["MA"].HeaderText = "Receipt ID";
            receiptTable.Columns["MANV"].HeaderText = "Employee ID";
            receiptTable.Columns["MAKH"].HeaderText = "Customer ID";
            receiptTable.Columns["NGAY"].HeaderText = "Date";
            receiptTable.Columns["TONGTIEN"].HeaderText = "Total Price";
            receiptTable.Columns["MACTKM"].HeaderText = "Promotion ID";
            receiptTable.Columns["TONGTIENSAUKM"].HeaderText = "After Discount";
        }

        public void ShowRowAt(int row)
        {
            receiptIdTxtBox.Text = receiptTable.Rows[row].Cells["MA"].Value.ToString();
            employeeIdTxtBox.Text = receiptTable.Rows[row].Cells["MANV"].Value.ToString();
            customerIdTxtBox.Text = receiptTable.Rows[row].Cells["MAKH"].Value.ToString();
            dateTxtBox.Text = receiptTable.Rows[row].Cells["NGAY"].Value.ToString();
            totalPriceTxtBox.Text = receiptTable.Rows[row].Cells["TONGTIEN"].Value.ToString();
            promotionIdTxtBox.Text = receiptTable.Rows[row].Cells["MACTKM"].Value.ToString();
            afterDiscountTxtBox.Text = receiptTable.Rows[row].Cells["TONGTIENSAUKM"].Value.ToString();
        }

        private void showDetailBtn_Click(object sender, EventArgs e)
        {
            ReceiptDetailDialog dialog = new ReceiptDetailDialog();
            dialog.LoadDetailTable(receiptIdTxtBox.Text);
            dialog.ShowDialog();
        }

        private void receiptTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowRowAt(e.RowIndex);
        }

        private void delBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
