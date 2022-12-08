using MySqlX.XDevAPI.Relational;
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
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiMyPham.GUI
{
    public partial class InputProductGUI : UserControl
    {
        public InputProductGUI()
        {
            InitializeComponent();
            LoadData();
            SettingDataGridView();
            LoadNewID();
            FillDate();
            LoadinputTable();
            SettingInputTable();
            ShowRowAt(0);
        }
        public void ShowRowAt(int row)
        {
            InputIdTF.Text = inputTable.Rows[row].Cells["MA"].Value.ToString();
            employeeIdTF.Text = inputTable.Rows[row].Cells["MANV"].Value.ToString();
            storageIdTF.Text = inputTable.Rows[row].Cells["MAKHO"].Value.ToString();
            dateTF.Text = inputTable.Rows[row].Cells["NGAY"].Value.ToString();
            totalPriceTxtBox.Text = inputTable.Rows[row].Cells["TONGTIEN"].Value.ToString();

        }
        public void LoadinputTable()
        {
            inputTable.DataSource = InputBUS.inputList;
        }
        public void SettingInputTable()
        {
            inputTable.Columns["MA"].Width = (int)(inputTable.Width * 0.2);
            inputTable.Columns["MAKHO"].Width = (int)(inputTable.Width * 0.2);
            inputTable.Columns["MANV"].Width = (int)(inputTable.Width * 0.2);
            inputTable.Columns["NGAY"].Width = (int)(inputTable.Width * 0.2);
            inputTable.Columns["TONGTIEN"].Width = (int)(inputTable.Width * 0.2);


        }
        public void LoadData()
        {
            InputBUS bus = new InputBUS();
            bus.SetTableData();
            InputDetailBUS inputDetailBUS = new InputDetailBUS();
            inputDetailBUS.SetTableData();
        }

        public void LoadNewID()
        {
            InputDAO dao = new InputDAO();
            inputIdTxtBox.Text = dao.GetNewID();
        }

        public void FillDate()
        {
            dateTxtBox.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        public void RefreshTable()
        {
            for(int i = 0; i < detailTable.Rows.Count; i++)
            {
                detailTable.Rows.RemoveAt(i);
            }
        }

        public void SettingDataGridView()
        {
            detailTable.Columns["MA"].Width = (int)(detailTable.Width * 0.2);
            detailTable.Columns["TEN"].Width = (int)(detailTable.Width * 0.2);
            detailTable.Columns["DONGIA"].Width = (int)(detailTable.Width * 0.2);
            detailTable.Columns["SOLUONG"].Width = (int)(detailTable.Width * 0.2);
            detailTable.Columns["THANHTIEN"].Width = (int)(detailTable.Width * 0.2);

            detailTable.Columns["MA"].HeaderText = "Product ID";
            detailTable.Columns["TEN"].HeaderText = "Product Name";
            detailTable.Columns["DONGIA"].HeaderText = "Price";
            detailTable.Columns["SOLUONG"].HeaderText = "Quantity";
            detailTable.Columns["THANHTIEN"].HeaderText = "Total";
        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            if (productIdTxtBox.Text == string.Empty)
            {
                MessageBox.Show("Please choose a product!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (quantityPick.Value == 0)
            {
                MessageBox.Show("Quantity must be more than 0 !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            AddItem();
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
            string price = row["DONGIA"].ToString();
            int totalPrice = Int32.Parse(price) * quantity;

            DataTable dataFromTable;
            if (detailTable.DataSource == null)
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
                dataFromTable = (DataTable)detailTable.DataSource;
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
            UpdatePrice();
        }
        public void UpdatePrice()
        {
            int price = 0;
            foreach (DataGridViewRow row in detailTable.Rows)
            {
                price += Int32.Parse(row.Cells["THANHTIEN"].Value.ToString());
            }
            priceTotal.Text = price.ToString();
        }

        private void productPicker_Click(object sender, EventArgs e)
        {
            ProductPicker dialog = new ProductPicker();
            dialog.ShowDialog();
            if (dialog.DialogResult == DialogResult.OK)
            {
                productIdTxtBox.Text = dialog.productSelectedId;
            }
        }

        private void removeProductBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Remove " + detailTable.CurrentRow.Cells["MA"].Value.ToString() + " from list?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                DataTable dataTable = (DataTable)detailTable.DataSource;
                DataRow row = dataTable.Rows[detailTable.CurrentRow.Index];
                dataTable.Rows.Remove(row);
            }
            UpdatePrice();
        }

        private void employeePicker_Click(object sender, EventArgs e)
        {
            EmployeePicker dialog = new EmployeePicker();
            dialog.ShowDialog();
            if(dialog.DialogResult == DialogResult.OK)
            {
                employeeIdTxtBox.Text = dialog.employeeSelectedId;
            }
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            if (!CheckBeforeSubmit())
            {
                return;
            }
            DataTable dataTable = (DataTable)detailTable.DataSource;
            InputBUS inputBUS = new InputBUS();
            InputDetailBUS inputDetailBUS = new InputDetailBUS();

            //them vao phieu nhap
            DateTime temp = DateTime.ParseExact(dateTxtBox.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            InputDTO inputDTO = new InputDTO(
                inputIdTxtBox.Text,
                storageIdTxtBox.Text,
                employeeIdTxtBox.Text,
                temp.ToString("yyyy-MM-dd"),
                priceTotal.Text
            );
            inputBUS.AddData(inputDTO);

            //them vao chi tiet phieu nhap
            foreach (DataRow row in dataTable.Rows)
            {
                InputDetailDTO detailDTO = new InputDetailDTO(
                    inputIdTxtBox.Text,
                    row["MA"].ToString(),
                    row["DONGIA"].ToString(),
                    row["SOLUONG"].ToString(),
                    row["THANHTIEN"].ToString()
                );
                inputDetailBUS.AddData(detailDTO);
                //them so luong san pham vao kho
                StorageDetailBUS bus = new StorageDetailBUS();
                bus.UpdateQuantity(new StorageDetailDTO(storageIdTxtBox.Text, row["MA"].ToString(), row["SOLUONG"].ToString()));
            }
            MessageBox.Show("Create new receipt successfully!", "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
            RefreshTable();
            LoadNewID();
            FillDate();
            employeeIdTxtBox.Text = null;
            storageIdTxtBox.Text = null;
        }
        public bool CheckBeforeSubmit()
        {
            DataTable table = (DataTable)detailTable.DataSource;
            if (table == null || table.Rows.Count < 1)
            {
                MessageBox.Show("Please select at least a product!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            if (
                storageIdTxtBox.Text == string.Empty ||
                employeeIdTxtBox.Text == string.Empty
            
            )
            {
                MessageBox.Show("All input must be filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            return true;
        }
        private void storagePicker_Click(object sender, EventArgs e)
        {
            StoragePicker dialog = new StoragePicker();
            dialog.ShowDialog();
            if (dialog.DialogResult == DialogResult.OK)
            {
                storageIdTxtBox.Text = dialog.storageSelectedId;
            }
        }

        private void inputTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowRowAt(e.RowIndex);
        }

        private void showDetailBtn_Click(object sender, EventArgs e)
        {
            InputDetailDialog dialog = new InputDetailDialog(InputIdTF.Text);
            dialog.ShowDialog();
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Delete Input Products " + InputIdTF.Text + "?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            if (result == DialogResult.OK)
            {
                InputBUS bus = new InputBUS();
                bus.DelData(InputIdTF.Text, inputTable.CurrentRow.Index);
                InputDetailBUS detailBUS = new InputDetailBUS();
                detailBUS.DelData(InputIdTF.Text);
                MessageBox.Show("Delete Succesfully!", "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
            InputBUS bus = new InputBUS();
            DataTable list = bus.SearchByOption(searchOpt.SelectedItem.ToString(), searchTxtBox.Text);
            inputTable.DataSource = list;
            SettingInputTable();
        }

        private void unselectBtn_Click(object sender, EventArgs e)
        {
            LoadinputTable();
            SettingInputTable();
            searchTxtBox.Text = null;
            searchOpt.SelectedIndex = -1;
        }
    }
}
