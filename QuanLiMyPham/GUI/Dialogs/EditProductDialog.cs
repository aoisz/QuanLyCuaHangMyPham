using QuanLiMyPham.BUS;
using QuanLiMyPham.DAO;
using QuanLiMyPham.DTO;
using System.Data;
using System.Security;

namespace QuanLiMyPham.GUI.Dialogs
{
    public partial class EditProductDialog : Form
    {
        OpenFileDialog openFile;
        string productId = "";
        string typeId = "";
        string prodId = "";
        int index = 0;
        public EditProductDialog(int index,string id)
        {
            this.productId = id;
            this.index = index;
            InitializeComponent();
            LoadProductInfor();
        }

        public EditProductDialog(string id)
        {
            this.productId = id;
            InitializeComponent();
            LoadProductInfor();
            BanControl();
        }
        //hàm của bên xem sản phẩm trong chi tiết kho
        public void BanControl()
        {
            imgPicker.Visible = false;
            editBtn.Visible = false;
            cancelBtn.Visible = false;
            idTxtBox.ReadOnly = true;
            nameTxtBox.ReadOnly = true;
            priceTxtBox.ReadOnly = true;
            ingredientTxtBox.ReadOnly = true;
            label7.Text = "Product " + productId;

        }
        public void LoadProductInfor()
        {
            ProductBUS bus = new ProductBUS();
            bus.SetTableData();
            DataRow[] product = ProductBUS.productList.Select("MA like '%" + productId + "%'");
            idTxtBox.Text = product[0]["MA"].ToString();
            nameTxtBox.Text = product[0]["TEN"].ToString();
            ingredientTxtBox.Text = product[0]["THANHPHAN"].ToString();

            string[] mfgDate = product[0]["NGAYSX"].ToString().Split("/");
            mfgDatePicker.Value = new DateTime(Int32.Parse(mfgDate[2]), Int32.Parse(mfgDate[1]), Int32.Parse(mfgDate[0]));

            string[] expDate = product[0]["HANSD"].ToString().Split("/");
            expDatePicker.Value = new DateTime(Int32.Parse(expDate[2]), Int32.Parse(expDate[1]), Int32.Parse(expDate[0]));

            typeTxtBox.Text = GetTypeName(product[0]["LOAIHANG"].ToString());
            productionTxtBox.Text = GetProductionName(product[0]["NSX"].ToString());

            priceTxtBox.Text = product[0]["DONGIA"].ToString();

            typeId = product[0]["LOAIHANG"].ToString();
            prodId = product[0]["NSX"].ToString();
            LoadImg();
        }

        public void LoadImg()
        {
            productImg.Image = resizeImage(Image.FromFile("../../../Resource/Image/Product/" + productId + ".jpg"), new Size(166,166));    
        }

        public string GetTypeName(string id)
        {
            string name = "";
            TypeBUS bus = new TypeBUS();
            bus.SetTableData();
            //DataRow[] rows = TypeBUS.typeList.Select("MA like '%" + id + "%'");
            foreach(DataRow row in TypeBUS.typeList.Rows)
            {
                if (row["MA"].ToString().Equals(id))
                {
                    name = row["TEN"].ToString();
                }
            }
            return name;
        }
        public string GetProductionName(string id)
        {
            string name = "";
            ProductionBUS bus = new ProductionBUS();
            bus.SetTableData();
            foreach (DataRow row in ProductionBUS.productionList.Rows)
            {
                if (row["MA"].ToString().Equals(id))
                {
                    name = row["TEN"].ToString();
                }
            }
            return name;
        }
        public bool CheckTxtBox()
        {
            if (nameTxtBox.Text.Equals("") ||
                typeId.Equals("") ||
                prodId.Equals("") ||
                priceTxtBox.Text.Equals("") ||
                ingredientTxtBox.Text.Equals("")
            )
            {
                return false;
            }
            return true;
        }
        public bool CheckPrice(string price)
        {
            try
            {
                Double.Parse(price);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool IsDiffImage()
        {
            if(openFile != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void imgPicker_Click(object sender, EventArgs e)
        {
            openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    productImg.Image = resizeImage(Image.FromFile(openFile.FileName), new Size(166, 166));
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }

        }

        private void typePickerBtn_Click(object sender, EventArgs e)
        {
            TypePicker picker = new TypePicker();
            picker.ShowDialog();
            if (picker.DialogResult == DialogResult.OK)
            {
                typeId = picker.type.id;
                typeTxtBox.Text = picker.type.name;
            }
        }

        private void productionPickerBtn_Click(object sender, EventArgs e)
        {
            ProductionPicker picker = new ProductionPicker();
            picker.ShowDialog();
            if (picker.DialogResult == DialogResult.OK)
            {
                prodId = picker.production.id;
                productionTxtBox.Text = picker.production.name;
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (CheckTxtBox())
            {
                if (!CheckPrice(priceTxtBox.Text))
                {
                    MessageBox.Show("Price must be a number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if(IsDiffImage())
                {
                    File.Delete(@"..\..\..\Resource\Image\Product\" + productId + ".jpg");
                    File.Copy(openFile.FileName, @"..\..\..\Resource\Image\Product\" + productId + ".jpg");
                    openFile.Dispose();
                }
                ProductBUS bus = new ProductBUS();
                ProductDTO productDTO = new ProductDTO(idTxtBox.Text,
                    nameTxtBox.Text,
                    typeId,
                    ingredientTxtBox.Text,
                    mfgDatePicker.Value.ToString("dd/MM/yyyy"),
                    expDatePicker.Value.ToString("dd/MM/yyyy"),
                    productId,
                    priceTxtBox.Text,
                    idTxtBox.Text + ".jpg");
                bus.EditData(index, productDTO);
                MessageBox.Show("Edit Succesfully!", "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Please enter all data required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
