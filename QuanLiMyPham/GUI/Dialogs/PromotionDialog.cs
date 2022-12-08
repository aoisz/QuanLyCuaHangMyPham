using QuanLiMyPham.BUS;
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
    public partial class PromotionDialog : Form
    {
        public PromotionDialog()
        {
            InitializeComponent();
            if (PromotionGUI.action.Equals("add"))
            {
                FillId();
            }
            else if (PromotionGUI.action.Equals("edit"))
            {
                title.Text = "Edit Promotion";
                acceptBtn.Text = "EDIT";
            }
        }

        public void ShowData(PromotionDTO promotionDTO)
        {
            idTxtBox.Text = promotionDTO.id;
            nameTxtBox.Text = promotionDTO.name;
            discountTxtBox.Text = promotionDTO.discount;
            minTxtBox.Text = promotionDTO.minPrice;
            maxTxtBox.Text = promotionDTO.maxPrice;
        }

        public void FillId()
        {
            PromotionBUS promotion = new PromotionBUS();
            idTxtBox.Text = promotion.FillId();
        }

        public bool IsNumeric(string text)
        {
            try
            {
                int num = int.Parse(text);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool IsDouble(string text)
        {
            try
            {
                double num = double.Parse(text);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public void AddData()
        {
            if (nameTxtBox.Text == string.Empty ||
                idTxtBox.Text == string.Empty || 
                discountTxtBox.Text == string.Empty || 
                minTxtBox.Text == string.Empty || 
                maxTxtBox.Text == string.Empty  
            )
            {
                MessageBox.Show("Please enter all data required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(!IsNumeric(minTxtBox.Text) || !IsNumeric(maxTxtBox.Text) || !IsDouble(discountTxtBox.Text))
            {
                MessageBox.Show("Maximum and minimum must be number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PromotionBUS bus = new PromotionBUS();
            bus.AddData(new PromotionDTO(idTxtBox.Text, nameTxtBox.Text, discountTxtBox.Text, minTxtBox.Text, maxTxtBox.Text));
            MessageBox.Show("Add Succesfully!", "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        public void EditData()
        {
            if (nameTxtBox.Text == string.Empty ||
                idTxtBox.Text == string.Empty ||
                discountTxtBox.Text == string.Empty ||
                minTxtBox.Text == string.Empty ||
                maxTxtBox.Text == string.Empty
            )
            {
                MessageBox.Show("Please enter all data required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!IsNumeric(minTxtBox.Text) || !IsNumeric(maxTxtBox.Text) || !IsDouble(discountTxtBox.Text))
            {
                MessageBox.Show("Maximum and minimum must be number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            PromotionBUS bus = new PromotionBUS();
            bus.EditData(new PromotionDTO(idTxtBox.Text, nameTxtBox.Text, discountTxtBox.Text, minTxtBox.Text, maxTxtBox.Text));
            MessageBox.Show("Edit Succesfully!", "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
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

            if (PromotionGUI.action.Equals("add"))
            {
                AddData();
            }
            else if (PromotionGUI.action.Equals("edit"))
            {
                EditData();
            }
            /*            try
                        {
                            MessageBox.Show(double.Parse(discountTxtBox.Text).ToString());
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show("cc");
                        }*/
        }
    }
}
