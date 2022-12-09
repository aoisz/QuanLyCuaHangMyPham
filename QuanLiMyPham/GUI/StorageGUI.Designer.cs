namespace QuanLiMyPham.GUI
{
    partial class StorageGUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.searchOpt = new System.Windows.Forms.ComboBox();
            this.searchBtn = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.searchTxtBox = new System.Windows.Forms.TextBox();
            this.delBtn = new FontAwesome.Sharp.IconButton();
            this.addBtn = new FontAwesome.Sharp.IconButton();
            this.unselectBtn = new FontAwesome.Sharp.IconButton();
            this.editBtn = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.idTxtBox = new System.Windows.Forms.TextBox();
            this.viewBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tradeBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(0, 316);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.ShowCellToolTips = false;
            this.dataGridView.ShowEditingIcon = false;
            this.dataGridView.Size = new System.Drawing.Size(1400, 400);
            this.dataGridView.TabIndex = 47;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
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
            this.searchOpt.Location = new System.Drawing.Point(1032, 33);
            this.searchOpt.Name = "searchOpt";
            this.searchOpt.Size = new System.Drawing.Size(151, 33);
            this.searchOpt.TabIndex = 46;
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
            this.searchBtn.Location = new System.Drawing.Point(1201, 33);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.searchBtn.Size = new System.Drawing.Size(128, 34);
            this.searchBtn.TabIndex = 45;
            this.searchBtn.Text = "Search";
            this.searchBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(653, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 28);
            this.label5.TabIndex = 44;
            this.label5.Text = "Enter data";
            // 
            // searchTxtBox
            // 
            this.searchTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchTxtBox.Location = new System.Drawing.Point(769, 33);
            this.searchTxtBox.Name = "searchTxtBox";
            this.searchTxtBox.Size = new System.Drawing.Size(257, 34);
            this.searchTxtBox.TabIndex = 43;
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
            this.delBtn.Location = new System.Drawing.Point(996, 150);
            this.delBtn.Name = "delBtn";
            this.delBtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.delBtn.Size = new System.Drawing.Size(153, 58);
            this.delBtn.TabIndex = 42;
            this.delBtn.Text = "Delete";
            this.delBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.delBtn.UseVisualStyleBackColor = false;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
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
            this.addBtn.Location = new System.Drawing.Point(658, 150);
            this.addBtn.Name = "addBtn";
            this.addBtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.addBtn.Size = new System.Drawing.Size(141, 58);
            this.addBtn.TabIndex = 41;
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
            this.unselectBtn.Location = new System.Drawing.Point(1187, 150);
            this.unselectBtn.Name = "unselectBtn";
            this.unselectBtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.unselectBtn.Size = new System.Drawing.Size(142, 58);
            this.unselectBtn.TabIndex = 40;
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
            this.editBtn.Location = new System.Drawing.Point(837, 150);
            this.editBtn.Name = "editBtn";
            this.editBtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.editBtn.Size = new System.Drawing.Size(122, 58);
            this.editBtn.TabIndex = 39;
            this.editBtn.Text = "Edit";
            this.editBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(108, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 28);
            this.label2.TabIndex = 38;
            this.label2.Text = "Name";
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameTxtBox.Location = new System.Drawing.Point(262, 85);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(257, 34);
            this.nameTxtBox.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(108, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 28);
            this.label1.TabIndex = 36;
            this.label1.Text = "ID";
            // 
            // idTxtBox
            // 
            this.idTxtBox.Enabled = false;
            this.idTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.idTxtBox.Location = new System.Drawing.Point(262, 30);
            this.idTxtBox.Name = "idTxtBox";
            this.idTxtBox.ReadOnly = true;
            this.idTxtBox.Size = new System.Drawing.Size(257, 34);
            this.idTxtBox.TabIndex = 35;
            // 
            // viewBtn
            // 
            this.viewBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.viewBtn.Location = new System.Drawing.Point(262, 150);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(120, 34);
            this.viewBtn.TabIndex = 49;
            this.viewBtn.Text = "View";
            this.viewBtn.UseVisualStyleBackColor = true;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(108, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 28);
            this.label4.TabIndex = 48;
            this.label4.Text = "Detail";
            // 
            // tradeBtn
            // 
            this.tradeBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tradeBtn.Location = new System.Drawing.Point(262, 210);
            this.tradeBtn.Name = "tradeBtn";
            this.tradeBtn.Size = new System.Drawing.Size(120, 34);
            this.tradeBtn.TabIndex = 51;
            this.tradeBtn.Text = "View";
            this.tradeBtn.UseVisualStyleBackColor = true;
            this.tradeBtn.Click += new System.EventHandler(this.tradeBTN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(108, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 28);
            this.label3.TabIndex = 50;
            this.label3.Text = "Trade";
            // 
            // StorageGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.tradeBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.searchOpt);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.searchTxtBox);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.unselectBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idTxtBox);
            this.Name = "StorageGUI";
            this.Size = new System.Drawing.Size(1400, 716);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView;
        private ComboBox searchOpt;
        private FontAwesome.Sharp.IconButton searchBtn;
        private Label label5;
        private TextBox searchTxtBox;
        private FontAwesome.Sharp.IconButton delBtn;
        private FontAwesome.Sharp.IconButton addBtn;
        private FontAwesome.Sharp.IconButton unselectBtn;
        private FontAwesome.Sharp.IconButton editBtn;
        private Label label2;
        private TextBox nameTxtBox;
        private Label label1;
        private TextBox idTxtBox;
        private Button viewBtn;
        private Label label4;
        private Button tradeBtn;
        private Label label3;
    }
}
