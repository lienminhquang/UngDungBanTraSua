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
    public partial class frm_LoaiSanPham : Form
    {
        
        public frm_LoaiSanPham()
        {
            InitializeComponent();
        }

        private void frm_LoaiSanPham_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource =  BLTLoaiSP.Instance.LayDS();         
        }

        Status mStatus = Status.NONE;
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
            
            if(MessageBox.Show("Bạn có chắc muốn xóa loại sản phẩm không?", "Xóa loại sản phẩm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                BLTLoaiSP.Instance.Xoa(txt_Ma.Text);
                gridControl1.DataSource = BLTLoaiSP.Instance.LayDS();
                MessageBox.Show("Done");
            }
        }

        private void btn_Luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                switch (mStatus)
                {
                    case Status.THEM:
                        BLTLoaiSP.Instance.Them(txt_Ma.Text, txt_Ten.Text, rtxt_ChiTiet.Text);
                        gridControl1.DataSource = BLTLoaiSP.Instance.LayDS();

                        MessageBox.Show("Done");
                        break;
                    case Status.SUA:
                        BLTLoaiSP.Instance.Sua(txt_Ma.Text, txt_Ten.Text, rtxt_ChiTiet.Text);
                        gridControl1.DataSource = BLTLoaiSP.Instance.LayDS();
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

        private void btn_TaiLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControl1.DataSource = BLTLoaiSP.Instance.LayDS();
            mStatus = Status.NONE;

            btn_Them.Enabled = true;
            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = true;
            btn_Luu.Enabled = false;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txt_Ma.Text = gridView1.GetDataRow(e.FocusedRowHandle)["MaLoai"].ToString();
            txt_Ten.Text = gridView1.GetDataRow(e.FocusedRowHandle)["TenLoai"].ToString();
            rtxt_ChiTiet.Text = gridView1.GetDataRow(e.FocusedRowHandle)["ChiTiet"].ToString();
        }
    }
}
