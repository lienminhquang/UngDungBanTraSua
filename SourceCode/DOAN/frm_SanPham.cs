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
using System.Data.SqlClient;

namespace DXApplication1
{
    public partial class frm_SanPham : Form
    {
        Status mStatus = Status.NONE;
        public frm_SanPham()
        {
            InitializeComponent();
            nud_SoLuong.Maximum = 1000000;
            nud_GiaBan.Maximum = 1000000;
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_NhapHang f = new frm_NhapHang();
            f.ShowDialog();
            gridControl1.DataSource = BLTSanPham.Instance.LayDS();
            mStatus = Status.NONE;

            btn_Them.Enabled = true;
            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = true;
            btn_Luu.Enabled = false;
        }

        private void frm_SanPham_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = BLTSanPham.Instance.LayDS();
            txt_Loai.DataSource = BLTLoaiSP.Instance.LayDS();
            txt_Loai.DisplayMember = "TenLoai";
            
        }

        private void bbiNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (mStatus != Status.NONE)
                return;
            mStatus = Status.THEM;

            btn_Them.Enabled = false;
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_Luu.Enabled = true;
        }

        private void bbiEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (mStatus != Status.NONE)
                return;
            mStatus = Status.SUA;

            btn_Them.Enabled = false;
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_Luu.Enabled = true;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txt_Ma.Text = gridView1.GetDataRow(e.FocusedRowHandle)["MaSP"].ToString();
            txt_Loai.Text = BLTLoaiSP.Instance.LayTenLoai(gridView1.GetDataRow(e.FocusedRowHandle)["MaLoai"].ToString());
            txt_Ten.Text = gridView1.GetDataRow(e.FocusedRowHandle)["TenSP"].ToString();
            rtxt_ChiTiet.Text = gridView1.GetDataRow(e.FocusedRowHandle)["ChiTiet"].ToString();
            rtxt_GhiChu.Text = gridView1.GetDataRow(e.FocusedRowHandle)["GhiChu"].ToString();
            //string a = gridView1.GetDataRow(e.FocusedRowHandle)["Gia"].ToString();
            nud_GiaBan.Value = (int)float.Parse(gridView1.GetDataRow(e.FocusedRowHandle)["Gia"].ToString());
            nud_SoLuong.Value = (int)float.Parse(gridView1.GetDataRow(e.FocusedRowHandle)["SoLuong"].ToString());
        }

        private void btn_Xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (mStatus != Status.NONE)
                return;

            if (MessageBox.Show("Bạn có chắc muốn xóa loại sản phẩm không?", "Xóa loại sản phẩm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    BLTSanPham.Instance.Xoa(txt_Ma.Text);
                    gridControl1.DataSource = BLTSanPham.Instance.LayDS();
                    MessageBox.Show("Done");
                }
                catch (Exception err)
                {

                    MessageBox.Show(err.Message);
                }
                
            }
        }

        private void btn_Luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                DataRowView o = (DataRowView)txt_Loai.SelectedItem;
                string maloai = o.Row[0].ToString();
                switch (mStatus)
                {
                    case Status.THEM:
                        

                        BLTSanPham.Instance.Them(txt_Ma.Text, maloai, txt_Ten.Text, rtxt_ChiTiet.Text, rtxt_GhiChu.Text, (int)nud_SoLuong.Value, (int)nud_GiaBan.Value);
                        gridControl1.DataSource = BLTSanPham.Instance.LayDS();

                        MessageBox.Show("Done");
                        break;
                    case Status.SUA:
                        BLTSanPham.Instance.Sua(txt_Ma.Text, maloai, txt_Ten.Text, rtxt_ChiTiet.Text, rtxt_GhiChu.Text, (int)nud_SoLuong.Value, (int)nud_GiaBan.Value);
                        gridControl1.DataSource = BLTSanPham.Instance.LayDS();
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
            catch (SqlException err)
            {

                MessageBox.Show(err.Message);
            }

        }

        private void btn_TaiLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControl1.DataSource = BLTSanPham.Instance.LayDS();
            mStatus = Status.NONE;

            btn_Them.Enabled = true;
            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = true;
            btn_Luu.Enabled = false;
        }
    }
}
