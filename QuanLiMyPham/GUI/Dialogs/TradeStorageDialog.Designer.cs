namespace QuanLiMyPham.GUI.Dialogs
{
    partial class TradeStorageDialog
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.storageBefore = new System.Windows.Forms.ComboBox();
            this.storageAfter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.doneBTN = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addProductBtn = new FontAwesome.Sharp.IconButton();
            this.quantityPick = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.productIdTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.productPicker = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.MA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.close = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityPick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // storageBefore
            // 
            this.storageBefore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.storageBefore.ForeColor = System.Drawing.Color.Black;
            this.storageBefore.FormattingEnabled = true;
            this.storageBefore.Location = new System.Drawing.Point(122, 77);
            this.storageBefore.Margin = new System.Windows.Forms.Padding(4);
            this.storageBefore.Name = "storageBefore";
            this.storageBefore.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.storageBefore.Size = new System.Drawing.Size(204, 33);
            this.storageBefore.TabIndex = 1;
            // 
            // storageAfter
            // 
            this.storageAfter.FormattingEnabled = true;
            this.storageAfter.Location = new System.Drawing.Point(122, 144);
            this.storageAfter.Margin = new System.Windows.Forms.Padding(4);
            this.storageAfter.Name = "storageAfter";
            this.storageAfter.Size = new System.Drawing.Size(204, 33);
            this.storageAfter.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(37, 149);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(490, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 41);
            this.label3.TabIndex = 4;
            this.label3.Text = "Trade Product";
            // 
            // doneBTN
            // 
            this.doneBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(90)))), ((int)(((byte)(84)))));
            this.doneBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.doneBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.doneBTN.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.doneBTN.Location = new System.Drawing.Point(113, 246);
            this.doneBTN.Margin = new System.Windows.Forms.Padding(4);
            this.doneBTN.Name = "doneBTN";
            this.doneBTN.Size = new System.Drawing.Size(149, 46);
            this.doneBTN.TabIndex = 5;
            this.doneBTN.Text = "DONE";
            this.doneBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.doneBTN.UseVisualStyleBackColor = false;
            this.doneBTN.Click += new System.EventHandler(this.doneBTN_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.storageBefore);
            this.groupBox1.Controls.Add(this.doneBTN);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.storageAfter);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(27, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 383);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Function";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addProductBtn);
            this.groupBox2.Controls.Add(this.quantityPick);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.productIdTxtBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.productPicker);
            this.groupBox2.Controls.Add(this.dataGridView);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(417, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(786, 383);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choose product";
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
            this.addProductBtn.Location = new System.Drawing.Point(594, 47);
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.addProductBtn.Size = new System.Drawing.Size(126, 38);
            this.addProductBtn.TabIndex = 20;
            this.addProductBtn.Text = "ADD";
            this.addProductBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addProductBtn.UseVisualStyleBackColor = false;
            this.addProductBtn.Click += new System.EventHandler(this.addProductBtn_Click);
            // 
            // quantityPick
            // 
            this.quantityPick.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quantityPick.Location = new System.Drawing.Point(464, 44);
            this.quantityPick.Name = "quantityPick";
            this.quantityPick.Size = new System.Drawing.Size(89, 34);
            this.quantityPick.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(28, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 28);
            this.label4.TabIndex = 15;
            this.label4.Text = "Product ID";
            // 
            // productIdTxtBox
            // 
            this.productIdTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productIdTxtBox.Location = new System.Drawing.Point(147, 44);
            this.productIdTxtBox.Name = "productIdTxtBox";
            this.productIdTxtBox.ReadOnly = true;
            this.productIdTxtBox.Size = new System.Drawing.Size(106, 34);
            this.productIdTxtBox.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(353, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 28);
            this.label5.TabIndex = 18;
            this.label5.Text = "Quantity";
            // 
            // productPicker
            // 
            this.productPicker.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productPicker.ForeColor = System.Drawing.Color.Black;
            this.productPicker.Location = new System.Drawing.Point(259, 43);
            this.productPicker.Name = "productPicker";
            this.productPicker.Size = new System.Drawing.Size(44, 35);
            this.productPicker.TabIndex = 17;
            this.productPicker.Text = "...";
            this.productPicker.UseVisualStyleBackColor = true;
            this.productPicker.Click += new System.EventHandler(this.productPicker_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MA,
            this.SOLUONG});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.Location = new System.Drawing.Point(0, 112);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView.Size = new System.Drawing.Size(786, 271);
            this.dataGridView.TabIndex = 0;
            // 
            // MA
            // 
            this.MA.HeaderText = "ID";
            this.MA.MinimumWidth = 6;
            this.MA.Name = "MA";
            this.MA.ReadOnly = true;
            this.MA.Width = 300;
            // 
            // SOLUONG
            // 
            this.SOLUONG.HeaderText = "Quantity";
            this.SOLUONG.MinimumWidth = 6;
            this.SOLUONG.Name = "SOLUONG";
            this.SOLUONG.ReadOnly = true;
            this.SOLUONG.Width = 450;
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(90)))), ((int)(((byte)(84)))));
            this.close.Location = new System.Drawing.Point(1180, 9);
            this.close.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(32, 32);
            this.close.TabIndex = 9;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // TradeStorageDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1223, 499);
            this.ControlBox = false;
            this.Controls.Add(this.close);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TradeStorageDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityPick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox storageBefore;
        private ComboBox storageAfter;
        private Label label2;
        private Label label3;
        private Button doneBTN;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private Label close;
        private NumericUpDown quantityPick;
        private Label label4;
        private TextBox productIdTxtBox;
        private Label label5;
        private Button productPicker;
        private FontAwesome.Sharp.IconButton addProductBtn;
        private DataGridViewTextBoxColumn idProduct;
        private DataGridViewTextBoxColumn productQuantity;
        private DataGridViewTextBoxColumn MA;
        private DataGridViewTextBoxColumn SOLUONG;
    }
}