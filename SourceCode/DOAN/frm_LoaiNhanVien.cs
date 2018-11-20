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

    public partial class frm_LoaiNhanVien : Form
    {
        Status mStatus = Status.NONE;
        public frm_LoaiNhanVien()
        {
            InitializeComponent();
        }

        private void frm_LoaiNhanVien_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = BLTLoaiNhanVien.Instance.LayDS();
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

            if (MessageBox.Show("Bạn có chắc muốn xóa loại nhân viên không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    BLTLoaiNhanVien.Instance.Xoa(txt_Ma.Text);
                    gridControl1.DataSource = BLTLoaiNhanVien.Instance.LayDS();
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
                switch (mStatus)
                {
                    case Status.THEM:
                        BLTLoaiNhanVien.Instance.Them(txt_Ma.Text, txt_Ten.Text);
                        gridControl1.DataSource = BLTLoaiNhanVien.Instance.LayDS();

                        MessageBox.Show("Done");
                        break;
                    case Status.SUA:
                        BLTLoaiNhanVien.Instance.Sua(txt_Ma.Text, txt_Ten.Text);
                        gridControl1.DataSource = BLTLoaiNhanVien.Instance.LayDS();
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
            gridControl1.DataSource = BLTLoaiNhanVien.Instance.LayDS();
            mStatus = Status.NONE;

            btn_Them.Enabled = true;
            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = true;
            btn_Luu.Enabled = false;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                txt_Ma.Text = gridView1.GetDataRow(e.FocusedRowHandle)["MaLoai"].ToString();
                txt_Ten.Text = gridView1.GetDataRow(e.FocusedRowHandle)["TenLoai"].ToString();
            }
            catch (Exception)
            {

        
            }
            
        }
    }
}
