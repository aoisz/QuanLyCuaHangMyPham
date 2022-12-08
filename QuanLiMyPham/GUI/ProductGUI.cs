using QuanLiMyPham.BUS;
using QuanLiMyPham.DTO;
using QuanLiMyPham.GUI.Dialogs;
using System.Data;
using System.Windows.Forms;

namespace QuanLiMyPham.GUI
{
    public partial class ProductGUI : UserControl
    {
        public ProductGUI()
        {
            InitializeComponent();
            LoadDataGridView();
            SettingDataGridView();
            ShowRowAtIndex(0);

            LoadProductionList();
            LoadTypeList();
            productionFilterComboBox.SelectedIndex = -1;
            typeFilterComboBox.SelectedIndex = -1;
        }

        public Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        public void LoadDataGridView()
        {
            ProductBUS bus = new ProductBUS();
            bus.SetTableData();
            dataGridView.DataSource = ProductBUS.productList;
        }

        public void SettingDataGridView()
        {
            dataGridView.Columns["LOAIHANG"].Visible = false;
            dataGridView.Columns["THANHPHAN"].Visible = false;
            dataGridView.Columns["NGAYSX"].Visible = false;
            dataGridView.Columns["HANSD"].Visible = false;
            dataGridView.Columns["NSX"].Visible = false;
            dataGridView.Columns["HINHANH"].Visible = false;

            dataGridView.Columns["MA"].Width = (int)(dataGridView.Width * 0.1);
            dataGridView.Columns["TEN"].Width = (int)(dataGridView.Width * 0.4469);
            dataGridView.Columns["DONGIA"].Width = (int)(dataGridView.Width * 0.2);
            dataGridView.Columns["SOLUONG"].Width = (int)(dataGridView.Width * 0.2);

            dataGridView.Columns["MA"].HeaderText = "ID";
            dataGridView.Columns["TEN"].HeaderText = "PRODUCT NAME";
            dataGridView.Columns["DONGIA"].HeaderText = "PRICE";
            dataGridView.Columns["SOLUONG"].HeaderText = "QUANTITY";
        }

        public void ShowRowAtIndex(int index)
        {
            productImg.Image = resizeImage(Image.FromFile("../../../Resource/Image/Product/" + dataGridView.Rows[index].Cells[0].Value + ".jpg"), new Size(166, 166));
            idTxtBox.Text = dataGridView.Rows[index].Cells["MA"].Value.ToString();
            nameTxtBox.Text = dataGridView.Rows[index].Cells["TEN"].Value.ToString();
            typeTxtBox.Text = dataGridView.Rows[index].Cells["LOAIHANG"].Value.ToString();
            productionTxtBox.Text = dataGridView.Rows[index].Cells["NSX"].Value.ToString();
            priceTxtBox.Text = dataGridView.Rows[index].Cells["DONGIA"].Value.ToString();
            quantityTxtBox.Text = dataGridView.Rows[index].Cells["SOLUONG"].Value.ToString();
            mfgDateTxtBox.Text = dataGridView.Rows[index].Cells["NGAYSX"].Value.ToString();
            expDateTxtBox.Text = dataGridView.Rows[index].Cells["HANSD"].Value.ToString();
        }

        public void LoadProductionList()
        {
            ProductionBUS productionBUS = new ProductionBUS();
            productionBUS.SetTableData();
            List<string> productions = new List<string>();
            foreach(DataRow row in ProductionBUS.productionList.Rows)
            {
                productions.Add(row["TEN"].ToString());
            }
            productionFilterComboBox.DataSource = productions;
        }

        public void LoadTypeList()
        {
            TypeBUS typeBus = new TypeBUS();
            typeBus.SetTableData();
            List<string> types = new List<string>();
            foreach(DataRow row in TypeBUS.typeList.Rows) 
            {
                types.Add(row["TEN"].ToString());
            }
            typeFilterComboBox.DataSource = types;
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowRowAtIndex(dataGridView.CurrentRow.Index);
        }

        private void filterPriceViewBtn_Click(object sender, EventArgs e)
        {
            ProductBUS bus = new ProductBUS();
            dataGridView.DataSource = bus.PriceFilter(minPriceTxtBox.Text, maxPriceTxtBox.Text);
        }

        private void unselectBtn_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
            ShowRowAtIndex(0);

            minPriceTxtBox.Text = null;
            maxPriceTxtBox.Text = null;
            searchTxtBox.Text = null;
            typeFilterComboBox.SelectedIndex = -1;
            productionFilterComboBox.SelectedIndex = -1;
            searchOpt.SelectedIndex = -1;
        }

        private void quantityDetailBtn_Click(object sender, EventArgs e)
        {
            QuantityDetailDialog dialog = new QuantityDetailDialog(dataGridView.CurrentRow.Cells["MA"].Value.ToString());
            dialog.ShowDialog();
        }

        private void typeFilterComboBox_TextUpdate(object sender, EventArgs e)
        {
        }

        private void typeFilterComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ProductBUS bus = new ProductBUS();
            dataGridView.DataSource = bus.TypeFilter(typeFilterComboBox.SelectedItem.ToString());
        }

        private void productionFilterComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ProductBUS bus = new ProductBUS();
            dataGridView.DataSource = bus.ProductionFilter(productionFilterComboBox.SelectedItem.ToString());
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if(searchOpt.SelectedIndex == -1 || searchTxtBox.Text == null || searchTxtBox.Text == "")
            {
                MessageBox.Show("Please choose an option and enter data for searching!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (searchOpt.SelectedIndex == 0)
            {
                ProductBUS bus = new ProductBUS();
                dataGridView.DataSource = bus.searchByOption("id",searchTxtBox.Text);
            }
            else
            {
                ProductBUS bus = new ProductBUS();
                dataGridView.DataSource = bus.searchByOption("name", searchTxtBox.Text);
            }
        }

        private void ingredientsViewBtn_Click(object sender, EventArgs e)
        {
            IngredientsDetailDialog dialog = new IngredientsDetailDialog(dataGridView.CurrentRow.Cells["THANHPHAN"].Value.ToString());
            dialog.ShowDialog();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddProductDialog dialog = new AddProductDialog();
            dialog.ShowDialog();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            EditProductDialog dialog = new EditProductDialog(dataGridView.CurrentRow.Index,dataGridView.CurrentRow.Cells[0].Value.ToString());
            dialog.ShowDialog();
            int index = dataGridView.CurrentRow.Index;
            if(dialog.DialogResult == DialogResult.OK)
            {
                dataGridView.ClearSelection();
                dataGridView.Rows[index].Selected = true;
                dataGridView.Rows[index].Cells[0].Selected = true;
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            ProductBUS bus = new ProductBUS();
            string id = dataGridView.CurrentRow.Cells[0].Value.ToString();
            DialogResult dialog = MessageBox.Show("Are you sure to delete " + id, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if(dialog == DialogResult.Yes)
            {
                bus.DelData(id, dataGridView.CurrentRow.Index);
                productImg.Image = null;
                File.Delete(@"..\..\..\Resource\Image\Product\" + id + ".jpg");
                MessageBox.Show(id + " deleted");
            }
        }
    }
}
