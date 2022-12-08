namespace QuanLiMyPham.GUI.Dialogs
{
    partial class EditProductDialog
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
            this.cancelBtn = new FontAwesome.Sharp.IconButton();
            this.editBtn = new FontAwesome.Sharp.IconButton();
            this.expDatePicker = new System.Windows.Forms.DateTimePicker();
            this.productionPickerBtn = new System.Windows.Forms.Button();
            this.typePickerBtn = new System.Windows.Forms.Button();
            this.ingredientTxtBox = new System.Windows.Forms.TextBox();
            this.imgPicker = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.closeBtn = new FontAwesome.Sharp.IconButton();
            this.mfgDatePicker = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.productImg = new System.Windows.Forms.PictureBox();
            this.idTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.typeTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.productionTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.priceTxtBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productImg)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Red;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancelBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.cancelBtn.IconColor = System.Drawing.Color.Black;
            this.cancelBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cancelBtn.Location = new System.Drawing.Point(533, 358);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(130, 37);
            this.cancelBtn.TabIndex = 115;
            this.cancelBtn.Text = "CANCEL";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.Lime;
            this.editBtn.FlatAppearance.BorderSize = 0;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.editBtn.IconColor = System.Drawing.Color.Black;
            this.editBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.editBtn.Location = new System.Drawing.Point(368, 358);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(110, 37);
            this.editBtn.TabIndex = 114;
            this.editBtn.Text = "EDIT";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // expDatePicker
            // 
            this.expDatePicker.CustomFormat = "dd/MM/yyyy";
            this.expDatePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.expDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.expDatePicker.Location = new System.Drawing.Point(739, 156);
            this.expDatePicker.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.expDatePicker.Name = "expDatePicker";
            this.expDatePicker.Size = new System.Drawing.Size(250, 34);
            this.expDatePicker.TabIndex = 119;
            this.expDatePicker.Value = new System.DateTime(2022, 11, 18, 16, 22, 21, 0);
            // 
            // productionPickerBtn
            // 
            this.productionPickerBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.productionPickerBtn.Location = new System.Drawing.Point(925, 265);
            this.productionPickerBtn.Name = "productionPickerBtn";
            this.productionPickerBtn.Size = new System.Drawing.Size(64, 34);
            this.productionPickerBtn.TabIndex = 117;
            this.productionPickerBtn.Text = "...";
            this.productionPickerBtn.UseVisualStyleBackColor = true;
            this.productionPickerBtn.Click += new System.EventHandler(this.productionPickerBtn_Click);
            // 
            // typePickerBtn
            // 
            this.typePickerBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.typePickerBtn.Location = new System.Drawing.Point(512, 213);
            this.typePickerBtn.Name = "typePickerBtn";
            this.typePickerBtn.Size = new System.Drawing.Size(64, 34);
            this.typePickerBtn.TabIndex = 116;
            this.typePickerBtn.Text = "...";
            this.typePickerBtn.UseVisualStyleBackColor = true;
            this.typePickerBtn.Click += new System.EventHandler(this.typePickerBtn_Click);
            // 
            // ingredientTxtBox
            // 
            this.ingredientTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ingredientTxtBox.Location = new System.Drawing.Point(739, 213);
            this.ingredientTxtBox.Name = "ingredientTxtBox";
            this.ingredientTxtBox.Size = new System.Drawing.Size(250, 34);
            this.ingredientTxtBox.TabIndex = 113;
            // 
            // imgPicker
            // 
            this.imgPicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.imgPicker.IconChar = FontAwesome.Sharp.IconChar.CameraRetro;
            this.imgPicker.IconColor = System.Drawing.Color.Black;
            this.imgPicker.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.imgPicker.IconSize = 36;
            this.imgPicker.Location = new System.Drawing.Point(23, 265);
            this.imgPicker.Name = "imgPicker";
            this.imgPicker.Size = new System.Drawing.Size(166, 49);
            this.imgPicker.TabIndex = 112;
            this.imgPicker.Text = "Edit Image";
            this.imgPicker.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.imgPicker.UseVisualStyleBackColor = true;
            this.imgPicker.Click += new System.EventHandler(this.imgPicker_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(427, 0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(16, 10, 16, 10);
            this.label7.Size = new System.Drawing.Size(187, 48);
            this.label7.TabIndex = 1;
            this.label7.Text = "EDIT PRODUCT";
            // 
            // closeBtn
            // 
            this.closeBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.IconChar = FontAwesome.Sharp.IconChar.X;
            this.closeBtn.IconColor = System.Drawing.Color.White;
            this.closeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.closeBtn.IconSize = 24;
            this.closeBtn.Location = new System.Drawing.Point(979, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(34, 50);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // mfgDatePicker
            // 
            this.mfgDatePicker.CustomFormat = "dd/MM/yyyy";
            this.mfgDatePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mfgDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.mfgDatePicker.Location = new System.Drawing.Point(739, 104);
            this.mfgDatePicker.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.mfgDatePicker.Name = "mfgDatePicker";
            this.mfgDatePicker.Size = new System.Drawing.Size(250, 34);
            this.mfgDatePicker.TabIndex = 118;
            this.mfgDatePicker.Value = new System.DateTime(2022, 11, 18, 16, 22, 21, 0);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1013, 50);
            this.panel1.TabIndex = 111;
            // 
            // productImg
            // 
            this.productImg.Location = new System.Drawing.Point(23, 90);
            this.productImg.Name = "productImg";
            this.productImg.Size = new System.Drawing.Size(166, 166);
            this.productImg.TabIndex = 97;
            this.productImg.TabStop = false;
            // 
            // idTxtBox
            // 
            this.idTxtBox.Enabled = false;
            this.idTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.idTxtBox.Location = new System.Drawing.Point(326, 104);
            this.idTxtBox.Name = "idTxtBox";
            this.idTxtBox.ReadOnly = true;
            this.idTxtBox.Size = new System.Drawing.Size(250, 34);
            this.idTxtBox.TabIndex = 98;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(246, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 28);
            this.label2.TabIndex = 99;
            this.label2.Text = "ID";
            // 
            // typeTxtBox
            // 
            this.typeTxtBox.Enabled = false;
            this.typeTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.typeTxtBox.Location = new System.Drawing.Point(326, 213);
            this.typeTxtBox.Name = "typeTxtBox";
            this.typeTxtBox.Size = new System.Drawing.Size(180, 34);
            this.typeTxtBox.TabIndex = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(246, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 28);
            this.label1.TabIndex = 101;
            this.label1.Text = "Type";
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameTxtBox.Location = new System.Drawing.Point(326, 161);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(250, 34);
            this.nameTxtBox.TabIndex = 102;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(246, 161);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(68, 28);
            this.nameLabel.TabIndex = 103;
            this.nameLabel.Text = "Name";
            // 
            // productionTxtBox
            // 
            this.productionTxtBox.Enabled = false;
            this.productionTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productionTxtBox.Location = new System.Drawing.Point(739, 265);
            this.productionTxtBox.Name = "productionTxtBox";
            this.productionTxtBox.Size = new System.Drawing.Size(180, 34);
            this.productionTxtBox.TabIndex = 104;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(617, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 28);
            this.label5.TabIndex = 105;
            this.label5.Text = "Production";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(617, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 28);
            this.label4.TabIndex = 106;
            this.label4.Text = "Ingredient";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(617, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 28);
            this.label6.TabIndex = 110;
            this.label6.Text = "EXP date";
            // 
            // priceTxtBox
            // 
            this.priceTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceTxtBox.Location = new System.Drawing.Point(326, 265);
            this.priceTxtBox.Name = "priceTxtBox";
            this.priceTxtBox.Size = new System.Drawing.Size(250, 34);
            this.priceTxtBox.TabIndex = 107;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(617, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 28);
            this.label8.TabIndex = 109;
            this.label8.Text = "MFG date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(246, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 28);
            this.label3.TabIndex = 108;
            this.label3.Text = "Price";
            // 
            // EditProductDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1013, 411);
            this.ControlBox = false;
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.expDatePicker);
            this.Controls.Add(this.productionPickerBtn);
            this.Controls.Add(this.typePickerBtn);
            this.Controls.Add(this.ingredientTxtBox);
            this.Controls.Add(this.imgPicker);
            this.Controls.Add(this.mfgDatePicker);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.productImg);
            this.Controls.Add(this.idTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.typeTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.productionTxtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.priceTxtBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditProductDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton cancelBtn;
        private FontAwesome.Sharp.IconButton editBtn;
        private DateTimePicker expDatePicker;
        private Button productionPickerBtn;
        private Button typePickerBtn;
        private TextBox ingredientTxtBox;
        private FontAwesome.Sharp.IconButton imgPicker;
        private Label label7;
        private FontAwesome.Sharp.IconButton closeBtn;
        private DateTimePicker mfgDatePicker;
        private Panel panel1;
        private PictureBox productImg;
        private TextBox idTxtBox;
        private Label label2;
        private TextBox typeTxtBox;
        private Label label1;
        private TextBox nameTxtBox;
        private Label nameLabel;
        private TextBox productionTxtBox;
        private Label label5;
        private Label label4;
        private Label label6;
        private TextBox priceTxtBox;
        private Label label8;
        private Label label3;
    }
}