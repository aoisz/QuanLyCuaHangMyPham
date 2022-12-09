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

        public void ProductBarGraph()
        {
            formsPlot.Reset();
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
            Dictionary<string, int> typeQuantities = GetType();
            double[] values = new double[typeQuantities.Count];
            string[] labels = new string[typeQuantities.Count];
            int index = 0;
            foreach (var type in typeQuantities)
            {
                labels[index] = type.Key;
                values[index] = type.Value;
                index++;
            }
            var pie = formsPlot.Plot.AddPie(values);
            pie.SliceLabels = labels;
            pie.ShowValues = true;
            formsPlot.Plot.Legend();
            formsPlot.Plot.AxisAuto();

            formsPlot.Plot.SaveFig("pie_legend.png");
            formsPlot.Refresh();
        }

        public Dictionary<string,int> GetType()
        {
            Dictionary<string, int> typeQuantities = new Dictionary<string, int>();
            TypeBUS typeBUS = new TypeBUS();
            typeBUS.SetTableData();
            ProductBUS productBUS = new ProductBUS();
            productBUS.SetTableData();

            foreach(DataRow typeRow in TypeBUS.typeList.Rows)
            {
                typeQuantities.Add(typeRow["TEN"].ToString(), 0);
                foreach(DataRow productRow in ProductBUS.productList.Rows)
                {
                    if (productRow["LOAIHANG"].ToString().Equals(typeRow["MA"]))
                    {
                        if(typeQuantities.ContainsKey(typeRow["TEN"].ToString()))
                        {
                            typeQuantities[typeRow["TEN"].ToString()] += 1;
                        }
                    }
                }   
            }
            return typeQuantities;
        }

        public void SalesBarGraph()
        {
            formsPlot.Reset();

            Dictionary<string, int> dict = GetSalesByMonths();
            double[] values = new double[dict.Count];
                //{ 1230000, 11300000, 16200000, 16300000, 17200000, 16600000, 15200000, 26000000, 21000000, 13000000, 25000000, 24300000 };
            double[] positions = new double[dict.Count];
            //{ 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            string[] labels = new string[dict.Count];
            //{ "1/2022", "2/2022", "3/2022", "4/2022", "5/2022", "6/2022", "7/2022", "8/2022", "9/2022", "10/2022", "11/2022", "12/2022" };
            int index = 0;
            foreach (var pair in dict)
            {
                labels[index] = pair.Key;
                values[index] = pair.Value;
                positions[index] = index;
                index++;
            }
            var bar = formsPlot.Plot.AddBar(values, positions);
            bar.ShowValuesAboveBars = true;
            formsPlot.Plot.XTicks(positions, labels);
            formsPlot.Plot.SetAxisLimits(yMin: 0);
            formsPlot.Plot.SaveFig("bar_labels.png");
            formsPlot.Refresh();
        }

        public Dictionary<string,int> GetSalesByMonths()
        {
            ReceiptBUS receiptBUS = new ReceiptBUS();
            receiptBUS.SetTableData();
            Dictionary<string, int> sales = receiptBUS.GetAllMonthSale();
            return sales;
        }

        public void EmployeeSoldMostReceiptBarGraph()
        {
            formsPlot.Reset();

            Dictionary<string, int> dict = SoldMostEmployee();
            double[] values = new double[dict.Count];
            double[] positions = new double[dict.Count];
            string[] labels = new string[dict.Count];
            /*double[] values = { 5, 4, 4, 3, 2 };
            double[] positions = { 0, 1, 2, 3, 4 };
            string[] labels = { "NV01", "NV05", "NV04", "NV03", "NV06" };*/

            int index = 0;
            foreach(var pair in dict)
            {
                labels[index] = pair.Key;
                values[index] = pair.Value;
                positions[index] = index;
                index++;
            }

            var bar = formsPlot.Plot.AddBar(values, positions);
            bar.ShowValuesAboveBars = true;
            formsPlot.Plot.XTicks(positions, labels);
            formsPlot.Plot.SetAxisLimits(yMin: 0);
            formsPlot.Plot.SaveFig("bar_labels.png");
            formsPlot.Refresh();
        }

        public Dictionary<string, int> SoldMostEmployee()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            ReceiptBUS receiptBUS = new ReceiptBUS();
            receiptBUS.SetTableData();
            EmployeeBUS employeeBUS = new EmployeeBUS();
            employeeBUS.SetTableData();

            foreach (DataRow row in EmployeeBUS.employeeList.Rows)
            {
                int count = receiptBUS.CountByEmployeeId(row["MANV"].ToString());
                dict.Add(row["MANV"].ToString(), count);
            }

            return dict.OrderByDescending(pair => pair.Value).Take(5)
               .ToDictionary(pair => pair.Key, pair => pair.Value);
        }

        private void comboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            /*top 5 sp bán nhiều nhất, 
            phần trăm từng loại sản phẩm, 
            doanh thu theo tháng, 
            top 5 nhân viên bán nhiều hóa đơn nhất*/
            /*if (comboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Select an search option", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/
            if (comboBox.SelectedIndex == 0)
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
                SalesBarGraph();
                /*BarGraphReceipt();*/
            }
            else
            {
                EmployeeSoldMostReceiptBarGraph();
                /*BarGraphEmpoyee();*/
            }
        }
    }
}
