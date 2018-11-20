using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DXApplication1.BS_layer;

namespace DXApplication1
{
    public partial class frm_DoiTaiKhoan : Form
    {

  

        public frm_DoiTaiKhoan()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(BLTTaiKhoan.Instance.DangNhapAdmin(txtTenDN.Text, txtMatKhau.Text).ToString());
        }

        private void frm_DoiTaiKhoan_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
