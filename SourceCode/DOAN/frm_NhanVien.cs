using DXApplication1.BS_layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class frm_NhanVien : Form
    {
        public bool close = false;
        public frm_NhanVien()
        {
            InitializeComponent();
        }

        private void frm_NhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            
        }

        private void frm_NhanVien_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = BLTNhanVien.Instance.LayDS();

            txt_ChucVu.DataSource = BLTLoaiNhanVien.Instance.LayDS();
            txt_ChucVu.DisplayMember = "TenLoai";
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

            if (MessageBox.Show("Bạn có chắc muốn xóa nhân viên không?", "Xóa nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                BLTNhanVien.Instance.Xoa(txt_Ma.Text);
                gridControl1.DataSource = BLTNhanVien.Instance.LayDS();
                MessageBox.Show("Done");
            }
        }

        private void btn_Luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                DataRowView d = (DataRowView)txt_ChucVu.SelectedItem;
                string maLoai = d.Row["MaLoai"].ToString();
                switch (mStatus)
                {
                    case Status.THEM:

                        

                        BLTNhanVien.Instance.Them(txt_Ma.Text, txt_Ten.Text, int.Parse(txt_CMND.Text), txt_NgaySinh.DateTime.Date, maLoai);
                        gridControl1.DataSource = BLTNhanVien.Instance.LayDS();

                        MessageBox.Show("Done");
                        break;
                    case Status.SUA:
                        BLTNhanVien.Instance.Sua(txt_Ma.Text, txt_Ten.Text, int.Parse(txt_CMND.Text), txt_NgaySinh.DateTime.Date, maLoai);
                        gridControl1.DataSource = BLTNhanVien.Instance.LayDS();
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
            gridControl1.DataSource = BLTNhanVien.Instance.LayDS();
            mStatus = Status.NONE;

            btn_Them.Enabled = true;
            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = true;
            btn_Luu.Enabled = false;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txt_Ma.Text = gridView1.GetDataRow(e.FocusedRowHandle)["MaNV"].ToString();
            txt_Ten.Text = gridView1.GetDataRow(e.FocusedRowHandle)["TenNV"].ToString();
            txt_CMND.Text = gridView1.GetDataRow(e.FocusedRowHandle)["CMND"].ToString();
            txt_NgaySinh.DateTime = DateTime.Parse(gridView1.GetDataRow(e.FocusedRowHandle)["NgaySinh"].ToString());
            txt_ChucVu.Text = BLTLoaiNhanVien.Instance.layTenLoai(gridView1.GetDataRow(e.FocusedRowHandle)["LoaiNV"].ToString());
        }
    }
}
