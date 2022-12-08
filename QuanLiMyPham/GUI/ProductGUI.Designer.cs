namespace QuanLiMyPham.GUI
{
    partial class ProductGUI
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.productImg = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.typeTxtBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.priceTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.productionTxtBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ingredientsViewBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new FontAwesome.Sharp.IconButton();
            this.addBtn = new FontAwesome.Sharp.IconButton();
            this.unselectBtn = new FontAwesome.Sharp.IconButton();
            this.editBtn = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.expDateTxtBox = new System.Windows.Forms.TextBox();
            this.mfgDateTxtBox = new System.Windows.Forms.TextBox();
            this.quantityTxtBox = new System.Windows.Forms.TextBox();
            this.quantityDetailBtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.searchOpt = new System.Windows.Forms.ComboBox();
            this.searchBtn = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.searchTxtBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.typeFilterComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.productionFilterComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.minPriceTxtBox = new System.Windows.Forms.TextBox();
            this.filterPriceViewBtn = new FontAwesome.Sharp.IconButton();
            this.maxPriceTxtBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productImg)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView.Location = new System.Drawing.Point(0, 394);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.ShowCellToolTips = false;
            this.dataGridView.ShowEditingIcon = false;
            this.dataGridView.Size = new System.Drawing.Size(1400, 322);
            this.dataGridView.TabIndex = 35;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // productImg
            // 
            this.productImg.Location = new System.Drawing.Point(24, 25);
            this.productImg.Name = "productImg";
            this.productImg.Size = new System.Drawing.Size(166, 166);
            this.productImg.TabIndex = 36;
            this.productImg.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(232, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 28);
            this.label2.TabIndex = 40;
            this.label2.Text = "ID";
            // 
            // idTxtBox
            // 
            this.idTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.idTxtBox.Location = new System.Drawing.Point(312, 34);
            this.idTxtBox.Name = "idTxtBox";
            this.idTxtBox.ReadOnly = true;
            this.idTxtBox.Size = new System.Drawing.Size(250, 34);
            this.idTxtBox.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(232, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 28);
            this.label1.TabIndex = 42;
            this.label1.Text = "Type";
            // 
            // typeTxtBox
            // 
            this.typeTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.typeTxtBox.Location = new System.Drawing.Point(312, 143);
            this.typeTxtBox.Name = "typeTxtBox";
            this.typeTxtBox.ReadOnly = true;
            this.typeTxtBox.Size = new System.Drawing.Size(250, 34);
            this.typeTxtBox.TabIndex = 41;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(232, 91);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(68, 28);
            this.nameLabel.TabIndex = 44;
            this.nameLabel.Text = "Name";
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameTxtBox.Location = new System.Drawing.Point(312, 91);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.ReadOnly = true;
            this.nameTxtBox.Size = new System.Drawing.Size(250, 34);
            this.nameTxtBox.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(608, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 28);
            this.label3.TabIndex = 50;
            this.label3.Text = "Price";
            // 
            // priceTxtBox
            // 
            this.priceTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceTxtBox.Location = new System.Drawing.Point(730, 91);
            this.priceTxtBox.Name = "priceTxtBox";
            this.priceTxtBox.ReadOnly = true;
            this.priceTxtBox.Size = new System.Drawing.Size(233, 34);
            this.priceTxtBox.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1002, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 28);
            this.label4.TabIndex = 48;
            this.label4.Text = "Ingredient";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(608, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 28);
            this.label5.TabIndex = 46;
            this.label5.Text = "Production";
            // 
            // productionTxtBox
            // 
            this.productionTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productionTxtBox.Location = new System.Drawing.Point(730, 34);
            this.productionTxtBox.Name = "productionTxtBox";
            this.productionTxtBox.ReadOnly = true;
            this.productionTxtBox.Size = new System.Drawing.Size(233, 34);
            this.productionTxtBox.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1002, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 28);
            this.label6.TabIndex = 56;
            this.label6.Text = "EXP date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(1002, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 28);
            this.label8.TabIndex = 52;
            this.label8.Text = "MFG date";
            // 
            // ingredientsViewBtn
            // 
            this.ingredientsViewBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.ingredientsViewBtn.FlatAppearance.BorderSize = 0;
            this.ingredientsViewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ingredientsViewBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ingredientsViewBtn.Location = new System.Drawing.Point(1124, 143);
            this.ingredientsViewBtn.Name = "ingredientsViewBtn";
            this.ingredientsViewBtn.Size = new System.Drawing.Size(116, 34);
            this.ingredientsViewBtn.TabIndex = 59;
            this.ingredientsViewBtn.Text = "View";
            this.ingredientsViewBtn.UseVisualStyleBackColor = false;
            this.ingredientsViewBtn.Click += new System.EventHandler(this.ingredientsViewBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.deleteBtn.IconColor = System.Drawing.Color.White;
            this.deleteBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.deleteBtn.Location = new System.Drawing.Point(362, 115);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.deleteBtn.Size = new System.Drawing.Size(153, 58);
            this.deleteBtn.TabIndex = 65;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.addBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.addBtn.IconColor = System.Drawing.Color.White;
            this.addBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addBtn.IconSize = 56;
            this.addBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addBtn.Location = new System.Drawing.Point(24, 115);
            this.addBtn.Name = "addBtn";
            this.addBtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.addBtn.Size = new System.Drawing.Size(141, 58);
            this.addBtn.TabIndex = 64;
            this.addBtn.Text = "Add";
            this.addBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
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
            this.unselectBtn.Location = new System.Drawing.Point(553, 115);
            this.unselectBtn.Name = "unselectBtn";
            this.unselectBtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.unselectBtn.Size = new System.Drawing.Size(142, 58);
            this.unselectBtn.TabIndex = 63;
            this.unselectBtn.Text = "Cancel";
            this.unselectBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.unselectBtn.UseVisualStyleBackColor = false;
            this.unselectBtn.Click += new System.EventHandler(this.unselectBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.editBtn.FlatAppearance.BorderSize = 0;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editBtn.ForeColor = System.Drawing.Color.White;
            this.editBtn.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.editBtn.IconColor = System.Drawing.Color.White;
            this.editBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.editBtn.Location = new System.Drawing.Point(203, 115);
            this.editBtn.Name = "editBtn";
            this.editBtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.editBtn.Size = new System.Drawing.Size(122, 58);
            this.editBtn.TabIndex = 62;
            this.editBtn.Text = "Edit";
            this.editBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.expDateTxtBox);
            this.groupBox1.Controls.Add(this.mfgDateTxtBox);
            this.groupBox1.Controls.Add(this.quantityTxtBox);
            this.groupBox1.Controls.Add(this.quantityDetailBtn);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.productImg);
            this.groupBox1.Controls.Add(this.idTxtBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.typeTxtBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nameTxtBox);
            this.groupBox1.Controls.Add(this.nameLabel);
            this.groupBox1.Controls.Add(this.ingredientsViewBtn);
            this.groupBox1.Controls.Add(this.productionTxtBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.priceTxtBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1400, 201);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // expDateTxtBox
            // 
            this.expDateTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.expDateTxtBox.Location = new System.Drawing.Point(1124, 88);
            this.expDateTxtBox.Name = "expDateTxtBox";
            this.expDateTxtBox.ReadOnly = true;
            this.expDateTxtBox.Size = new System.Drawing.Size(240, 34);
            this.expDateTxtBox.TabIndex = 66;
            // 
            // mfgDateTxtBox
            // 
            this.mfgDateTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mfgDateTxtBox.Location = new System.Drawing.Point(1124, 34);
            this.mfgDateTxtBox.Name = "mfgDateTxtBox";
            this.mfgDateTxtBox.ReadOnly = true;
            this.mfgDateTxtBox.Size = new System.Drawing.Size(240, 34);
            this.mfgDateTxtBox.TabIndex = 65;
            // 
            // quantityTxtBox
            // 
            this.quantityTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.quantityTxtBox.Location = new System.Drawing.Point(730, 143);
            this.quantityTxtBox.Name = "quantityTxtBox";
            this.quantityTxtBox.ReadOnly = true;
            this.quantityTxtBox.Size = new System.Drawing.Size(118, 34);
            this.quantityTxtBox.TabIndex = 64;
            // 
            // quantityDetailBtn
            // 
            this.quantityDetailBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.quantityDetailBtn.FlatAppearance.BorderSize = 0;
            this.quantityDetailBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quantityDetailBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.quantityDetailBtn.Location = new System.Drawing.Point(863, 143);
            this.quantityDetailBtn.Name = "quantityDetailBtn";
            this.quantityDetailBtn.Size = new System.Drawing.Size(100, 34);
            this.quantityDetailBtn.TabIndex = 63;
            this.quantityDetailBtn.Text = "Detail";
            this.quantityDetailBtn.UseVisualStyleBackColor = false;
            this.quantityDetailBtn.Click += new System.EventHandler(this.quantityDetailBtn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(608, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 28);
            this.label11.TabIndex = 62;
            this.label11.Text = "Quantity";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.searchOpt);
            this.groupBox2.Controls.Add(this.addBtn);
            this.groupBox2.Controls.Add(this.searchBtn);
            this.groupBox2.Controls.Add(this.editBtn);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.deleteBtn);
            this.groupBox2.Controls.Add(this.searchTxtBox);
            this.groupBox2.Controls.Add(this.unselectBtn);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(684, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(716, 193);
            this.groupBox2.TabIndex = 67;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Function";
            // 
            // searchOpt
            // 
            this.searchOpt.AllowDrop = true;
            this.searchOpt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchOpt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchOpt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchOpt.FormattingEnabled = true;
            this.searchOpt.Items.AddRange(new object[] {
            "ID",
            "Name"});
            this.searchOpt.Location = new System.Drawing.Point(394, 45);
            this.searchOpt.Name = "searchOpt";
            this.searchOpt.Size = new System.Drawing.Size(151, 33);
            this.searchOpt.TabIndex = 71;
            this.searchOpt.TabStop = false;
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
            this.searchBtn.Location = new System.Drawing.Point(563, 45);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.searchBtn.Size = new System.Drawing.Size(128, 34);
            this.searchBtn.TabIndex = 70;
            this.searchBtn.Text = "Search";
            this.searchBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(15, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 28);
            this.label7.TabIndex = 69;
            this.label7.Text = "Enter data";
            // 
            // searchTxtBox
            // 
            this.searchTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchTxtBox.Location = new System.Drawing.Point(131, 45);
            this.searchTxtBox.Name = "searchTxtBox";
            this.searchTxtBox.Size = new System.Drawing.Size(257, 34);
            this.searchTxtBox.TabIndex = 68;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(0, 201);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(678, 193);
            this.groupBox3.TabIndex = 68;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filter";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.typeFilterComboBox);
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Location = new System.Drawing.Point(342, 102);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(322, 85);
            this.groupBox6.TabIndex = 75;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Type";
            // 
            // typeFilterComboBox
            // 
            this.typeFilterComboBox.AllowDrop = true;
            this.typeFilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeFilterComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.typeFilterComboBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.typeFilterComboBox.FormattingEnabled = true;
            this.typeFilterComboBox.Items.AddRange(new object[] {
            "ID",
            "Name",
            "Phone"});
            this.typeFilterComboBox.Location = new System.Drawing.Point(18, 34);
            this.typeFilterComboBox.Name = "typeFilterComboBox";
            this.typeFilterComboBox.Size = new System.Drawing.Size(287, 33);
            this.typeFilterComboBox.TabIndex = 73;
            this.typeFilterComboBox.TabStop = false;
            this.typeFilterComboBox.SelectionChangeCommitted += new System.EventHandler(this.typeFilterComboBox_SelectionChangeCommitted);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.productionFilterComboBox);
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(16, 102);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(320, 85);
            this.groupBox5.TabIndex = 74;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Production";
            // 
            // productionFilterComboBox
            // 
            this.productionFilterComboBox.AllowDrop = true;
            this.productionFilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productionFilterComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productionFilterComboBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productionFilterComboBox.FormattingEnabled = true;
            this.productionFilterComboBox.Items.AddRange(new object[] {
            "ID",
            "Name",
            "Phone"});
            this.productionFilterComboBox.Location = new System.Drawing.Point(14, 34);
            this.productionFilterComboBox.Name = "productionFilterComboBox";
            this.productionFilterComboBox.Size = new System.Drawing.Size(287, 33);
            this.productionFilterComboBox.TabIndex = 72;
            this.productionFilterComboBox.TabStop = false;
            this.productionFilterComboBox.SelectionChangeCommitted += new System.EventHandler(this.productionFilterComboBox_SelectionChangeCommitted);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.minPriceTxtBox);
            this.groupBox4.Controls.Add(this.filterPriceViewBtn);
            this.groupBox4.Controls.Add(this.maxPriceTxtBox);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(16, 24);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(648, 72);
            this.groupBox4.TabIndex = 73;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Price";
            // 
            // minPriceTxtBox
            // 
            this.minPriceTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.minPriceTxtBox.Location = new System.Drawing.Point(114, 21);
            this.minPriceTxtBox.Name = "minPriceTxtBox";
            this.minPriceTxtBox.Size = new System.Drawing.Size(140, 34);
            this.minPriceTxtBox.TabIndex = 1;
            // 
            // filterPriceViewBtn
            // 
            this.filterPriceViewBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.filterPriceViewBtn.FlatAppearance.BorderSize = 0;
            this.filterPriceViewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterPriceViewBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.filterPriceViewBtn.ForeColor = System.Drawing.Color.White;
            this.filterPriceViewBtn.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.filterPriceViewBtn.IconColor = System.Drawing.Color.White;
            this.filterPriceViewBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.filterPriceViewBtn.IconSize = 24;
            this.filterPriceViewBtn.Location = new System.Drawing.Point(480, 21);
            this.filterPriceViewBtn.Name = "filterPriceViewBtn";
            this.filterPriceViewBtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.filterPriceViewBtn.Size = new System.Drawing.Size(105, 34);
            this.filterPriceViewBtn.TabIndex = 72;
            this.filterPriceViewBtn.Text = "View";
            this.filterPriceViewBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.filterPriceViewBtn.UseVisualStyleBackColor = false;
            this.filterPriceViewBtn.Click += new System.EventHandler(this.filterPriceViewBtn_Click);
            // 
            // maxPriceTxtBox
            // 
            this.maxPriceTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.maxPriceTxtBox.Location = new System.Drawing.Point(301, 21);
            this.maxPriceTxtBox.Name = "maxPriceTxtBox";
            this.maxPriceTxtBox.Size = new System.Drawing.Size(140, 34);
            this.maxPriceTxtBox.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(263, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 28);
            this.label10.TabIndex = 3;
            this.label10.Text = "to";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(48, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 28);
            this.label9.TabIndex = 2;
            this.label9.Text = "From";
            // 
            // ProductGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView);
            this.Name = "ProductGUI";
            this.Size = new System.Drawing.Size(1400, 716);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productImg)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView;
        private PictureBox productImg;
        private Label label2;
        private TextBox idTxtBox;
        private Label label1;
        private TextBox typeTxtBox;
        private Label nameLabel;
        private TextBox nameTxtBox;
        private Label label3;
        private TextBox priceTxtBox;
        private Label label4;
        private Label label5;
        private TextBox productionTxtBox;
        private Label label6;
        private Label label8;
        private Button ingredientsViewBtn;
        private FontAwesome.Sharp.IconButton deleteBtn;
        private FontAwesome.Sharp.IconButton addBtn;
        private FontAwesome.Sharp.IconButton unselectBtn;
        private FontAwesome.Sharp.IconButton editBtn;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ComboBox searchOpt;
        private FontAwesome.Sharp.IconButton searchBtn;
        private Label label7;
        private TextBox searchTxtBox;
        private GroupBox groupBox3;
        private Label label10;
        private Label label9;
        private TextBox minPriceTxtBox;
        private TextBox maxPriceTxtBox;
        private GroupBox groupBox4;
        private FontAwesome.Sharp.IconButton filterPriceViewBtn;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private ComboBox typeFilterComboBox;
        private ComboBox productionFilterComboBox;
        private Button quantityDetailBtn;
        private Label label11;
        private TextBox quantityTxtBox;
        private TextBox expDateTxtBox;
        private TextBox mfgDateTxtBox;
    }
}
