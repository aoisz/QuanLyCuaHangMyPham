namespace QuanLiMyPham.GUI
{
    partial class ReceiptGUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.detailTab = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.removeProductBtn = new FontAwesome.Sharp.IconButton();
            this.addProductBtn = new FontAwesome.Sharp.IconButton();
            this.quantityPick = new System.Windows.Forms.NumericUpDown();
            this.detail_afterDiscountPrice = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.detail_totalPrice = new System.Windows.Forms.Label();
            this.detailTable = new System.Windows.Forms.DataGridView();
            this.MA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THANHTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.productIdTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.productPicker = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.detail_employeeIdTxtBox = new System.Windows.Forms.TextBox();
            this.detail_customerIdTxtBox = new System.Windows.Forms.TextBox();
            this.promotionPicker = new System.Windows.Forms.Button();
            this.doneBtn = new FontAwesome.Sharp.IconButton();
            this.employeePicker = new System.Windows.Forms.Button();
            this.customerPicker = new System.Windows.Forms.Button();
            this.detail_discountTxtBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.detail_dateTxtBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.detail_receiptIdTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.receiptTab = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.delBtn = new FontAwesome.Sharp.IconButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.searchTxtBox = new System.Windows.Forms.TextBox();
            this.searchBtn = new FontAwesome.Sharp.IconButton();
            this.unselectBtn = new FontAwesome.Sharp.IconButton();
            this.searchOpt = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.showDetailBtn = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.dateTxtBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.afterDiscountTxtBox = new System.Windows.Forms.TextBox();
            this.promotionIdTxtBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.totalPriceTxtBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.customerIdTxtBox = new System.Windows.Forms.TextBox();
            this.receiptIdTxtBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.employeeIdTxtBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.receiptTable = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.detailTab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityPick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.receiptTab.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receiptTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.detailTab);
            this.tabControl.Controls.Add(this.receiptTab);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1400, 716);
            this.tabControl.TabIndex = 0;
            // 
            // detailTab
            // 
            this.detailTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.detailTab.Controls.Add(this.groupBox2);
            this.detailTab.Controls.Add(this.groupBox1);
            this.detailTab.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.detailTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.detailTab.Location = new System.Drawing.Point(4, 29);
            this.detailTab.Name = "detailTab";
            this.detailTab.Padding = new System.Windows.Forms.Padding(3);
            this.detailTab.Size = new System.Drawing.Size(1392, 683);
            this.detailTab.TabIndex = 0;
            this.detailTab.Text = "Receipt Detail";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.removeProductBtn);
            this.groupBox2.Controls.Add(this.addProductBtn);
            this.groupBox2.Controls.Add(this.quantityPick);
            this.groupBox2.Controls.Add(this.detail_afterDiscountPrice);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.detail_totalPrice);
            this.groupBox2.Controls.Add(this.detailTable);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.productIdTxtBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.productPicker);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(899, 677);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Receipt Detail";
            // 
            // removeProductBtn
            // 
            this.removeProductBtn.BackColor = System.Drawing.Color.Red;
            this.removeProductBtn.FlatAppearance.BorderSize = 0;
            this.removeProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeProductBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.removeProductBtn.ForeColor = System.Drawing.Color.Black;
            this.removeProductBtn.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.removeProductBtn.IconColor = System.Drawing.Color.Black;
            this.removeProductBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.removeProductBtn.IconSize = 36;
            this.removeProductBtn.Location = new System.Drawing.Point(558, 121);
            this.removeProductBtn.Name = "removeProductBtn";
            this.removeProductBtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.removeProductBtn.Size = new System.Drawing.Size(160, 40);
            this.removeProductBtn.TabIndex = 16;
            this.removeProductBtn.Text = "REMOVE";
            this.removeProductBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.removeProductBtn.UseVisualStyleBackColor = false;
            this.removeProductBtn.Click += new System.EventHandler(this.removeProductBtn_Click);
            // 
            // addProductBtn
            // 
            this.addProductBtn.BackColor = System.Drawing.Color.Lime;
            this.addProductBtn.FlatAppearance.BorderSize = 0;
            this.addProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProductBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addProductBtn.ForeColor = System.Drawing.Color.Black;
            this.addProductBtn.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.addProductBtn.IconColor = System.Drawing.Color.Black;
            this.addProductBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addProductBtn.IconSize = 40;
            this.addProductBtn.Location = new System.Drawing.Point(558, 73);
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.addProductBtn.Size = new System.Drawing.Size(160, 40);
            this.addProductBtn.TabIndex = 15;
            this.addProductBtn.Text = "ADD";
            this.addProductBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addProductBtn.UseVisualStyleBackColor = false;
            this.addProductBtn.Click += new System.EventHandler(this.addProductBtn_Click);
            // 
            // quantityPick
            // 
            this.quantityPick.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quantityPick.Location = new System.Drawing.Point(151, 130);
            this.quantityPick.Name = "quantityPick";
            this.quantityPick.Size = new System.Drawing.Size(250, 34);
            this.quantityPick.TabIndex = 14;
            // 
            // detail_afterDiscountPrice
            // 
            this.detail_afterDiscountPrice.AutoSize = true;
            this.detail_afterDiscountPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.detail_afterDiscountPrice.ForeColor = System.Drawing.Color.White;
            this.detail_afterDiscountPrice.Location = new System.Drawing.Point(708, 230);
            this.detail_afterDiscountPrice.Name = "detail_afterDiscountPrice";
            this.detail_afterDiscountPrice.Size = new System.Drawing.Size(23, 28);
            this.detail_afterDiscountPrice.TabIndex = 13;
            this.detail_afterDiscountPrice.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(546, 230);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 28);
            this.label10.TabIndex = 12;
            this.label10.Text = "After Discount:";
            // 
            // detail_totalPrice
            // 
            this.detail_totalPrice.AutoSize = true;
            this.detail_totalPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.detail_totalPrice.ForeColor = System.Drawing.Color.White;
            this.detail_totalPrice.Location = new System.Drawing.Point(151, 230);
            this.detail_totalPrice.Name = "detail_totalPrice";
            this.detail_totalPrice.Size = new System.Drawing.Size(23, 28);
            this.detail_totalPrice.TabIndex = 11;
            this.detail_totalPrice.Text = "0";
            // 
            // detailTable
            // 
            this.detailTable.AllowUserToAddRows = false;
            this.detailTable.AllowUserToDeleteRows = false;
            this.detailTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.detailTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.detailTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detailTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MA,
            this.TEN,
            this.SOLUONG,
            this.THANHTIEN,
            this.DONGIA});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.detailTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.detailTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.detailTable.Location = new System.Drawing.Point(3, 273);
            this.detailTable.Name = "detailTable";
            this.detailTable.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.detailTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.detailTable.RowHeadersWidth = 51;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.detailTable.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.detailTable.RowTemplate.Height = 29;
            this.detailTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.detailTable.Size = new System.Drawing.Size(893, 401);
            this.detailTable.TabIndex = 10;
            // 
            // MA
            // 
            this.MA.HeaderText = "Product ID";
            this.MA.MinimumWidth = 6;
            this.MA.Name = "MA";
            this.MA.ReadOnly = true;
            this.MA.Width = 125;
            // 
            // TEN
            // 
            this.TEN.HeaderText = "Name";
            this.TEN.MinimumWidth = 6;
            this.TEN.Name = "TEN";
            this.TEN.ReadOnly = true;
            this.TEN.Width = 125;
            // 
            // SOLUONG
            // 
            this.SOLUONG.HeaderText = "Quantity";
            this.SOLUONG.MinimumWidth = 6;
            this.SOLUONG.Name = "SOLUONG";
            this.SOLUONG.ReadOnly = true;
            this.SOLUONG.Width = 125;
            // 
            // THANHTIEN
            // 
            this.THANHTIEN.HeaderText = "Price";
            this.THANHTIEN.MinimumWidth = 6;
            this.THANHTIEN.Name = "THANHTIEN";
            this.THANHTIEN.ReadOnly = true;
            this.THANHTIEN.Width = 125;
            // 
            // DONGIA
            // 
            this.DONGIA.HeaderText = "dongia";
            this.DONGIA.MinimumWidth = 6;
            this.DONGIA.Name = "DONGIA";
            this.DONGIA.ReadOnly = true;
            this.DONGIA.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Product ID";
            // 
            // productIdTxtBox
            // 
            this.productIdTxtBox.Enabled = false;
            this.productIdTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productIdTxtBox.Location = new System.Drawing.Point(151, 70);
            this.productIdTxtBox.Name = "productIdTxtBox";
            this.productIdTxtBox.Size = new System.Drawing.Size(200, 34);
            this.productIdTxtBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(32, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Quantity";
            // 
            // productPicker
            // 
            this.productPicker.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productPicker.ForeColor = System.Drawing.Color.Black;
            this.productPicker.Location = new System.Drawing.Point(357, 70);
            this.productPicker.Name = "productPicker";
            this.productPicker.Size = new System.Drawing.Size(44, 35);
            this.productPicker.TabIndex = 5;
            this.productPicker.Text = "...";
            this.productPicker.UseVisualStyleBackColor = true;
            this.productPicker.Click += new System.EventHandler(this.productPicker_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(28, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total Price:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.detail_employeeIdTxtBox);
            this.groupBox1.Controls.Add(this.detail_customerIdTxtBox);
            this.groupBox1.Controls.Add(this.promotionPicker);
            this.groupBox1.Controls.Add(this.doneBtn);
            this.groupBox1.Controls.Add(this.employeePicker);
            this.groupBox1.Controls.Add(this.customerPicker);
            this.groupBox1.Controls.Add(this.detail_discountTxtBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.detail_dateTxtBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.detail_receiptIdTxtBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(908, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 677);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Receipt Information";
            // 
            // detail_employeeIdTxtBox
            // 
            this.detail_employeeIdTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.detail_employeeIdTxtBox.Location = new System.Drawing.Point(171, 222);
            this.detail_employeeIdTxtBox.Name = "detail_employeeIdTxtBox";
            this.detail_employeeIdTxtBox.ReadOnly = true;
            this.detail_employeeIdTxtBox.Size = new System.Drawing.Size(240, 34);
            this.detail_employeeIdTxtBox.TabIndex = 21;
            // 
            // detail_customerIdTxtBox
            // 
            this.detail_customerIdTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.detail_customerIdTxtBox.Location = new System.Drawing.Point(171, 147);
            this.detail_customerIdTxtBox.Name = "detail_customerIdTxtBox";
            this.detail_customerIdTxtBox.ReadOnly = true;
            this.detail_customerIdTxtBox.Size = new System.Drawing.Size(240, 34);
            this.detail_customerIdTxtBox.TabIndex = 20;
            // 
            // promotionPicker
            // 
            this.promotionPicker.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.promotionPicker.ForeColor = System.Drawing.Color.Black;
            this.promotionPicker.Location = new System.Drawing.Point(417, 357);
            this.promotionPicker.Name = "promotionPicker";
            this.promotionPicker.Size = new System.Drawing.Size(40, 35);
            this.promotionPicker.TabIndex = 19;
            this.promotionPicker.Text = "...";
            this.promotionPicker.UseVisualStyleBackColor = true;
            this.promotionPicker.Click += new System.EventHandler(this.promotionPicker_Click);
            // 
            // doneBtn
            // 
            this.doneBtn.BackColor = System.Drawing.Color.Lime;
            this.doneBtn.FlatAppearance.BorderSize = 0;
            this.doneBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doneBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.doneBtn.ForeColor = System.Drawing.Color.Black;
            this.doneBtn.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.doneBtn.IconColor = System.Drawing.Color.Black;
            this.doneBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.doneBtn.IconSize = 40;
            this.doneBtn.Location = new System.Drawing.Point(183, 464);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.doneBtn.Size = new System.Drawing.Size(160, 50);
            this.doneBtn.TabIndex = 16;
            this.doneBtn.Text = "DONE";
            this.doneBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.doneBtn.UseVisualStyleBackColor = false;
            this.doneBtn.Click += new System.EventHandler(this.doneBtn_Click);
            // 
            // employeePicker
            // 
            this.employeePicker.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.employeePicker.ForeColor = System.Drawing.Color.Black;
            this.employeePicker.Location = new System.Drawing.Point(417, 221);
            this.employeePicker.Name = "employeePicker";
            this.employeePicker.Size = new System.Drawing.Size(40, 35);
            this.employeePicker.TabIndex = 18;
            this.employeePicker.Text = "...";
            this.employeePicker.UseVisualStyleBackColor = true;
            this.employeePicker.Click += new System.EventHandler(this.employeePicker_Click);
            // 
            // customerPicker
            // 
            this.customerPicker.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customerPicker.ForeColor = System.Drawing.Color.Black;
            this.customerPicker.Location = new System.Drawing.Point(417, 146);
            this.customerPicker.Name = "customerPicker";
            this.customerPicker.Size = new System.Drawing.Size(40, 35);
            this.customerPicker.TabIndex = 17;
            this.customerPicker.Text = "...";
            this.customerPicker.UseVisualStyleBackColor = true;
            this.customerPicker.Click += new System.EventHandler(this.customerPicker_Click);
            // 
            // detail_discountTxtBox
            // 
            this.detail_discountTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.detail_discountTxtBox.Location = new System.Drawing.Point(171, 358);
            this.detail_discountTxtBox.Name = "detail_discountTxtBox";
            this.detail_discountTxtBox.ReadOnly = true;
            this.detail_discountTxtBox.Size = new System.Drawing.Size(240, 34);
            this.detail_discountTxtBox.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(29, 361);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 28);
            this.label9.TabIndex = 9;
            this.label9.Text = "Discount";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(29, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 28);
            this.label8.TabIndex = 7;
            this.label8.Text = "Employee ID";
            // 
            // detail_dateTxtBox
            // 
            this.detail_dateTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.detail_dateTxtBox.Location = new System.Drawing.Point(171, 290);
            this.detail_dateTxtBox.Name = "detail_dateTxtBox";
            this.detail_dateTxtBox.ReadOnly = true;
            this.detail_dateTxtBox.Size = new System.Drawing.Size(286, 34);
            this.detail_dateTxtBox.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(29, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 28);
            this.label7.TabIndex = 5;
            this.label7.Text = "Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(29, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 28);
            this.label6.TabIndex = 3;
            this.label6.Text = "Customer ID";
            // 
            // detail_receiptIdTxtBox
            // 
            this.detail_receiptIdTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.detail_receiptIdTxtBox.Location = new System.Drawing.Point(171, 79);
            this.detail_receiptIdTxtBox.Name = "detail_receiptIdTxtBox";
            this.detail_receiptIdTxtBox.ReadOnly = true;
            this.detail_receiptIdTxtBox.Size = new System.Drawing.Size(286, 34);
            this.detail_receiptIdTxtBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Receipt ID";
            // 
            // receiptTab
            // 
            this.receiptTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.receiptTab.Controls.Add(this.groupBox4);
            this.receiptTab.Controls.Add(this.groupBox3);
            this.receiptTab.Controls.Add(this.receiptTable);
            this.receiptTab.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.receiptTab.Location = new System.Drawing.Point(4, 29);
            this.receiptTab.Name = "receiptTab";
            this.receiptTab.Padding = new System.Windows.Forms.Padding(3);
            this.receiptTab.Size = new System.Drawing.Size(1392, 683);
            this.receiptTab.TabIndex = 1;
            this.receiptTab.Text = "Receipts";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(872, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(517, 267);
            this.groupBox4.TabIndex = 51;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Function";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.delBtn);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Location = new System.Drawing.Point(3, 134);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(511, 130);
            this.groupBox6.TabIndex = 50;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Others";
            // 
            // delBtn
            // 
            this.delBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.delBtn.FlatAppearance.BorderSize = 0;
            this.delBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.delBtn.ForeColor = System.Drawing.Color.White;
            this.delBtn.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.delBtn.IconColor = System.Drawing.Color.White;
            this.delBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.delBtn.Location = new System.Drawing.Point(178, 46);
            this.delBtn.Name = "delBtn";
            this.delBtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.delBtn.Size = new System.Drawing.Size(153, 58);
            this.delBtn.TabIndex = 44;
            this.delBtn.Text = "Delete";
            this.delBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.delBtn.UseVisualStyleBackColor = false;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.searchTxtBox);
            this.groupBox5.Controls.Add(this.searchBtn);
            this.groupBox5.Controls.Add(this.unselectBtn);
            this.groupBox5.Controls.Add(this.searchOpt);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(3, 28);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(511, 104);
            this.groupBox5.TabIndex = 49;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Search";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 28);
            this.label5.TabIndex = 46;
            this.label5.Text = "Enter data";
            // 
            // searchTxtBox
            // 
            this.searchTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchTxtBox.Location = new System.Drawing.Point(122, 29);
            this.searchTxtBox.Name = "searchTxtBox";
            this.searchTxtBox.Size = new System.Drawing.Size(189, 34);
            this.searchTxtBox.TabIndex = 45;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.searchBtn.IconColor = System.Drawing.Color.White;
            this.searchBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.searchBtn.IconSize = 24;
            this.searchBtn.Location = new System.Drawing.Point(421, 29);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.searchBtn.Size = new System.Drawing.Size(34, 34);
            this.searchBtn.TabIndex = 47;
            this.searchBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.searchBtn.UseVisualStyleBackColor = false;
            // 
            // unselectBtn
            // 
            this.unselectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.unselectBtn.FlatAppearance.BorderSize = 0;
            this.unselectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unselectBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.unselectBtn.ForeColor = System.Drawing.Color.White;
            this.unselectBtn.IconChar = FontAwesome.Sharp.IconChar.X;
            this.unselectBtn.IconColor = System.Drawing.Color.White;
            this.unselectBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.unselectBtn.IconSize = 20;
            this.unselectBtn.Location = new System.Drawing.Point(461, 29);
            this.unselectBtn.Name = "unselectBtn";
            this.unselectBtn.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.unselectBtn.Size = new System.Drawing.Size(34, 34);
            this.unselectBtn.TabIndex = 42;
            this.unselectBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.unselectBtn.UseVisualStyleBackColor = false;
            // 
            // searchOpt
            // 
            this.searchOpt.AllowDrop = true;
            this.searchOpt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchOpt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchOpt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchOpt.FormattingEnabled = true;
            this.searchOpt.Items.AddRange(new object[] {
            "Receipt ID",
            "Employee ID",
            "Customer ID"});
            this.searchOpt.Location = new System.Drawing.Point(317, 29);
            this.searchOpt.Name = "searchOpt";
            this.searchOpt.Size = new System.Drawing.Size(98, 33);
            this.searchOpt.TabIndex = 48;
            this.searchOpt.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.showDetailBtn);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.dateTxtBox);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.afterDiscountTxtBox);
            this.groupBox3.Controls.Add(this.promotionIdTxtBox);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.totalPriceTxtBox);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.customerIdTxtBox);
            this.groupBox3.Controls.Add(this.receiptIdTxtBox);
            this.groupBox3.Controls.Add(this.idLabel);
            this.groupBox3.Controls.Add(this.employeeIdTxtBox);
            this.groupBox3.Controls.Add(this.nameLabel);
            this.groupBox3.Controls.Add(this.countryLabel);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(863, 267);
            this.groupBox3.TabIndex = 50;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Information";
            // 
            // showDetailBtn
            // 
            this.showDetailBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showDetailBtn.ForeColor = System.Drawing.Color.Black;
            this.showDetailBtn.Location = new System.Drawing.Point(590, 210);
            this.showDetailBtn.Name = "showDetailBtn";
            this.showDetailBtn.Size = new System.Drawing.Size(120, 34);
            this.showDetailBtn.TabIndex = 51;
            this.showDetailBtn.Text = "View";
            this.showDetailBtn.UseVisualStyleBackColor = true;
            this.showDetailBtn.Click += new System.EventHandler(this.showDetailBtn_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(506, 211);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 28);
            this.label14.TabIndex = 50;
            this.label14.Text = "Details";
            // 
            // dateTxtBox
            // 
            this.dateTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTxtBox.Location = new System.Drawing.Point(148, 208);
            this.dateTxtBox.Name = "dateTxtBox";
            this.dateTxtBox.ReadOnly = true;
            this.dateTxtBox.Size = new System.Drawing.Size(257, 34);
            this.dateTxtBox.TabIndex = 47;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(85, 208);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 28);
            this.label15.TabIndex = 48;
            this.label15.Text = "Date";
            // 
            // afterDiscountTxtBox
            // 
            this.afterDiscountTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.afterDiscountTxtBox.Location = new System.Drawing.Point(590, 155);
            this.afterDiscountTxtBox.Name = "afterDiscountTxtBox";
            this.afterDiscountTxtBox.ReadOnly = true;
            this.afterDiscountTxtBox.Size = new System.Drawing.Size(257, 34);
            this.afterDiscountTxtBox.TabIndex = 45;
            // 
            // promotionIdTxtBox
            // 
            this.promotionIdTxtBox.Enabled = false;
            this.promotionIdTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.promotionIdTxtBox.Location = new System.Drawing.Point(590, 43);
            this.promotionIdTxtBox.Name = "promotionIdTxtBox";
            this.promotionIdTxtBox.ReadOnly = true;
            this.promotionIdTxtBox.Size = new System.Drawing.Size(257, 34);
            this.promotionIdTxtBox.TabIndex = 41;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(445, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 28);
            this.label11.TabIndex = 42;
            this.label11.Text = "Promotion ID";
            // 
            // totalPriceTxtBox
            // 
            this.totalPriceTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalPriceTxtBox.Location = new System.Drawing.Point(590, 98);
            this.totalPriceTxtBox.Name = "totalPriceTxtBox";
            this.totalPriceTxtBox.ReadOnly = true;
            this.totalPriceTxtBox.Size = new System.Drawing.Size(257, 34);
            this.totalPriceTxtBox.TabIndex = 43;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(475, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 28);
            this.label12.TabIndex = 44;
            this.label12.Text = "Total Price";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(433, 158);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 28);
            this.label13.TabIndex = 46;
            this.label13.Text = "After Discount";
            // 
            // customerIdTxtBox
            // 
            this.customerIdTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customerIdTxtBox.Location = new System.Drawing.Point(148, 152);
            this.customerIdTxtBox.Name = "customerIdTxtBox";
            this.customerIdTxtBox.ReadOnly = true;
            this.customerIdTxtBox.Size = new System.Drawing.Size(257, 34);
            this.customerIdTxtBox.TabIndex = 39;
            // 
            // receiptIdTxtBox
            // 
            this.receiptIdTxtBox.Enabled = false;
            this.receiptIdTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.receiptIdTxtBox.Location = new System.Drawing.Point(148, 43);
            this.receiptIdTxtBox.Name = "receiptIdTxtBox";
            this.receiptIdTxtBox.ReadOnly = true;
            this.receiptIdTxtBox.Size = new System.Drawing.Size(257, 34);
            this.receiptIdTxtBox.TabIndex = 35;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.idLabel.ForeColor = System.Drawing.Color.White;
            this.idLabel.Location = new System.Drawing.Point(32, 43);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(110, 28);
            this.idLabel.TabIndex = 36;
            this.idLabel.Text = "Receipt ID";
            // 
            // employeeIdTxtBox
            // 
            this.employeeIdTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.employeeIdTxtBox.Location = new System.Drawing.Point(148, 96);
            this.employeeIdTxtBox.Name = "employeeIdTxtBox";
            this.employeeIdTxtBox.ReadOnly = true;
            this.employeeIdTxtBox.Size = new System.Drawing.Size(257, 34);
            this.employeeIdTxtBox.TabIndex = 37;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(11, 96);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(131, 28);
            this.nameLabel.TabIndex = 38;
            this.nameLabel.Text = "Employee ID";
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.countryLabel.ForeColor = System.Drawing.Color.White;
            this.countryLabel.Location = new System.Drawing.Point(13, 155);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(129, 28);
            this.countryLabel.TabIndex = 40;
            this.countryLabel.Text = "Customer ID";
            // 
            // receiptTable
            // 
            this.receiptTable.AllowUserToAddRows = false;
            this.receiptTable.AllowUserToDeleteRows = false;
            this.receiptTable.AllowUserToResizeColumns = false;
            this.receiptTable.AllowUserToResizeRows = false;
            this.receiptTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.receiptTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.receiptTable.Location = new System.Drawing.Point(3, 270);
            this.receiptTable.MultiSelect = false;
            this.receiptTable.Name = "receiptTable";
            this.receiptTable.ReadOnly = true;
            this.receiptTable.RowHeadersWidth = 51;
            this.receiptTable.RowTemplate.Height = 29;
            this.receiptTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.receiptTable.ShowCellToolTips = false;
            this.receiptTable.ShowEditingIcon = false;
            this.receiptTable.Size = new System.Drawing.Size(1386, 410);
            this.receiptTable.TabIndex = 49;
            this.receiptTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.receiptTable_CellClick);
            // 
            // ReceiptGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.tabControl);
            this.Name = "ReceiptGUI";
            this.Size = new System.Drawing.Size(1400, 716);
            this.tabControl.ResumeLayout(false);
            this.detailTab.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityPick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.receiptTab.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receiptTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl;
        private TabPage detailTab;
        private TabPage receiptTab;
        private TextBox productIdTxtBox;
        private Label label2;
        private TextBox detail_receiptIdTxtBox;
        private Label label1;
        private Button productPicker;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private Label label6;
        private Label label8;
        private TextBox detail_dateTxtBox;
        private Label label7;
        private GroupBox groupBox2;
        private TextBox detail_discountTxtBox;
        private Label label9;
        private Label detail_totalPrice;
        private DataGridView detailTable;
        private Label detail_afterDiscountPrice;
        private Label label10;
        private NumericUpDown quantityPick;
        private FontAwesome.Sharp.IconButton addProductBtn;
        private Button employeePicker;
        private Button customerPicker;
        private FontAwesome.Sharp.IconButton doneBtn;
        private FontAwesome.Sharp.IconButton removeProductBtn;
        private Button promotionPicker;
        private DataGridViewTextBoxColumn MA;
        private DataGridViewTextBoxColumn TEN;
        private DataGridViewTextBoxColumn SOLUONG;
        private DataGridViewTextBoxColumn THANHTIEN;
        private DataGridViewTextBoxColumn DONGIA;
        private TextBox detail_employeeIdTxtBox;
        private TextBox detail_customerIdTxtBox;
        private DataGridView receiptTable;
        private ComboBox searchOpt;
        private FontAwesome.Sharp.IconButton searchBtn;
        private TextBox searchTxtBox;
        private FontAwesome.Sharp.IconButton delBtn;
        private FontAwesome.Sharp.IconButton unselectBtn;
        private Label countryLabel;
        private TextBox customerIdTxtBox;
        private Label nameLabel;
        private TextBox employeeIdTxtBox;
        private Label idLabel;
        private TextBox receiptIdTxtBox;
        private GroupBox groupBox4;
        private Label label5;
        private GroupBox groupBox3;
        private Label label14;
        private TextBox dateTxtBox;
        private Label label15;
        private TextBox afterDiscountTxtBox;
        private TextBox promotionIdTxtBox;
        private Label label11;
        private TextBox totalPriceTxtBox;
        private Label label12;
        private Label label13;
        private GroupBox groupBox6;
        private GroupBox groupBox5;
        private Button showDetailBtn;
    }
}
