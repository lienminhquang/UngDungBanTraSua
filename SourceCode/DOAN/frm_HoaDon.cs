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

    
    public partial class frm_HoaDon : Form
    {

        Status mStatus = Status.NONE;
        public frm_HoaDon()
        {
            InitializeComponent();
        }

        private void frm_HoaDon_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = BLTHoaDon.Instance.LayDS();
            txt_NV.DataSource = BLTNhanVien.Instance.LayDS();
            txt_NV.DisplayMember = "TenNV";
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

            if (MessageBox.Show("Bạn có chắc muốn xóa hóa đơn không?", "Xóa hóa đơn", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    BLTHoaDon.Instance.Xoa(txt_MaHoaDon.Text);
                    gridControl1.DataSource = BLTHoaDon.Instance.LayDS();
                    MessageBox.Show("Done");
                }
                catch (Exception err)
                {

                    MessageBox.Show(err.Message);
                }

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

        private void btn_Luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                DataRowView d = (DataRowView)txt_NV.SelectedItem;
                string manv = d.Row["MaNV"].ToString();

                switch (mStatus)
                {
                    case Status.THEM:
                        BLTHoaDon.Instance.Them(txt_MaHoaDon.Text, manv, de_Ngay.DateTime);
                        gridControl1.DataSource = BLTHoaDon.Instance.LayDS();

                        MessageBox.Show("Done");
                        break;
                    case Status.SUA:
                        BLTHoaDon.Instance.Sua(txt_MaHoaDon.Text, manv, de_Ngay.DateTime);
                        gridControl1.DataSource = BLTHoaDon.Instance.LayDS();
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

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {


            txt_MaHoaDon.Text = gridView1.GetDataRow(e.FocusedRowHandle)["MaHD"].ToString();
            txt_NV.Text = BLTNhanVien.Instance.layTenNV(gridView1.GetDataRow(e.FocusedRowHandle)["MaNVPV"].ToString());
            de_Ngay.Text = gridView1.GetDataRow(e.FocusedRowHandle)["Ngay"].ToString();          
        }
    }
}
