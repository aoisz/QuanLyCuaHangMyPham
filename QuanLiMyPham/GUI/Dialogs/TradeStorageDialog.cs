using Microsoft.Windows.Themes;
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

namespace QuanLiMyPham.GUI.Dialogs
{
    public partial class TradeStorageDialog : Form
    {
        public static string action = "";
        public TradeStorageDialog()
        {
            InitializeComponent();
            FillStorageCombobox();
            SettingDataGridView();
        }
        public void FillStorageCombobox()
        {

            StorageBUS StorageBUS = new StorageBUS();
            StorageBUS.SetTableData();
            DataTable dataTable = StorageBUS.storageList;
            List<string> comBoxItems = new List<string>();
            foreach (DataRow row in dataTable.Rows)
            {
                comBoxItems.Add(row["MA"].ToString());
            }
            storageBefore.Items.AddRange(comBoxItems.ToArray());
            storageAfter.Items.AddRange(comBoxItems.ToArray());
        }

        private void productPicker_Click(object sender, EventArgs e)
        {
            action = storageBefore.SelectedItem.ToString();
            ProductPicker dialog = new ProductPicker();
            dialog.ShowDialog();
            if (dialog.DialogResult == DialogResult.OK)
            {
                productIdTxtBox.Text = dialog.productSelectedId;
            }
        }
        public void SettingDataGridView()
        {
            dataGridView.Columns["MA"].Width = (int)(dataGridView.Width * 0.5);
            dataGridView.Columns["SOLUONG"].Width = (int)(dataGridView.Width * 0.5);
            /*            dataGridView.Columns["DONGIA"].Visible = false;
                        dataGridView.Columns["TEN"].Visible = false;
                        dataGridView.Columns["THANHTIEN"].Visible = false;*/

            dataGridView.Columns["MA"].HeaderText = "ID";
            dataGridView.Columns["SOLUONG"].HeaderText = "Quantity";
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
        public bool CheckQuantity()
        {
            string storageID = storageBefore.SelectedIndex.ToString();
            StorageDetailBUS storageDetailBUS = new StorageDetailBUS();
            string productID = productIdTxtBox.Text;
            string quantity = quantityPick.Value.ToString();
            StorageDetailBUS bus = new StorageDetailBUS();
            bus.SetTableData();
            foreach (DataRow row in StorageDetailBUS.storageDetailList.Rows)
            {
                if (row["MaKho"].ToString().Equals(storageID) && row["MaSP"].ToString().Equals(productID)) {
                    if (int.Parse(row["SOLUONG"].ToString()) < int.Parse(quantity))
                    {
                        return false;
                    }
                }

            }
            return true;
        }
        public void AddItem()
        {
            if (!CheckQuantity())
            {
                MessageBox.Show("Not enough quantity!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                productIdTxtBox.Text = string.Empty;
                quantityPick.Value = 0;
                return;
            }/*
            ProductBUS productBUS = new ProductBUS();
            productBUS.SetTableData();
            DataTable table = productBUS.searchByOption("id", productIdTxtBox.Text);
            DataRow row = table.Rows[0];
            string productId = row["MA"].ToString();
            string productName = row["TEN"].ToString();
            int quantity = Int32.Parse(quantityPick.Value.ToString());
            string price = row["DONGIA"].ToString();
            int totalPrice = Int32.Parse(price) * quantity;*/

            DataTable dataFromTable;
            if (dataGridView.DataSource == null)
            {
                dataFromTable = new DataTable();
                DataRow data = dataFromTable.NewRow();
                dataFromTable.Columns.Add("MA");
                dataFromTable.Columns.Add("SOLUONG");
                /*    dataFromTable.Columns.Add("TEN");
                    dataFromTable.Columns.Add("SOLUONG");
                    dataFromTable.Columns.Add("THANHTIEN");*/
                data["MA"] = productIdTxtBox.Text;
                data["SOLUONG"] = quantityPick.Value.ToString();
                /*data["TEN"] = productName;
                data["SOLUONG"] = quantity;
                data["THANHTIEN"] = totalPrice;*/

                dataFromTable.Rows.Add(data);
                dataGridView.Columns.Clear();
                dataGridView.DataSource = dataFromTable;
                SettingDataGridView();
            }
            else
            {
                dataFromTable = (DataTable)dataGridView.DataSource;
                int checkExisted = -1;
                foreach (DataRow dataRow in dataFromTable.Rows)
                {
                    if (dataRow["MA"].ToString().Equals(productIdTxtBox.Text))
                    {
                        checkExisted = dataFromTable.Rows.IndexOf(dataRow);
                    }
                }
                if (checkExisted > -1)
                {
                    int temp = int.Parse(dataFromTable.Rows[checkExisted]["SOLUONG"].ToString()) + int.Parse(quantityPick.Value.ToString());
                    dataFromTable.Rows[checkExisted]["SOLUONG"] = temp.ToString();
                    /*dataFromTable.Rows[checkExisted]["THANHTIEN"] = (int.Parse(dataFromTable.Rows[checkExisted]["SOLUONG"].ToString()) * int.Parse(dataFromTable.Rows[checkExisted]["DONGIA"].ToString()));*/
                }
                else
                {
                    DataRow data = dataFromTable.NewRow();
                    data["MA"] = productIdTxtBox.Text;
                    data["SOLUONG"] = quantityPick.Value.ToString();
                    /*  data["TEN"] = productName;
                      data["SOLUONG"] = quantity;
                      data["THANHTIEN"] = totalPrice;
  */
                    dataFromTable.Rows.Add(data);
                }
            }

            productIdTxtBox.Text = string.Empty;
            quantityPick.Value = 0;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void doneBTN_Click(object sender, EventArgs e)
        {
            DataTable table = (DataTable)dataGridView.DataSource;
            if (table == null || table.Rows.Count < 1)
            {
                MessageBox.Show("Please select at least a product!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            else if (storageAfter.SelectedIndex == -1 || storageBefore.SelectedIndex == -1)
            {
                MessageBox.Show("Choose storage!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            UpdateQuantity();
            MessageBox.Show("Trade successfully!", "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public void RefreshTable()
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                dataGridView.Rows.RemoveAt(i);
            }
            storageBefore.SelectedIndex = -1;
            storageAfter.SelectedIndex = -1;
        }
        public void UpdateQuantity()
        {
            DataTable dataTable = (DataTable)dataGridView.DataSource;
            StorageDetailBUS bus = new StorageDetailBUS();
            string idStorageAfter = storageAfter.SelectedItem.ToString();
            string idStorageBefore = storageBefore.SelectedItem.ToString();
            foreach (DataRow row in dataTable.Rows)
            {
                bus.UpDownQuantityTrade(new StorageDetailDTO(idStorageBefore, row["MA"].ToString(), row["SOLUONG"].ToString()));
                bus.UpdateQuantity(new StorageDetailDTO(idStorageAfter, row["MA"].ToString(), row["SOLUONG"].ToString()));
            }
            RefreshTable();
        }
    }
}
