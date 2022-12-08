namespace QuanLiMyPham.GUI
{
    partial class InputProductGUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.inputTab = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.removeProductBtn = new FontAwesome.Sharp.IconButton();
            this.addProductBtn = new FontAwesome.Sharp.IconButton();
            this.quantityPick = new System.Windows.Forms.NumericUpDown();
            this.priceTotal = new System.Windows.Forms.Label();
            this.detailTable = new System.Windows.Forms.DataGridView();
            this.MA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THANHTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.productIdTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.productPicker = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.doneBtn = new FontAwesome.Sharp.IconButton();
            this.storageIdTxtBox = new System.Windows.Forms.TextBox();
            this.storagePicker = new System.Windows.Forms.Button();
            this.employeePicker = new System.Windows.Forms.Button();
            this.employeeIdTxtBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTxtBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.inputIdTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.detailTab = new System.Windows.Forms.TabPage();
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
            this.storageIdTF = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.showDetailBtn = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.dateTF = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.totalPriceTxtBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.InputIdTF = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.employeeIdTF = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.inputTable = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.inputTab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityPick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.detailTab.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.inputTab);
            this.tabControl.Controls.Add(this.detailTab);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1400, 716);
            this.tabControl.TabIndex = 1;
            // 
            // inputTab
            // 
            this.inputTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.inputTab.Controls.Add(this.groupBox2);
            this.inputTab.Controls.Add(this.groupBox1);
            this.inputTab.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inputTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.inputTab.Location = new System.Drawing.Point(4, 29);
            this.inputTab.Name = "inputTab";
            this.inputTab.Padding = new System.Windows.Forms.Padding(3);
            this.inputTab.Size = new System.Drawing.Size(1392, 683);
            this.inputTab.TabIndex = 0;
            this.inputTab.Text = "InputTab";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.removeProductBtn);
            this.groupBox2.Controls.Add(this.addProductBtn);
            this.groupBox2.Controls.Add(this.quantityPick);
            this.groupBox2.Controls.Add(this.priceTotal);
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
            this.groupBox2.Text = "InputProduct Detail";
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
            this.removeProductBtn.Location = new System.Drawing.Point(558, 130);
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
            // priceTotal
            // 
            this.priceTotal.AutoSize = true;
            this.priceTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceTotal.ForeColor = System.Drawing.Color.White;
            this.priceTotal.Location = new System.Drawing.Point(681, 188);
            this.priceTotal.Name = "priceTotal";
            this.priceTotal.Size = new System.Drawing.Size(23, 28);
            this.priceTotal.TabIndex = 11;
            this.priceTotal.Text = "0";
            // 
            // detailTable
            // 
            this.detailTable.AllowUserToAddRows = false;
            this.detailTable.AllowUserToDeleteRows = false;
            this.detailTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.detailTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.detailTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detailTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MA,
            this.TEN,
            this.DONGIA,
            this.SOLUONG,
            this.THANHTIEN});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.detailTable.DefaultCellStyle = dataGridViewCellStyle5;
            this.detailTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.detailTable.Location = new System.Drawing.Point(3, 273);
            this.detailTable.Name = "detailTable";
            this.detailTable.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.detailTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.detailTable.RowHeadersWidth = 51;
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
            // DONGIA
            // 
            this.DONGIA.HeaderText = "Price";
            this.DONGIA.MinimumWidth = 6;
            this.DONGIA.Name = "DONGIA";
            this.DONGIA.ReadOnly = true;
            this.DONGIA.Width = 125;
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
            this.THANHTIEN.HeaderText = "Total";
            this.THANHTIEN.MinimumWidth = 6;
            this.THANHTIEN.Name = "THANHTIEN";
            this.THANHTIEN.ReadOnly = true;
            this.THANHTIEN.Width = 125;
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
            this.productIdTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productIdTxtBox.Location = new System.Drawing.Point(151, 70);
            this.productIdTxtBox.Name = "productIdTxtBox";
            this.productIdTxtBox.ReadOnly = true;
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
            this.label4.Location = new System.Drawing.Point(558, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total Price:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.doneBtn);
            this.groupBox1.Controls.Add(this.storageIdTxtBox);
            this.groupBox1.Controls.Add(this.storagePicker);
            this.groupBox1.Controls.Add(this.employeePicker);
            this.groupBox1.Controls.Add(this.employeeIdTxtBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dateTxtBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.inputIdTxtBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(908, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 677);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "InputProduct Information";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(29, 295);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 28);
            this.label9.TabIndex = 20;
            this.label9.Text = "Storage ID";
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
            // storageIdTxtBox
            // 
            this.storageIdTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.storageIdTxtBox.Location = new System.Drawing.Point(186, 295);
            this.storageIdTxtBox.Name = "storageIdTxtBox";
            this.storageIdTxtBox.ReadOnly = true;
            this.storageIdTxtBox.Size = new System.Drawing.Size(221, 34);
            this.storageIdTxtBox.TabIndex = 21;
            // 
            // storagePicker
            // 
            this.storagePicker.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.storagePicker.ForeColor = System.Drawing.Color.Black;
            this.storagePicker.Location = new System.Drawing.Point(413, 298);
            this.storagePicker.Name = "storagePicker";
            this.storagePicker.Size = new System.Drawing.Size(44, 35);
            this.storagePicker.TabIndex = 22;
            this.storagePicker.Text = "...";
            this.storagePicker.UseVisualStyleBackColor = true;
            this.storagePicker.Click += new System.EventHandler(this.storagePicker_Click);
            // 
            // employeePicker
            // 
            this.employeePicker.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.employeePicker.ForeColor = System.Drawing.Color.Black;
            this.employeePicker.Location = new System.Drawing.Point(417, 208);
            this.employeePicker.Name = "employeePicker";
            this.employeePicker.Size = new System.Drawing.Size(40, 35);
            this.employeePicker.TabIndex = 18;
            this.employeePicker.Text = "...";
            this.employeePicker.UseVisualStyleBackColor = true;
            this.employeePicker.Click += new System.EventHandler(this.employeePicker_Click);
            // 
            // employeeIdTxtBox
            // 
            this.employeeIdTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.employeeIdTxtBox.Location = new System.Drawing.Point(186, 209);
            this.employeeIdTxtBox.Name = "employeeIdTxtBox";
            this.employeeIdTxtBox.ReadOnly = true;
            this.employeeIdTxtBox.Size = new System.Drawing.Size(225, 34);
            this.employeeIdTxtBox.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(29, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 28);
            this.label8.TabIndex = 7;
            this.label8.Text = "Employee ID";
            // 
            // dateTxtBox
            // 
            this.dateTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTxtBox.Location = new System.Drawing.Point(186, 370);
            this.dateTxtBox.Name = "dateTxtBox";
            this.dateTxtBox.ReadOnly = true;
            this.dateTxtBox.Size = new System.Drawing.Size(274, 34);
            this.dateTxtBox.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(32, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 28);
            this.label7.TabIndex = 5;
            this.label7.Text = "Date";
            // 
            // inputIdTxtBox
            // 
            this.inputIdTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputIdTxtBox.Location = new System.Drawing.Point(186, 103);
            this.inputIdTxtBox.Name = "inputIdTxtBox";
            this.inputIdTxtBox.ReadOnly = true;
            this.inputIdTxtBox.Size = new System.Drawing.Size(271, 34);
            this.inputIdTxtBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "InputProduct ID";
            // 
            // detailTab
            // 
            this.detailTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.detailTab.Controls.Add(this.groupBox4);
            this.detailTab.Controls.Add(this.groupBox3);
            this.detailTab.Controls.Add(this.inputTable);
            this.detailTab.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.detailTab.Location = new System.Drawing.Point(4, 29);
            this.detailTab.Name = "detailTab";
            this.detailTab.Padding = new System.Windows.Forms.Padding(3);
            this.detailTab.Size = new System.Drawing.Size(1392, 683);
            this.detailTab.TabIndex = 1;
            this.detailTab.Text = "DetailTab";
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
            this.groupBox4.TabIndex = 54;
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
            this.searchTxtBox.Size = new System.Drawing.Size(132, 34);
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
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
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
            this.unselectBtn.Click += new System.EventHandler(this.unselectBtn_Click);
            // 
            // searchOpt
            // 
            this.searchOpt.AllowDrop = true;
            this.searchOpt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchOpt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchOpt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchOpt.FormattingEnabled = true;
            this.searchOpt.Items.AddRange(new object[] {
            "Input Products ID",
            "Employee ID",
            "Storage ID"});
            this.searchOpt.Location = new System.Drawing.Point(260, 29);
            this.searchOpt.Name = "searchOpt";
            this.searchOpt.Size = new System.Drawing.Size(155, 33);
            this.searchOpt.TabIndex = 48;
            this.searchOpt.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.storageIdTF);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.showDetailBtn);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.dateTF);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.totalPriceTxtBox);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.InputIdTF);
            this.groupBox3.Controls.Add(this.idLabel);
            this.groupBox3.Controls.Add(this.employeeIdTF);
            this.groupBox3.Controls.Add(this.nameLabel);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(863, 267);
            this.groupBox3.TabIndex = 53;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Information";
            // 
            // storageIdTF
            // 
            this.storageIdTF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.storageIdTF.Location = new System.Drawing.Point(610, 60);
            this.storageIdTF.Name = "storageIdTF";
            this.storageIdTF.ReadOnly = true;
            this.storageIdTF.Size = new System.Drawing.Size(223, 34);
            this.storageIdTF.TabIndex = 52;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(486, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 28);
            this.label10.TabIndex = 53;
            this.label10.Text = " Storage ID";
            // 
            // showDetailBtn
            // 
            this.showDetailBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showDetailBtn.ForeColor = System.Drawing.Color.Black;
            this.showDetailBtn.Location = new System.Drawing.Point(610, 179);
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
            this.label14.Location = new System.Drawing.Point(486, 175);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 28);
            this.label14.TabIndex = 50;
            this.label14.Text = "Details";
            // 
            // dateTF
            // 
            this.dateTF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTF.Location = new System.Drawing.Point(610, 124);
            this.dateTF.Name = "dateTF";
            this.dateTF.ReadOnly = true;
            this.dateTF.Size = new System.Drawing.Size(223, 34);
            this.dateTF.TabIndex = 47;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(496, 115);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 28);
            this.label15.TabIndex = 48;
            this.label15.Text = "Date";
            // 
            // totalPriceTxtBox
            // 
            this.totalPriceTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalPriceTxtBox.Location = new System.Drawing.Point(187, 177);
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
            this.label12.Location = new System.Drawing.Point(18, 177);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 28);
            this.label12.TabIndex = 44;
            this.label12.Text = "Total Price";
            // 
            // InputIdTF
            // 
            this.InputIdTF.Enabled = false;
            this.InputIdTF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputIdTF.Location = new System.Drawing.Point(187, 60);
            this.InputIdTF.Name = "InputIdTF";
            this.InputIdTF.ReadOnly = true;
            this.InputIdTF.Size = new System.Drawing.Size(257, 34);
            this.InputIdTF.TabIndex = 35;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.idLabel.ForeColor = System.Drawing.Color.White;
            this.idLabel.Location = new System.Drawing.Point(18, 60);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(163, 28);
            this.idLabel.TabIndex = 36;
            this.idLabel.Text = "InputProduct ID";
            // 
            // employeeIdTF
            // 
            this.employeeIdTF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.employeeIdTF.Location = new System.Drawing.Point(187, 118);
            this.employeeIdTF.Name = "employeeIdTF";
            this.employeeIdTF.ReadOnly = true;
            this.employeeIdTF.Size = new System.Drawing.Size(257, 34);
            this.employeeIdTF.TabIndex = 37;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(18, 115);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(131, 28);
            this.nameLabel.TabIndex = 38;
            this.nameLabel.Text = "Employee ID";
            // 
            // inputTable
            // 
            this.inputTable.AllowUserToAddRows = false;
            this.inputTable.AllowUserToDeleteRows = false;
            this.inputTable.AllowUserToResizeColumns = false;
            this.inputTable.AllowUserToResizeRows = false;
            this.inputTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inputTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.inputTable.Location = new System.Drawing.Point(3, 270);
            this.inputTable.MultiSelect = false;
            this.inputTable.Name = "inputTable";
            this.inputTable.ReadOnly = true;
            this.inputTable.RowHeadersWidth = 51;
            this.inputTable.RowTemplate.Height = 29;
            this.inputTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.inputTable.ShowCellToolTips = false;
            this.inputTable.ShowEditingIcon = false;
            this.inputTable.Size = new System.Drawing.Size(1386, 410);
            this.inputTable.TabIndex = 52;
            this.inputTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inputTable_CellClick);
            // 
            // InputProductGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.tabControl);
            this.Name = "InputProductGUI";
            this.Size = new System.Drawing.Size(1400, 716);
            this.tabControl.ResumeLayout(false);
            this.inputTab.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityPick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.detailTab.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl;
        private TabPage inputTab;
        private GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton removeProductBtn;
        private FontAwesome.Sharp.IconButton addProductBtn;
        private NumericUpDown quantityPick;
        private Label priceTotal;
        private DataGridView detailTable;
        private Label label2;
        private TextBox productIdTxtBox;
        private Label label3;
        private Button productPicker;
        private Label label4;
        private GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton doneBtn;
        private Button employeePicker;
        private TextBox employeeIdTxtBox;
        private Label label8;
        private TextBox dateTxtBox;
        private Label label7;
        private TextBox inputIdTxtBox;
        private Label label1;
        private TabPage detailTab;
        private GroupBox groupBox4;
        private GroupBox groupBox6;
        private FontAwesome.Sharp.IconButton delBtn;
        private GroupBox groupBox5;
        private Label label5;
        private TextBox searchTxtBox;
        private FontAwesome.Sharp.IconButton searchBtn;
        private FontAwesome.Sharp.IconButton unselectBtn;
        private ComboBox searchOpt;
        private GroupBox groupBox3;
        private Button showDetailBtn;
        private Label label14;
        private TextBox dateTF;
        private Label label15;
        private TextBox totalPriceTxtBox;
        private Label label12;
        private TextBox InputIdTF;
        private Label idLabel;
        private DataGridView inputTable;
        private TextBox employeeIdTF;
        private Label nameLabel;
        private Label label9;
        private TextBox storageIdTxtBox;
        private Button storagePicker;
        private DataGridViewTextBoxColumn MA;
        private DataGridViewTextBoxColumn TEN;
        private DataGridViewTextBoxColumn DONGIA;
        private DataGridViewTextBoxColumn SOLUONG;
        private DataGridViewTextBoxColumn THANHTIEN;
        private TextBox storageIdTF;
        private Label label10;
    }
}
