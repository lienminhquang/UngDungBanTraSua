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
    public partial class frm_TaiKhoan : Form
    {


        private Status mStatus;

        public frm_TaiKhoan()
        {
            InitializeComponent();
            mStatus = Status.NONE;
            //txt_TenDN.Enabled = false;
        }

        private void btn_TaiLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControl1.DataSource = BLTTaiKhoan.Instance.LayDanhSachTaiKhoan();
            mStatus = Status.NONE;

            btn_Them.Enabled = true;
            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = true;
            btn_Luu.Enabled = false;
        }

        private void frm_TaiKhoan_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = BLTTaiKhoan.Instance.LayDanhSachTaiKhoan();
        }

        private void btn_Them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (mStatus != Status.NONE)
                return;

            mStatus = Status.THEM;

            btn_Them.Enabled = false;
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_Luu.Enabled = true;

        }

        private void btn_Luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            
            try
            {
                switch (mStatus)
                {
                    case Status.THEM:
                        BLTTaiKhoan.Instance.ThemTaiKhoan(cb_MaNV.Text, txt_TenDN.Text, txt_MK.Text);
                        gridControl1.DataSource = BLTTaiKhoan.Instance.LayDanhSachTaiKhoan();
                       
                        MessageBox.Show("Done");
                        break;
                    case Status.SUA:
                        BLTTaiKhoan.Instance.SuaTaiKhoan(cb_MaNV.Text, txt_MK.Text);
                        gridControl1.DataSource = BLTTaiKhoan.Instance.LayDanhSachTaiKhoan();
                        MessageBox.Show("Done");
                        break;
                    case Status.XOA:
                        
                        break;
                    case Status.NONE:
                        break;
                    default:
                        break;
                }

                mStatus = Status.NONE;

                btn_Them.Enabled = true;
                btn_Sua.Enabled = true;
                btn_Xoa.Enabled = true;
                btn_Luu.Enabled = false;
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }

           

        }

        private void btn_Sua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (mStatus != Status.NONE)
                return;
            mStatus = Status.SUA;

            btn_Them.Enabled = false;
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_Luu.Enabled = true;
        }

        private void btn_Xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (mStatus != Status.NONE)
                return;

            if (MessageBox.Show("Bạn có chắc muốn xóa tài khoản không?", "Xóa tài khoản", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                BLTTaiKhoan.Instance.XoaTaiKhoan(cb_MaNV.Text);
                gridControl1.DataSource = BLTTaiKhoan.Instance.LayDanhSachTaiKhoan();

                MessageBox.Show("Done");
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            cb_MaNV.Text = gridView1.GetDataRow(e.FocusedRowHandle)["MaNV"].ToString();
            txt_TenDN.Text = gridView1.GetDataRow(e.FocusedRowHandle)["TenDN"].ToString();
            txt_MK.Text = gridView1.GetDataRow(e.FocusedRowHandle)["MatKhau"].ToString();
        }
    }
}
