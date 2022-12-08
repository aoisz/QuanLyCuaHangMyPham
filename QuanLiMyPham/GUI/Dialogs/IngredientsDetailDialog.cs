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
    public partial class IngredientsDetailDialog : Form
    {
        string ingredientsString = "";
        public IngredientsDetailDialog(string ingredientsString)
        {
            this.ingredientsString= ingredientsString;
            InitializeComponent();
            IngredientsToTable();
        }

        private void IngredientsToTable()
        {
            DataTable table = new DataTable();
            string[] ingredients = ingredientsString.Split(", ");
            table.Columns.Add("Ingredients", typeof(string));
            for(int i = 0; i < ingredients.Length; i++)
            {
                DataRow row = table.NewRow();
                row["Ingredients"] = ingredients[i];
                table.Rows.Add(row);
            }

            dataGridView.DataSource = table;
            dataGridView.Columns["Ingredients"].Width = dataGridView.Width;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
