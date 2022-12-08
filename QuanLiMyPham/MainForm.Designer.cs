namespace QuanLiMyPham
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.leftPanel = new System.Windows.Forms.Panel();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.storageBtn = new FontAwesome.Sharp.IconButton();
            this.roleBtn = new FontAwesome.Sharp.IconButton();
            this.inputProductBtn = new FontAwesome.Sharp.IconButton();
            this.dashboardBtn = new FontAwesome.Sharp.IconButton();
            this.productBtn = new FontAwesome.Sharp.IconButton();
            this.promotionBtn = new FontAwesome.Sharp.IconButton();
            this.accountBtn = new FontAwesome.Sharp.IconButton();
            this.receiptBtn = new FontAwesome.Sharp.IconButton();
            this.employeeBtn = new FontAwesome.Sharp.IconButton();
            this.productionBtn = new FontAwesome.Sharp.IconButton();
            this.productTypeBtn = new FontAwesome.Sharp.IconButton();
            this.customerBtn = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.accountInfor = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.minimizeBtn = new FontAwesome.Sharp.IconButton();
            this.closeBtn = new FontAwesome.Sharp.IconButton();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.leftPanel.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.leftPanel.Controls.Add(this.menuPanel);
            this.leftPanel.Controls.Add(this.panel3);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(2);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(300, 760);
            this.leftPanel.TabIndex = 0;
            // 
            // menuPanel
            // 
            this.menuPanel.AutoScroll = true;
            this.menuPanel.Controls.Add(this.storageBtn);
            this.menuPanel.Controls.Add(this.roleBtn);
            this.menuPanel.Controls.Add(this.inputProductBtn);
            this.menuPanel.Controls.Add(this.dashboardBtn);
            this.menuPanel.Controls.Add(this.productBtn);
            this.menuPanel.Controls.Add(this.promotionBtn);
            this.menuPanel.Controls.Add(this.accountBtn);
            this.menuPanel.Controls.Add(this.receiptBtn);
            this.menuPanel.Controls.Add(this.employeeBtn);
            this.menuPanel.Controls.Add(this.productionBtn);
            this.menuPanel.Controls.Add(this.productTypeBtn);
            this.menuPanel.Controls.Add(this.customerBtn);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuPanel.Location = new System.Drawing.Point(0, 150);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(2);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(300, 610);
            this.menuPanel.TabIndex = 1;
            // 
            // storageBtn
            // 
            this.storageBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.storageBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.storageBtn.FlatAppearance.BorderSize = 0;
            this.storageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.storageBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.storageBtn.ForeColor = System.Drawing.Color.White;
            this.storageBtn.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.storageBtn.IconColor = System.Drawing.Color.White;
            this.storageBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.storageBtn.IconSize = 36;
            this.storageBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.storageBtn.Location = new System.Drawing.Point(0, 528);
            this.storageBtn.Margin = new System.Windows.Forms.Padding(2);
            this.storageBtn.Name = "storageBtn";
            this.storageBtn.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.storageBtn.Size = new System.Drawing.Size(300, 48);
            this.storageBtn.TabIndex = 15;
            this.storageBtn.Text = "Storage";
            this.storageBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.storageBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.storageBtn.UseVisualStyleBackColor = false;
            this.storageBtn.Click += new System.EventHandler(this.storageBtn_Click);
            // 
            // roleBtn
            // 
            this.roleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.roleBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.roleBtn.FlatAppearance.BorderSize = 0;
            this.roleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roleBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.roleBtn.ForeColor = System.Drawing.Color.White;
            this.roleBtn.IconChar = FontAwesome.Sharp.IconChar.Shield;
            this.roleBtn.IconColor = System.Drawing.Color.White;
            this.roleBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.roleBtn.IconSize = 36;
            this.roleBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roleBtn.Location = new System.Drawing.Point(0, 480);
            this.roleBtn.Margin = new System.Windows.Forms.Padding(2);
            this.roleBtn.Name = "roleBtn";
            this.roleBtn.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.roleBtn.Size = new System.Drawing.Size(300, 48);
            this.roleBtn.TabIndex = 14;
            this.roleBtn.Text = "Roles";
            this.roleBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roleBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roleBtn.UseVisualStyleBackColor = false;
            this.roleBtn.Click += new System.EventHandler(this.roleBtn_Click);
            // 
            // inputProductBtn
            // 
            this.inputProductBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.inputProductBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.inputProductBtn.FlatAppearance.BorderSize = 0;
            this.inputProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inputProductBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inputProductBtn.ForeColor = System.Drawing.Color.White;
            this.inputProductBtn.IconChar = FontAwesome.Sharp.IconChar.Bitcoin;
            this.inputProductBtn.IconColor = System.Drawing.Color.White;
            this.inputProductBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.inputProductBtn.IconSize = 36;
            this.inputProductBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inputProductBtn.Location = new System.Drawing.Point(0, 432);
            this.inputProductBtn.Margin = new System.Windows.Forms.Padding(2);
            this.inputProductBtn.Name = "inputProductBtn";
            this.inputProductBtn.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.inputProductBtn.Size = new System.Drawing.Size(300, 48);
            this.inputProductBtn.TabIndex = 13;
            this.inputProductBtn.Text = "Input Products";
            this.inputProductBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inputProductBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.inputProductBtn.UseVisualStyleBackColor = false;
            this.inputProductBtn.Click += new System.EventHandler(this.inputProductBtn_Click);
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.dashboardBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashboardBtn.FlatAppearance.BorderSize = 0;
            this.dashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dashboardBtn.ForeColor = System.Drawing.Color.White;
            this.dashboardBtn.IconChar = FontAwesome.Sharp.IconChar.LineChart;
            this.dashboardBtn.IconColor = System.Drawing.Color.White;
            this.dashboardBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dashboardBtn.IconSize = 36;
            this.dashboardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardBtn.Location = new System.Drawing.Point(0, 384);
            this.dashboardBtn.Margin = new System.Windows.Forms.Padding(2);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.dashboardBtn.Size = new System.Drawing.Size(300, 48);
            this.dashboardBtn.TabIndex = 12;
            this.dashboardBtn.Text = "Dashboard";
            this.dashboardBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dashboardBtn.UseVisualStyleBackColor = false;
            this.dashboardBtn.Click += new System.EventHandler(this.dashboardBtn_Click);
            // 
            // productBtn
            // 
            this.productBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.productBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.productBtn.FlatAppearance.BorderSize = 0;
            this.productBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.productBtn.ForeColor = System.Drawing.Color.White;
            this.productBtn.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.productBtn.IconColor = System.Drawing.Color.White;
            this.productBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.productBtn.IconSize = 36;
            this.productBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productBtn.Location = new System.Drawing.Point(0, 336);
            this.productBtn.Margin = new System.Windows.Forms.Padding(2);
            this.productBtn.Name = "productBtn";
            this.productBtn.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.productBtn.Size = new System.Drawing.Size(300, 48);
            this.productBtn.TabIndex = 4;
            this.productBtn.Text = "Products";
            this.productBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.productBtn.UseVisualStyleBackColor = false;
            this.productBtn.Click += new System.EventHandler(this.productBtn_Click);
            // 
            // promotionBtn
            // 
            this.promotionBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.promotionBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.promotionBtn.FlatAppearance.BorderSize = 0;
            this.promotionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.promotionBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.promotionBtn.ForeColor = System.Drawing.Color.White;
            this.promotionBtn.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
            this.promotionBtn.IconColor = System.Drawing.Color.White;
            this.promotionBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.promotionBtn.IconSize = 36;
            this.promotionBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.promotionBtn.Location = new System.Drawing.Point(0, 288);
            this.promotionBtn.Margin = new System.Windows.Forms.Padding(2);
            this.promotionBtn.Name = "promotionBtn";
            this.promotionBtn.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.promotionBtn.Size = new System.Drawing.Size(300, 48);
            this.promotionBtn.TabIndex = 7;
            this.promotionBtn.Text = "Promotions";
            this.promotionBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.promotionBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.promotionBtn.UseVisualStyleBackColor = false;
            this.promotionBtn.Click += new System.EventHandler(this.promotionBtn_Click);
            // 
            // accountBtn
            // 
            this.accountBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.accountBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.accountBtn.FlatAppearance.BorderSize = 0;
            this.accountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.accountBtn.ForeColor = System.Drawing.Color.White;
            this.accountBtn.IconChar = FontAwesome.Sharp.IconChar.User;
            this.accountBtn.IconColor = System.Drawing.Color.White;
            this.accountBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.accountBtn.IconSize = 36;
            this.accountBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.accountBtn.Location = new System.Drawing.Point(0, 240);
            this.accountBtn.Margin = new System.Windows.Forms.Padding(2);
            this.accountBtn.Name = "accountBtn";
            this.accountBtn.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.accountBtn.Size = new System.Drawing.Size(300, 48);
            this.accountBtn.TabIndex = 11;
            this.accountBtn.Text = "Accounts";
            this.accountBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.accountBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.accountBtn.UseVisualStyleBackColor = false;
            this.accountBtn.Click += new System.EventHandler(this.accountBtn_Click);
            // 
            // receiptBtn
            // 
            this.receiptBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.receiptBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.receiptBtn.FlatAppearance.BorderSize = 0;
            this.receiptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.receiptBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.receiptBtn.ForeColor = System.Drawing.Color.White;
            this.receiptBtn.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.receiptBtn.IconColor = System.Drawing.Color.White;
            this.receiptBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.receiptBtn.IconSize = 36;
            this.receiptBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.receiptBtn.Location = new System.Drawing.Point(0, 192);
            this.receiptBtn.Margin = new System.Windows.Forms.Padding(2);
            this.receiptBtn.Name = "receiptBtn";
            this.receiptBtn.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.receiptBtn.Size = new System.Drawing.Size(300, 48);
            this.receiptBtn.TabIndex = 6;
            this.receiptBtn.Text = "Receipts";
            this.receiptBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.receiptBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.receiptBtn.UseVisualStyleBackColor = false;
            this.receiptBtn.Click += new System.EventHandler(this.receiptBtn_Click);
            // 
            // employeeBtn
            // 
            this.employeeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.employeeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.employeeBtn.FlatAppearance.BorderSize = 0;
            this.employeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeeBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.employeeBtn.ForeColor = System.Drawing.Color.White;
            this.employeeBtn.IconChar = FontAwesome.Sharp.IconChar.Person;
            this.employeeBtn.IconColor = System.Drawing.Color.White;
            this.employeeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.employeeBtn.IconSize = 36;
            this.employeeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.employeeBtn.Location = new System.Drawing.Point(0, 144);
            this.employeeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.employeeBtn.Name = "employeeBtn";
            this.employeeBtn.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.employeeBtn.Size = new System.Drawing.Size(300, 48);
            this.employeeBtn.TabIndex = 8;
            this.employeeBtn.Text = "Employees";
            this.employeeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.employeeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.employeeBtn.UseVisualStyleBackColor = false;
            this.employeeBtn.Click += new System.EventHandler(this.employeeBtn_Click);
            // 
            // productionBtn
            // 
            this.productionBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.productionBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.productionBtn.FlatAppearance.BorderSize = 0;
            this.productionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productionBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.productionBtn.ForeColor = System.Drawing.Color.White;
            this.productionBtn.IconChar = FontAwesome.Sharp.IconChar.Building;
            this.productionBtn.IconColor = System.Drawing.Color.White;
            this.productionBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.productionBtn.IconSize = 36;
            this.productionBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productionBtn.Location = new System.Drawing.Point(0, 96);
            this.productionBtn.Margin = new System.Windows.Forms.Padding(2);
            this.productionBtn.Name = "productionBtn";
            this.productionBtn.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.productionBtn.Size = new System.Drawing.Size(300, 48);
            this.productionBtn.TabIndex = 10;
            this.productionBtn.Text = "Productions";
            this.productionBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productionBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.productionBtn.UseVisualStyleBackColor = false;
            this.productionBtn.Click += new System.EventHandler(this.productionBtn_Click);
            // 
            // productTypeBtn
            // 
            this.productTypeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.productTypeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.productTypeBtn.FlatAppearance.BorderSize = 0;
            this.productTypeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productTypeBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.productTypeBtn.ForeColor = System.Drawing.Color.White;
            this.productTypeBtn.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.productTypeBtn.IconColor = System.Drawing.Color.White;
            this.productTypeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.productTypeBtn.IconSize = 36;
            this.productTypeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productTypeBtn.Location = new System.Drawing.Point(0, 48);
            this.productTypeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.productTypeBtn.Name = "productTypeBtn";
            this.productTypeBtn.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.productTypeBtn.Size = new System.Drawing.Size(300, 48);
            this.productTypeBtn.TabIndex = 5;
            this.productTypeBtn.Text = "Product Types";
            this.productTypeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productTypeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.productTypeBtn.UseVisualStyleBackColor = false;
            this.productTypeBtn.Click += new System.EventHandler(this.productTypeBtn_Click);
            // 
            // customerBtn
            // 
            this.customerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.customerBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.customerBtn.FlatAppearance.BorderSize = 0;
            this.customerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.customerBtn.ForeColor = System.Drawing.Color.White;
            this.customerBtn.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.customerBtn.IconColor = System.Drawing.Color.White;
            this.customerBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.customerBtn.IconSize = 36;
            this.customerBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customerBtn.Location = new System.Drawing.Point(0, 0);
            this.customerBtn.Margin = new System.Windows.Forms.Padding(2);
            this.customerBtn.Name = "customerBtn";
            this.customerBtn.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.customerBtn.Size = new System.Drawing.Size(300, 48);
            this.customerBtn.TabIndex = 9;
            this.customerBtn.Text = "Customers";
            this.customerBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customerBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customerBtn.UseVisualStyleBackColor = false;
            this.customerBtn.Click += new System.EventHandler(this.customerBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 150);
            this.panel3.TabIndex = 0;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.topPanel.Controls.Add(this.accountInfor);
            this.topPanel.Controls.Add(this.iconButton1);
            this.topPanel.Controls.Add(this.minimizeBtn);
            this.topPanel.Controls.Add(this.closeBtn);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(300, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1400, 44);
            this.topPanel.TabIndex = 1;
            // 
            // accountInfor
            // 
            this.accountInfor.AutoSize = true;
            this.accountInfor.Dock = System.Windows.Forms.DockStyle.Left;
            this.accountInfor.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.accountInfor.ForeColor = System.Drawing.Color.White;
            this.accountInfor.Location = new System.Drawing.Point(51, 0);
            this.accountInfor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.accountInfor.Name = "accountInfor";
            this.accountInfor.Padding = new System.Windows.Forms.Padding(0, 3, 0, 6);
            this.accountInfor.Size = new System.Drawing.Size(133, 41);
            this.accountInfor.TabIndex = 4;
            this.accountInfor.Text = "Welcome, ";
            this.accountInfor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // iconButton1
            // 
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowUpFromBracket;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 24;
            this.iconButton1.Location = new System.Drawing.Point(0, 0);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = -90D;
            this.iconButton1.Size = new System.Drawing.Size(51, 44);
            this.iconButton1.TabIndex = 3;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.logOut_Click);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimizeBtn.FlatAppearance.BorderSize = 0;
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeBtn.ForeColor = System.Drawing.Color.White;
            this.minimizeBtn.IconChar = FontAwesome.Sharp.IconChar.AngleDown;
            this.minimizeBtn.IconColor = System.Drawing.Color.White;
            this.minimizeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.minimizeBtn.IconSize = 24;
            this.minimizeBtn.Location = new System.Drawing.Point(1298, 0);
            this.minimizeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(51, 44);
            this.minimizeBtn.TabIndex = 2;
            this.minimizeBtn.UseVisualStyleBackColor = true;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.IconChar = FontAwesome.Sharp.IconChar.X;
            this.closeBtn.IconColor = System.Drawing.Color.White;
            this.closeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.closeBtn.IconSize = 24;
            this.closeBtn.Location = new System.Drawing.Point(1349, 0);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(51, 44);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.Location = new System.Drawing.Point(300, 44);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1400, 716);
            this.contentPanel.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1700, 760);
            this.ControlBox = false;
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.leftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.leftPanel.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel leftPanel;
        private Panel panel3;
        private Panel topPanel;
        private Panel menuPanel;
        private FontAwesome.Sharp.IconButton dashboardBtn;
        private FontAwesome.Sharp.IconButton productBtn;
        private FontAwesome.Sharp.IconButton promotionBtn;
        private FontAwesome.Sharp.IconButton accountBtn;
        private FontAwesome.Sharp.IconButton receiptBtn;
        private FontAwesome.Sharp.IconButton employeeBtn;
        private FontAwesome.Sharp.IconButton productionBtn;
        private FontAwesome.Sharp.IconButton productTypeBtn;
        private FontAwesome.Sharp.IconButton customerBtn;
        private FontAwesome.Sharp.IconButton roleBtn;
        private FontAwesome.Sharp.IconButton inputProductBtn;
        private FontAwesome.Sharp.IconButton closeBtn;
        private FontAwesome.Sharp.IconButton minimizeBtn;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label accountInfor;
        private FontAwesome.Sharp.IconButton storageBtn;
        private Panel contentPanel;
    }
}