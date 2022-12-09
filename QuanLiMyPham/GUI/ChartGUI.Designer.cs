namespace QuanLiMyPham.GUI
{
    partial class ChartGUI
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.formsPlot = new ScottPlot.FormsPlot();
            this.SuspendLayout();
            // 
            // comboBox
            // 
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Sản phẩm bán chạy",
            "Loại sản phẩm",
            "Doanh thu",
            "Hóa đơn theo nhân viên"});
            this.comboBox.Location = new System.Drawing.Point(469, 42);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(470, 36);
            this.comboBox.TabIndex = 0;
            this.comboBox.SelectionChangeCommitted += new System.EventHandler(this.comboBox_SelectionChangeCommitted);
            // 
            // formsPlot
            // 
            this.formsPlot.BackColor = System.Drawing.Color.White;
            this.formsPlot.Location = new System.Drawing.Point(189, 125);
            this.formsPlot.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.formsPlot.Name = "formsPlot";
            this.formsPlot.Size = new System.Drawing.Size(1004, 554);
            this.formsPlot.TabIndex = 0;
            // 
            // ChartGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.formsPlot);
            this.Controls.Add(this.comboBox);
            this.Name = "ChartGUI";
            this.Size = new System.Drawing.Size(1400, 716);
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox comboBox;
        private ScottPlot.FormsPlot formsPlot;
    }
}
