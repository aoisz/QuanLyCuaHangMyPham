namespace QuanLiMyPham
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userPic = new System.Windows.Forms.PictureBox();
            this.userNameInput = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.passWordInput = new System.Windows.Forms.TextBox();
            this.passPic = new System.Windows.Forms.PictureBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passPic)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(280, 86);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // userPic
            // 
            this.userPic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userPic.BackgroundImage")));
            this.userPic.Location = new System.Drawing.Point(148, 274);
            this.userPic.Margin = new System.Windows.Forms.Padding(2);
            this.userPic.Name = "userPic";
            this.userPic.Size = new System.Drawing.Size(32, 32);
            this.userPic.TabIndex = 1;
            this.userPic.TabStop = false;
            // 
            // userNameInput
            // 
            this.userNameInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.userNameInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userNameInput.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userNameInput.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.userNameInput.HideSelection = false;
            this.userNameInput.Location = new System.Drawing.Point(192, 274);
            this.userNameInput.Margin = new System.Windows.Forms.Padding(2);
            this.userNameInput.Name = "userNameInput";
            this.userNameInput.PlaceholderText = "Enter username";
            this.userNameInput.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.userNameInput.Size = new System.Drawing.Size(362, 27);
            this.userNameInput.TabIndex = 2;
            this.userNameInput.TabStop = false;
            this.userNameInput.Click += new System.EventHandler(this.userNameInput_Click);
            this.userNameInput.TextChanged += new System.EventHandler(this.userNameInput_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(148, 308);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 1);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(148, 400);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(406, 1);
            this.panel2.TabIndex = 6;
            // 
            // passWordInput
            // 
            this.passWordInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.passWordInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passWordInput.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passWordInput.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.passWordInput.HideSelection = false;
            this.passWordInput.Location = new System.Drawing.Point(192, 366);
            this.passWordInput.Margin = new System.Windows.Forms.Padding(2);
            this.passWordInput.Name = "passWordInput";
            this.passWordInput.PlaceholderText = "Enter password";
            this.passWordInput.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.passWordInput.Size = new System.Drawing.Size(362, 27);
            this.passWordInput.TabIndex = 5;
            this.passWordInput.TabStop = false;
            this.passWordInput.UseSystemPasswordChar = true;
            this.passWordInput.Click += new System.EventHandler(this.passWordInput_Click);
            // 
            // passPic
            // 
            this.passPic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("passPic.BackgroundImage")));
            this.passPic.Location = new System.Drawing.Point(148, 366);
            this.passPic.Margin = new System.Windows.Forms.Padding(2);
            this.passPic.Name = "passPic";
            this.passPic.Size = new System.Drawing.Size(32, 32);
            this.passPic.TabIndex = 4;
            this.passPic.TabStop = false;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.loginBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(90)))), ((int)(((byte)(84)))));
            this.loginBtn.Location = new System.Drawing.Point(249, 463);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(0);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(172, 50);
            this.loginBtn.TabIndex = 7;
            this.loginBtn.Text = "LOGIN";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(90)))), ((int)(((byte)(84)))));
            this.close.Location = new System.Drawing.Point(657, 9);
            this.close.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(32, 32);
            this.close.TabIndex = 8;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.label1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(700, 662);
            this.ControlBox = false;
            this.Controls.Add(this.close);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.passWordInput);
            this.Controls.Add(this.passPic);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.userNameInput);
            this.Controls.Add(this.userPic);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox userPic;
        private TextBox userNameInput;
        private Panel panel1;
        private Panel panel2;
        private TextBox passWordInput;
        private PictureBox passPic;
        private Button loginBtn;
        private Label close;
    }
}