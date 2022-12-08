using QuanLiMyPham.BUS;
using QuanLiMyPham.DAO;
using System.Security;

namespace QuanLiMyPham.GUI.Dialogs
{
    public partial class AddProductDialog : Form
    {
        string typeId = "";
        string prodId = "";
        OpenFileDialog openFile = null;
        public AddProductDialog()
        {
            InitializeComponent();
            SetID();
            SetImgPlaceHolder();
            SetDate();
        }

        public void SetID()
        {
            ProductDAO dao = new ProductDAO();
            idTxtBox.Text = dao.getNewID();
        }

        public void SetImgPlaceHolder()
        {
            productImg.Image = resizeImage(Image.FromFile("../../../Resource/Image/img_placeHolder.png"), new Size(166,166));
        }

        public void SetDate()
        {
            mfgDatePicker.Value = DateTime.Now;
            expDatePicker.Value = DateTime.Now;
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

        public Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        public bool CheckTxtBox()
        {
            if(nameTxtBox.Text.Equals("") || 
                typeId.Equals("") || 
                prodId.Equals("") || 
                priceTxtBox.Text.Equals("") || 
                ingredientTxtBox.Text.Equals("")
            )
            {
                return false;
            }
            if(openFile == null)
            {
                return false;
            }
            return true;
        }

        public bool CheckImage()
        {
            if (openFile == null)
            {
                return false;
            }
            return true;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if(CheckTxtBox())
            {
                if(!CheckPrice(priceTxtBox.Text))
                {
                    MessageBox.Show("Price must be a number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if(!CheckImage())
                {
                    MessageBox.Show("Please choose an image", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                ProductDAO dao = new ProductDAO();
                File.Copy(openFile.FileName, @"..\..\..\Resource\Image\Product\" + dao.getNewID() + ".jpg");
                openFile.Dispose();
                ProductBUS bus = new ProductBUS();
                string path = openFile.FileName;
                path = path.Replace("\\","/");
                bus.AddData(nameTxtBox.Text,
                    ingredientTxtBox.Text,
                    typeId,
                    prodId,
                    priceTxtBox.Text,
                    mfgDatePicker.Value.Date.ToString("dd/MM/yyyy"),
                    expDatePicker.Value.Date.ToString("dd/MM/yyyy"),
                    path.Substring(path.LastIndexOf("/")+1,8)
                );
                MessageBox.Show("Add Succesfully!", "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Please enter all data required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
            if(picker.DialogResult == DialogResult.OK)
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

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
