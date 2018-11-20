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
    public partial class frm_ThongTinTaiKhoan : Form
    {
        public frm_ThongTinTaiKhoan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_DoiMatKhau f = new frm_DoiMatKhau(txt_Ma.Text);
            f.ShowDialog();
            DataTable dt = BLTNhanVien.Instance.LayThongTinNhanVienvaTaiKhoan(Form1.Instance.getManv()).Tables[0];
            txt_Ma.Text = dt.Rows[0]["MaNV"].ToString();
            txt_Ten.Text = dt.Rows[0]["TenNV"].ToString();
            txt_TenTK.Text = dt.Rows[0]["TenDN"].ToString();
            txt_MK.Text = dt.Rows[0]["MatKhau"].ToString();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_ThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            DataTable dt =  BLTNhanVien.Instance.LayThongTinNhanVienvaTaiKhoan(Form1.Instance.getManv()).Tables[0];
            txt_Ma.Text = dt.Rows[0]["MaNV"].ToString();
            txt_Ten.Text = dt.Rows[0]["TenNV"].ToString();
            txt_TenTK.Text = dt.Rows[0]["TenDN"].ToString();
            txt_MK.Text = dt.Rows[0]["MatKhau"].ToString();

        }
    }
}
