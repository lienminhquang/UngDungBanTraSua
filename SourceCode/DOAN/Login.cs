using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Globalization;
using DXApplication1.BS_layer;
namespace DOAN
{ 
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            pictureBox2.Image = Properties.Resources._lock; ;
  

        }
        //đổi hình khóa khi muốn ẩn hiển mật khẩu
        void unlock()
        {
            if (txtPass.PasswordChar == '*')
            {
                txtPass.PasswordChar = '\0';
                pictureBox2.Image =Properties.Resources.show ;
            }
            else
            {
                txtPass.PasswordChar = '*';
                pictureBox2.Image = Properties.Resources._lock;
            }
        }
        private void lockun(object sender, EventArgs e)
        {
            unlock();
        }
        void Enter1(object sender, EventArgs e)
        {
            if (txtUser.Text == "User Name")
            {
                txtUser.Text = string.Empty;
            }
        }
        void Leave1(object sender, EventArgs e)
        {
            if (txtUser.Text == string.Empty)
            {
                txtUser.Text = "User Name";
            }
        }

        void Enter2(object sender, EventArgs e)
        {
            if (txtPass.Text == "Password")
            {
                txtPass.PasswordChar = '*';
                pictureBox2.Enabled = true;
                txtPass.Text = string.Empty;
            }
        }
        void Leave2(object sender, EventArgs e)
        {
            if (txtPass.Text == string.Empty)
            {
                txtPass.PasswordChar = '\0';
                pictureBox2.Enabled = false;
                txtPass.Text = "Password";
            }
        }

        private void bubtnLogin_Click(object sender, EventArgs e)
        {
            string tenDN = txtUser.Text;
            string matkhau = txtPass.Text;
            int kiemtra;
            kiemtra = DXApplication1.BS_layer.BLTTaiKhoan.Instance.DangNhap(tenDN, matkhau);
            if (kiemtra == 2)
            {
               
               MainContent a = new MainContent();
               a.setMaNV(DXApplication1.BS_layer.BLTTaiKhoan.Instance.LayMaNV(tenDN));
                this.Hide();
               a.ShowDialog();
                this.Close();
               
            }
            else if (kiemtra == 1)
            {
                this.Hide();
                DXApplication1.Form1.Instance.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("Bạn đã nhập thông tin sai !!!");





        }
        // xử lí đăng nhập

    }
}
