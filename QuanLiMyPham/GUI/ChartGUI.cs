using QuanLiMyPham.BUS;
using ScottPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiMyPham.GUI
{
    public partial class ChartGUI : UserControl
    {
        public ChartGUI()
        {
            InitializeComponent();
            //formsPlot.Visible = false;
            SelectFirstItem();
        }

        public void SelectFirstItem()
        {
            comboBox.SelectedIndex = 0;
            ProductBarGraph();
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            /*top 5 sp bán nhiều nhất, 
            phần trăm từng loại sản phẩm, 
            doanh thu theo tháng, 
            top 5 nhân viên bán nhiều hóa đơn nhất*/
            if (comboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Select an search option", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (comboBox.SelectedIndex == 0)
            {
                ProductBarGraph();
            }
            else if (comboBox.SelectedIndex == 1)
            {
                TypePieChart();
                /* PieChartType();*/
            }
            else if (comboBox.SelectedIndex == 2)
            {
                TurnOverBarGraph();
                /*BarGraphReceipt();*/
            }
            else
            {
                EmployeeSoldMostReceiptBarGraph();
                /*BarGraphEmpoyee();*/
            }
        }

        public void ProductBarGraph()
        {
            Dictionary<string, int> dict = GetMostSellProduct();
            double[] values = new double[5];
            double[] positions = { 0, 1, 2, 3, 4 };
            string[] labels = new string[5];
            int index = 0;
            foreach (var kvp in dict)
            {
                labels[index] = kvp.Key;
                values[index] = kvp.Value;
                index++;
            }

            var bar = formsPlot.Plot.AddBar(values, positions);
            bar.ShowValuesAboveBars = true;
            formsPlot.Plot.XTicks(positions, labels);
            formsPlot.Plot.SetAxisLimits(yMin: 0);
            formsPlot.Plot.SaveFig("bar_labels.png");
            formsPlot.Refresh();
        }

        public Dictionary<string, int> GetMostSellProduct()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            ReceiptDetailBUS receiptDetailBUS = new ReceiptDetailBUS();
            receiptDetailBUS.SetTableData();
            ProductBUS productBUS = new ProductBUS();
            productBUS.SetTableData();

            foreach (DataRow row in ProductBUS.productList.Rows)
            {
                int count = receiptDetailBUS.GetQuantityByProductId(row["MA"].ToString());
                dict.Add(row["MA"].ToString(), count);
            }

            return dict.OrderByDescending(pair => pair.Value).Take(5)
               .ToDictionary(pair => pair.Key, pair => pair.Value);
        }

        public void TypePieChart()
        {
            formsPlot.Reset();
            double[] values = { 11, 10, 10 };
            string[] labels = { "ML01", "ML02", "ML03" };
            var pie = formsPlot.Plot.AddPie(values);
            pie.SliceLabels = labels;
            pie.ShowValues = true;
            formsPlot.Plot.Legend();
            formsPlot.Plot.AxisAuto();

            formsPlot.Plot.SaveFig("pie_legend.png");
            formsPlot.Refresh();
        }

        public void TurnOverBarGraph()
        {
            formsPlot.Reset();

            Dictionary<string, int> dict = GetMostSellProduct();
            double[] values = { 1230000, 11300000, 16200000, 16300000, 17200000, 16600000, 15200000, 26000000, 21000000, 13000000, 25000000, 24300000 };
            double[] positions = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            string[] labels = { "1/2022", "2/2022", "3/2022", "4/2022", "5/2022", "6/2022", "7/2022", "8/2022", "9/2022", "10/2022", "11/2022", "12/2022" };

            var bar = formsPlot.Plot.AddBar(values, positions);
            bar.ShowValuesAboveBars = true;
            formsPlot.Plot.XTicks(positions, labels);
            formsPlot.Plot.SetAxisLimits(yMin: 0);
            formsPlot.Plot.SaveFig("bar_labels.png");
            formsPlot.Refresh();
        }

        public void EmployeeSoldMostReceiptBarGraph()
        {
            formsPlot.Reset();

            Dictionary<string, int> dict = GetMostSellProduct();
            double[] values = { 5, 4, 4, 3, 2 };
            double[] positions = { 0, 1, 2, 3, 4 };
            string[] labels = { "NV01", "NV05", "NV04", "NV03", "NV06" };

            var bar = formsPlot.Plot.AddBar(values, positions);
            bar.ShowValuesAboveBars = true;
            formsPlot.Plot.XTicks(positions, labels);
            formsPlot.Plot.SetAxisLimits(yMin: 0);
            formsPlot.Plot.SaveFig("bar_labels.png");
            formsPlot.Refresh();
        }
    }
}
