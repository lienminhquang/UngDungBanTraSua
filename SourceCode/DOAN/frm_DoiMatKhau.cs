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
   
    public partial class frm_DoiMatKhau : Form
    {
        
        string manv;
        public frm_DoiMatKhau(string manv)
        {
            InitializeComponent();
            this.manv = manv;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_mk_moi.Text != txt_mk_moi2.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp.");
                return;
            }

            try
            {
                BLTTaiKhoan.Instance.DoiMatKhau(manv, txt_mk_cu.Text, txt_mk_moi.Text);
                MessageBox.Show("Done");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
