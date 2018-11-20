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
    public partial class frm_ChiTietHoaDon : Form
    {

        Status mStatus = Status.NONE;

        public frm_ChiTietHoaDon()
        {
            InitializeComponent();
            //txt_MaSP.Enabled = false;
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

            if (MessageBox.Show("Bạn có chắc muốn xóa CTHD không?", "Xóa CTHD", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    BLT_CTHD.Instance.Xoa(txt_MaHD.Text, txt_MaSP.Text);
                    gridControl1.DataSource = BLT_CTHD.Instance.LayDS();
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
                DataRowView d = (DataRowView)txt_MaSP.SelectedItem;
                string maSP = d.Row["MaSP"].ToString();

                switch (mStatus)
                {
                    case Status.THEM:
                        BLT_CTHD.Instance.Them(txt_MaHD.Text, maSP, (int)txt_SoLuong.Value, (int)txt_GiaBan.Value);
                        gridControl1.DataSource = BLT_CTHD.Instance.LayDS();

                        MessageBox.Show("Done");
                        break;
                    case Status.SUA:
                        BLT_CTHD.Instance.Sua(txt_MaHD.Text, maSP, (int)txt_SoLuong.Value, (int)txt_GiaBan.Value);
                        gridControl1.DataSource = BLT_CTHD.Instance.LayDS();
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
            gridControl1.DataSource = BLT_CTHD.Instance.LayDS();
            mStatus = Status.NONE;

            btn_Them.Enabled = true;
            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = true;
            btn_Luu.Enabled = false;
        }

        private void frm_ChiTietHoaDon_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = BLT_CTHD.Instance.LayDS();
            txt_MaSP.DataSource = BLTSanPham.Instance.LayDS();
            txt_MaSP.DisplayMember = "TenSP";
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {


            txt_MaHD.Text = gridView1.GetDataRow(e.FocusedRowHandle)["MaHoaDon"].ToString();
            txt_MaSP.Text = BLTSanPham.Instance.layTenSP(gridView1.GetDataRow(e.FocusedRowHandle)["MaSP"].ToString());
            txt_SoLuong.Text = gridView1.GetDataRow(e.FocusedRowHandle)["SoLuongDat"].ToString();
            txt_GiaBan.Text = gridView1.GetDataRow(e.FocusedRowHandle)["GiaBan"].ToString();
        }
    }
}
