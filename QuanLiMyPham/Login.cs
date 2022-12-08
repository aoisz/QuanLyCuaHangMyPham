using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace QuanLiMyPham
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        private void userNameInput_Click(object sender, EventArgs e)
        {
            userPic.BackgroundImage = Properties.Resources.user1;
            passPic.BackgroundImage = Properties.Resources.padlock;
        }

        private void userNameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void passWordInput_Click(object sender, EventArgs e)
        {
            userPic.BackgroundImage = Properties.Resources.user;
            passPic.BackgroundImage = Properties.Resources.padlock1;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            String sql = "Select MA, MATKHAU from `taikhoan` where TENDANGNHAP = '" + userNameInput.Text + "'";
            MySqlDataReader dr = MySQLConnection.ToQuery(sql);
            string pwd = "";
            string id = "";
            if(!dr.HasRows)
            {
                MessageBox.Show("This username is not existed!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            while(dr.Read())
            {
                id = dr.GetString("MA");
                pwd = dr.GetString("MATKHAU");
            }
            if(pwd == passWordInput.Text) 
            {
                MainForm mainForm = new MainForm(id);
                MessageBox.Show("Login succesfully!", "Succesful");
                this.Hide();
                mainForm.Show();
                mainForm.Closed += (s, args) => this.Close();
            }
            else if (passWordInput.Text.Length == 0)
            {
                MessageBox.Show("Enter password!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Wrong password!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
